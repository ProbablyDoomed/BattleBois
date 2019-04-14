using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BattleBois
{
    static class JsonFiles
    {
        public static readonly Dictionary<Type, String> TYPE_DIRECTORIES = new Dictionary<Type, string>
        {
            [typeof(CUnit)] = "Units",
            [typeof(CCommander)] = "Commanders",
            [typeof(CArmy)] = "Armies",
            [typeof(CBattle)] = "Battles",

            [typeof(TraitReference.TraitDefinitions)] = "CommonJson"
        };

        public static T LoadFromDefault<T>(String fileName)
        {
            String fullPath = fileName;
            try
            {
                fullPath = TYPE_DIRECTORIES[typeof(T)] + '\\' + fileName;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("No directory for type," + typeof(T).ToString() + ", will check top level.");
            }

            return LoadFrom<T>(fullPath);
        }

        public static T LoadFrom<T>(String filePath)
        {
            T jsonObject;
            String fileContent = "";

            try
            {
                fileContent = File.ReadAllText(filePath);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString() + e.Message);
            }

            jsonObject = JsonConvert.DeserializeObject<T>(fileContent);
            return jsonObject;
        }

        public static void SaveAsToDefault<T>(String fileName, T item)
        {
            String fullPath = fileName;

            try
            {
                fullPath = TYPE_DIRECTORIES[typeof(T)] + '\\' + fileName;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("No directory for type," + typeof(T).ToString() + ", will save at top level.");
            }

            SaveAs<T>(fullPath, item);
        }

        public static void SaveAs<T>(String filePath, T item)
        {
            String fileContent = JsonConvert.SerializeObject(item, Formatting.Indented);
            
            try
            {
                File.WriteAllText(filePath, fileContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString() + e.Message);
            }
        }
    }
}
