using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class SettingForm : Form
    {
        
        public SettingForm()
        {
            InitializeComponent();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            int Vol = tbVolume.Value;
            VolumeLevel.Text = Vol.ToString() + "%";

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            GameSettings.Volume = tbVolume.Value;
            Close();
        }
    }
}
