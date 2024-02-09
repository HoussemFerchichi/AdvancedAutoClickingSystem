using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devil_s_Clicker
{
    public partial class process_message : Form
    {
        public static bool close = false;
        public process_message()
        {
            InitializeComponent();
            label3.Text = Form1.trackbarvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            Clicker3 clicker = new Clicker3();
            clicker.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
