using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
    {
        public static string Path = @"AllUsersResults.json";

        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }
        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(Path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(Path);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return usersResults;
        }

        public static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

    }
}
