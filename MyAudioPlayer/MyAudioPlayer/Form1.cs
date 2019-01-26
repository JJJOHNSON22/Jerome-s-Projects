using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAudioPlayer
{
    public partial class JeromeJohnsonAudioPlayer : Form
    {
        public JeromeJohnsonAudioPlayer()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            AudioPlayer.URL = textBox1.Text;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            AudioPlayer.Ctlcontrols.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            AudioPlayer.Ctlcontrols.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            AudioPlayer.Ctlcontrols.stop();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
