using System;
using System.Windows.Forms;


namespace ObsSocialMediaNotifier.Controls
{
    public partial class TelegramControl : UserControl
    {
        

        public TelegramControl()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
                       

            if (!DesignMode)
            {
                //checkBoxEnableBot.Checked = base.TelegramConfigData.IsEnabled;
                //textBoxTargetChanel.Text = base.TelegramConfigData.TargetChanel;
                //textBoxBotApiKey.Text = base.TelegramConfigData.ApiKey;
                //textBoxMessage.Text = base.TelegramConfigData.Message;
                //textBoxAttachment.Text = base.TelegramConfigData.Attachment;
                //checkBoxEnableRepost.Checked = base.TelegramConfigData.RepostingIsEnabled;
                //checkBoxOnlyOnFileUpdate.Checked = base.TelegramConfigData.OnlyOnFileUpdate;
                //textBoxRepostFile.Text = base.TelegramConfigData.RepostFile;
                //textBoxRepostMassage.Text = base.TelegramConfigData.RepostMessage;
                //numericUpDownRepostInterval.Value = base.TelegramConfigData.RepostIntervalInMinutes;
            }
        }

        private void buttonShowApiKey_Click(object sender, EventArgs e)
        {
            //TelegramConfig.IsEnabled = checkBoxEnableBot.Checked;
            //TelegramConfig.TargetChanel = textBoxTargetChanel.Text;
            //TelegramConfig.ApiKey = textBoxBotApiKey.Text;
            //TelegramConfig.Message = textBoxMessage.Text;
            //TelegramConfig.Attachment = textBoxAttachment.Text;
            //TelegramConfig.RepostingIsEnabled = checkBoxEnableRepost.Checked;
            //TelegramConfig.OnlyOnFileUpdate = checkBoxOnlyOnFileUpdate.Checked;
            //TelegramConfig.RepostFile = textBoxRepostFile.Text;
            //TelegramConfig.RepostMessage = textBoxRepostMassage.Text;
            //TelegramConfig.RepostIntervalInMinutes = (int)numericUpDownRepostInterval.Value;

            //buttonShowApiKey.Text = buttonShowApiKey.Text == "Show" ? "Hide" : "Show";
            //textBoxBotApiKey.PasswordChar = buttonShowApiKey.Text == "Show" ? '\0' : '*';
        }

        private void buttonSelectRepostMassage_Click(object sender, EventArgs e)
        {
            SetSelectedFilePath("Text file...", textBoxRepostMassage, _filterTextFile);
        }

        private readonly string _filterImageVideo = "Image and video Files|*.jpg;*.jpeg;*.png;*.mp4";
        private readonly string _filterTextFile = "Text file|*.txt";
        private void buttonSelectAttachment_Click(object sender, EventArgs e)
        {
            SetSelectedFilePath("Image und video files...", textBoxAttachment, _filterImageVideo);
        }

        private void buttonRepostFile_Click(object sender, EventArgs e)
        {
            SetSelectedFilePath("Image und video files...", textBoxRepostFile, _filterImageVideo);
        }



        private void SetSelectedFilePath(string title, TextBox txtBox, string filter)
        {
            openFileDialog.Filter = filter;
            openFileDialog.Title = title;
            txtBox.Text = openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : "";

            openFileDialog.FileName = "";
            openFileDialog.Title = "";
        }
    }
}
