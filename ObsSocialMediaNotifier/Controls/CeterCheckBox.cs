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
    public partial class CeterCheckBox : UserControl
    {
        public bool Checked { get; set; }

        public CeterCheckBox()
        {
            InitializeComponent();
            Checked = checkBox.Checked;
            this.Dock = DockStyle.Fill;
        }
    }
}
