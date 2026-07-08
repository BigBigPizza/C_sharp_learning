using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace Save_load_file
{
    public class JsonSaveAndWrite
    {
        public static void SaveUserData(User user)
        {
            string FilePath = $"{user.Name}.json";

            string JsonFormattedData = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(FilePath, JsonFormattedData);

            Console.WriteLine($"The user data for {user.Name} has beens saved to {FilePath}");
        }
        public static User? RetriveUserData(string userName)
        {
            string FilePath = $"{userName}.json";

            try
            {
                if (!File.Exists(FilePath))
                {
                    return null;
                    
                }
                string UserDataString = File.ReadAllText(FilePath);
                if (!string.IsNullOrWhiteSpace(UserDataString))
                {
                    User LoadedUser = JsonSerializer.Deserialize<User>(UserDataString);
                    return LoadedUser;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex.Message}");
                return null;
            }
        }
    }
}
