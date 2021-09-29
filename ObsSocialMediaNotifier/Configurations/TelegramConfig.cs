using System;
using System.Text;

namespace ObsSocialMediaNotifier.Configurations
{
    public class TelegramConfig : BotsConfig
    {
        public bool IsEnabled { get; set; } = false;
        public string TargetChanel { get; set; } = "";
        public string ApiKey { get; set; } = "";
        public string Message { get; set; } = "";
        public string Attachment { get; set; } = "";
        public bool RepostingIsEnabled { get; set; } = false;
        public bool OnlyOnFileUpdate { get; set; } = true;
        public string RepostMessage { get; set; } = "";
        public string RepostFile { get; set; } = "";
        public int RepostIntervalInMinutes { get; set; } = 10;

        public TelegramConfig()
        {
            IsEnabled = Convert.ToBoolean(GetValue(nameof(IsEnabled)));
            TargetChanel = GetValue(nameof(TargetChanel));
            ApiKey = Encoding.UTF8.GetString(Convert.FromBase64String(GetValue(nameof(ApiKey))));
            Message = GetValue(nameof(Message));
            Attachment = GetValue(nameof(Attachment));
            RepostingIsEnabled = Convert.ToBoolean(GetValue(nameof(RepostingIsEnabled)));
            OnlyOnFileUpdate = Convert.ToBoolean(GetValue(nameof(OnlyOnFileUpdate)));
            RepostMessage = GetValue(nameof(RepostMessage));
            RepostIntervalInMinutes = Convert.ToInt32(GetValue(nameof(RepostIntervalInMinutes)));
        }

        private string GetValue(string propertyName)
        {
            return base.GetXmlValue("Telegram", propertyName);
        }
    }
}
