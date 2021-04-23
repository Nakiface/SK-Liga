using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Controller
{
    public static class JsonController
    {
        public static object Load(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                object context = (object)serializer.Deserialize(file, typeof(object));
                return context;
            }
        }

        public static void Save(string path, object context)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, context);
            }
        }
    }
}
