using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Linq;

namespace Ежедневник
{
    internal class SaveIt
    {
        private static string address = "C:\\Users\\misha\\Рабочий стол\\zametki.json";

        public static T MyDeserialize<T>()
        {
            var fils = "";
            if (!File.Exists(address))
            {
                File.Create(address);
                fils = File.ReadAllText(address);
            }
            else
            {
                fils = File.ReadAllText(address);
            }
            return JsonConvert.DeserializeObject<T>(fils);
        }

        public static void MySerialyze<T>(T AppendIt)
        {
            var json = JsonConvert.SerializeObject(AppendIt);
            File.WriteAllText(json, address);
        }
    }
}
