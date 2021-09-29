using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;


namespace ObsSocialMediaNotifier.Configurations
{
    public class BotsConfig
    {

        public XmlDocument BotsConfigXmlDocument { get; private set; }
        public TelegramConfig TelegramData { get; set; }
        public XDocument BotsXDocument { get; set; }


        public BotsConfig()
        {
            BotsConfigXmlDocument = new XmlDocument();
            BotsConfigXmlDocument.Load(Config.BotsConfigFilePath);
            BotsXDocument = new XDocument(new XDeclaration("1.0", "utf-8", "Yes"),
                new XComment($@"Last update: {DateTime.Now}"),
                new XElement("root"));
        }

        // ToDo: Testen
        public void Save(string botName,  KeyValuePair<string,string>[] kvpBotAttributes)
        {
            List<XElement> elemtList = new();

            foreach (KeyValuePair<string, string> kvp in kvpBotAttributes)
            {
                elemtList.Add(new XElement(kvp.Key, kvp.Value));

            }
            BotsXDocument.Add(new XElement(botName, elemtList));

            BotsXDocument.Save(Config.BotsConfigFilePath);

            //var configxml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
            //    new XElement("Telegram",
            //    new XElement(nameof(TelegramConfig.IsEnabled), TelegramConfig.IsEnabled),
            //    new XElement(nameof(TelegramConfig.TargetChanel), TelegramConfig.TargetChanel),
            //    new XElement(nameof(TelegramConfig.ApiKey), Convert.ToBase64String(Encoding.UTF8.GetBytes(TelegramConfig.ApiKey))),
            //    new XElement(nameof(TelegramConfig.Message), TelegramConfig.Message),
            //    new XElement(nameof(TelegramConfig.Attachment), TelegramConfig.Attachment),
            //    new XElement(nameof(TelegramConfig.RepostingIsEnabled), TelegramConfig.RepostingIsEnabled),
            //    new XElement(nameof(TelegramConfig.OnlyOnFileUpdate), TelegramConfig.OnlyOnFileUpdate),
            //    new XElement(nameof(TelegramConfig.RepostMessage), TelegramConfig.RepostMessage),
            //    new XElement(nameof(TelegramConfig.RepostFile), TelegramConfig.RepostFile),
            //    new XElement(nameof(TelegramConfig.RepostIntervalInMinutes), TelegramConfig.RepostIntervalInMinutes)));

            //configxml.Save(_botsConfigfilePath);
        }


        //readonly XmlElement _root;
        //protected string Helper(string propname)
        //{
        //    return _root.GetElementsByTagName(propname)[0].InnerText;
        //}

        internal string GetXmlValue(string parent, string elementName)
        {

            return "";
        }
    }
}
