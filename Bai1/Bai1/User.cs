using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bai1
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string birthDay { get; set; }
        public string Email { get; set; }

        public User(string id, string name, string birthDay, string email)
        {
            Id = id;
            Name = name;
            this.birthDay = birthDay;
            Email = email;
        }

        public static List<User> LoadUsers()
        {
            var users = new List<User>();
            string filePath = Path.Combine(Application.StartupPath, "dulieu.txt");
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        users.Add(new User(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim()
                        ));
                    }
                }
            }
            return users;
        }

        public static void AddUser(User user)
        {
            string filePath = Path.Combine(Application.StartupPath, "dulieu.txt");
            string line = $"{user.Id};{user.Name};{user.birthDay};{user.Email}";
            File.AppendAllText(filePath, line + Environment.NewLine);
        }



    }
}
