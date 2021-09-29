using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ObsSocialMediaNotifier.Configurations
{

    public static class Config
    {
        public static string MainConfigFilePath { get; private set; }
        public static string BotsConfigFilePath { get; private set; }
        public static string BotsConfigFileName { get; private set; }
        public static string AppDataFolder { get; private set; }
        public static string MainConfigFileName { get; private set; }

        private static string _botsConfigElementName;
        private static XDeclaration _xDeclaration;

        public static void Set()
        {
            #region Constants

            AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.ProductName);
            MainConfigFileName = "AppConfig.xml";
            MainConfigFilePath = $@"{AppDataFolder}\{MainConfigFileName}";
            BotsConfigFileName = "BotsConfig.xml";
            _botsConfigElementName = "BotsConfig";
            _xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            
            #endregion

            if (!Directory.Exists(AppDataFolder))
                Directory.CreateDirectory(AppDataFolder);

            if (!File.Exists(MainConfigFilePath))
                CreateMainConfigFile();

            SetBotsConfigFilePath();
        }

        /// <summary>
        /// User default BotsConfig
        /// </summary>
        /// <param name="userConfigFilePath">Full filepath of User default botsConfig</param>
        public static void SaveNewDefaultBotsConfig(string userConfigFilePath)
        {
            var configxml = new XDocument(_xDeclaration,
                new XComment($@"Last update: {DateTime.Now}"),
                new XElement(_botsConfigElementName, userConfigFilePath));

            configxml.Save(@$"{AppDataFolder}\{MainConfigFileName}");
        }

        private static void SetBotsConfigFilePath()
        {
            var doc = new XmlDocument();

            try
            {
                doc.Load(MainConfigFilePath);
                BotsConfigFilePath = doc.DocumentElement.GetElementsByTagName(_botsConfigElementName)[0].InnerText;
            }
            catch
            {
                BotsConfigFilePath = $@"{AppDataFolder}\{BotsConfigFileName}";
            }
        }

        private static void CreateMainConfigFile()
        {
            var configxml = new XDocument(_xDeclaration,
                new XComment($@"Last update: {DateTime.Now}"),
                new XElement(_botsConfigElementName, $@"{AppDataFolder}\{BotsConfigFileName}"));

            configxml.Save(@$"{AppDataFolder}\{MainConfigFileName}");
        }
    }
}
