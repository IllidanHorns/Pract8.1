using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Pract8._1
{
    public class SaveRecords
    {
        internal static string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RecordsOfUsers.json");
        public static void Records(User UserEndInformation)
        {
            if (File.Exists(path))
            {
                    string txt = File.ReadAllText(path);
                    List<User> Records = JsonConvert.DeserializeObject<List<User>>(txt);
                    Records.Add(UserEndInformation);
                    string json = JsonConvert.SerializeObject(Records);
                    File.WriteAllText(path, json);
                    Final();
            }
            else
            {
                File.Create(path).Close();
                List<User> Records = new List<User>();
                Records.Add(UserEndInformation);
                string json = JsonConvert.SerializeObject(Records);
                File.WriteAllText(path, json);
                Final();
            }
        }
        private static void Final()
        {
            Console.Clear();
            string txt = File.ReadAllText(path);
            List<User> Records = JsonConvert.DeserializeObject<List<User>>(txt);
            foreach (User i in Records) 
            {
                Console.Write("Имя - " + i.UserName + " Кол-во мин. - " + i.WordsInMinute + " Кол-во сек. - " + i.WordsInSecond + "\n");
            }
            Console.WriteLine("   ");
            Console.WriteLine("Введите Enter если хотите продолжить");
            while (true) 
            {
                var UserButton = Console.ReadKey(true);
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                TextWork.Main();
                break;
            }
        }
    }
}
