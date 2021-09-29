using System;
using System.IO;
using System.Windows.Forms;


namespace ObsSocialMediaNotifier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Configurations.Config.Set();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }
    }
}
