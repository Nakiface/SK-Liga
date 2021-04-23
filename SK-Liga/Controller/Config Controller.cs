using SK_Liga.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Controller
{
    public static class Config_Controller
    {
        public static void CreateFirstConfig(string configPath)
        {
            Config config = new Config() { DataPath = configPath };
            JsonController.Save(configPath, config);
        }

        public static void CreateFirstConfig()
        {
            ConfigSettings configSettings = new ConfigSettings();
            Config config = new Config() { DataPath = configSettings.configPath };
            JsonController.Save(configSettings.configPath, config);
        }

        public static Config LoadConfig(string configPath)
        {
            Config config = (Config)JsonController.Load(configPath);
            return config;
        }

        public static Config LoadConfig()
        {
            ConfigSettings configSettings = new ConfigSettings();
            Config config = (Config)JsonController.Load(configSettings.configPath);
            return config;
        }
    }
}
