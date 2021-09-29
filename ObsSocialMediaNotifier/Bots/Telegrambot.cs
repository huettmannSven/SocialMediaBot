using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsSocialMediaNotifier.Bots
{
    class Telegrambot
    {
        public string PathRepostMessage { get; set; }
        public string PathRepostFile { get; set; }
        public string StartMessage { get; set; }
        public string StartPostFile { get; set; }
        public DateTime LastPost { get; set; }
        public int RepostIntervalInMinutes { get; set; }
        public string TelegramChannel { get; set; }
        public string BotApiKey { get; set; }


        private async void SendingLoop()
        {
            
            while (true)
            {

            }
        }

        public async Task SendMessage()
        {

        }
    }
}
