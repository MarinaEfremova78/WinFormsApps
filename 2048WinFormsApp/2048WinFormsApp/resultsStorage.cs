using Newtonsoft.Json;
using System.Collections.Generic;

namespace _2048WinFormsApp
{
    class resultsStorage
    {
        public static string Path = @"results.json";        

        public static List<User> GetAll()
        {
            if(!FileProvider.Exists(Path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(Path);
            var allResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return allResults;
        }
        public static void Save(List<User> allResults)
        {
            var jsonData = JsonConvert.SerializeObject(allResults, Formatting.Indented);
            FileProvider.Append(Path, jsonData);
        }
        public static void Append(User user)
        {
            var previousResults = GetAll();
            previousResults.Add(user);
            Save(previousResults);
        }        
    }
}
