using Newtonsoft.Json;
using SK_Liga.Model.Base;
using SK_Liga.Model.Config;
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

        public static Config LoadConfig(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                Config context = (Config)serializer.Deserialize(file, typeof(Config));
                return context;
            }
        }

        public static DataSet LoadData(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                DataSet context = (DataSet)serializer.Deserialize(file, typeof(DataSet));
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
