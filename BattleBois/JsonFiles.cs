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
        private static readonly Dictionary<Type, String> TYPE_DIRECTORIES = new Dictionary<Type, string>
        {
            [typeof(CUnit)]      = "Units",
            [typeof(CCommander)] = "Commanders",
            [typeof(CArmy)]      = "Armies",
            [typeof(CBattle)]    = "Battles",
        };

        public static T LoadFrom<T>(String fileName)
        {
            T jsonObject;
            String fileContent = "";
            String fullPath = fileName;

            try
            {
                fullPath = TYPE_DIRECTORIES[typeof(T)] + '\\' + fileName;
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("No directory for type," + typeof(T).ToString() + ", will check top level.");
            }

            try
            {
                fileContent = File.ReadAllText(fullPath);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString() + e.Message);
            }

            jsonObject = JsonConvert.DeserializeObject<T>(fileContent);
            return jsonObject;
        }

        public static void SaveAs<T>(String fileName, T item)
        {
            String fileContent = JsonConvert.SerializeObject(item, Formatting.Indented);
            String fullPath = fileName;

            try
            {
                fullPath = TYPE_DIRECTORIES[typeof(T)] + '\\' + fileName;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("No directory for type," + typeof(T).ToString() + ", will save at top level.");
            }

            try
            {
                File.WriteAllText(fullPath, fileContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString() + e.Message);
            }
        }
    }
}
