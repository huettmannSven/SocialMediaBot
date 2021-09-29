using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsSocialMediaNotifier.Controls
{
    public partial class TabPageControl : UserControl
    {
        public Configurations.TelegramConfig TelegramConfigData { get; set; }

        public TabPageControl()
        {
            InitializeComponent();
            //LoadConfigs();
        }

        private void LoadConfigs()
        {
            TelegramConfigData = new Configurations.TelegramConfig();

        }

        private void SaveBotsConfig()
        {
            List<KeyValuePair<string, string>> listKvp = new();
            //listKvp.Add(telegramControl.)

        }
    }
}
