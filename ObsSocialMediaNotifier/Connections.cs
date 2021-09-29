using System.IO;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace ObsSocialMediaNotifier
{
    class Connections
    {
        private async Task TelegramBot()
        {
            string chatName = "@wohnzimmer_zocker";
            string chatMessage = "https://www.twitch.tv/wohnzimmer_zocker/";
            var bot = new TelegramBotClient("2048455143:AAFU2WwD-McrCZYJ_NXd2TwHhjAc2kBo150");

            using (FileStream stream = File.OpenRead($@"C:\Users\Wohnzimmer_Zocker\Videos\video.mp4"))
            {
                InputOnlineFile inputOnlineFile = new InputOnlineFile(stream, "Hier ist ein Bspiel");
                var x = await bot.SendVideoAsync(chatName, inputOnlineFile);
            }

            var s = await bot.SendTextMessageAsync(chatName, chatMessage);
        }
    }
}
