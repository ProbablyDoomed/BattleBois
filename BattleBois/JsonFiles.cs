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
        public static String COMMON_JSON_DIR = "CommonJson";

        //Wrapper class to represent this specific use of a String-String dictionary
        public static Dictionary<String, String> JsonFilePaths = new Dictionary<String, String>();

        public static void LoadFilePaths()
        {
            JsonFilePaths = LoadFromCommonDirectory<Dictionary<String, String>>("FilePaths.json");
        }

        public static void SaveFilePaths()
        {
            SaveAsToCommonDirectory<Dictionary<String, String>>("FilePaths.json", JsonFilePaths);
        }

        public static T LoadFromCommonDirectory<T>(String fileName)
        {
            String fullPath = COMMON_JSON_DIR + '\\' + fileName;
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

        public static void SaveAsToCommonDirectory<T>(String fileName, T item)
        {
            String fullPath = COMMON_JSON_DIR + '\\' + fileName;
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
