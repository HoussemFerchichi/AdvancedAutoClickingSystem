using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devil_s_Clicker
{
    public partial class Form1 : Form
    {
        public static string trackbarvalue = "1";
        public Form1()
        {
            InitializeComponent();
        }


        public void trackBarSetting(object sender, MouseEventArgs e)
        {
            trackbarvalue = trackBar1.Value.ToString();
            label3.Text = trackbarvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process_message process = new process_message();
            SystemSounds.Beep.Play();
            process.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            close_message close = new close_message();
            SystemSounds.Beep.Play();
            close.Show();
        }
    }
}
