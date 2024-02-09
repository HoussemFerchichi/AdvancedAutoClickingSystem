using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AutoItX3Lib;
using System.Media;
using System.Runtime.InteropServices;

namespace Devil_s_Clicker
{
    public partial class Clicker3 : Form
    {
        AutoItX3 aut = new AutoItX3();
        public string strfilename; public string casted; public string choosenclicks = Form1.trackbarvalue;
        public string filepath; public int cal; public int cal2 = 12484538;
        public int x; public int y;
        public int nclick;
        public int speed;
        public string timez ;
        public string Mclick = "LEFT";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public Clicker3()
        {
            InitializeComponent();
        }

        private void Clicker3_Load(object sender, EventArgs e)
        {
            label3.Text = choosenclicks;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 3)
            {
                string text1 = textBox1.Text;
                try
                {
                    x = Int32.Parse(text1);
                    
                }
                catch
                {
                    error Error = new error();
                    SystemSounds.Beep.Play();
                    Error.Show();
                }
            }
            else
            {
                error error = new error();
                SystemSounds.Beep.Play();
                error.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 3)
            {
                string text2 = textBox2.Text;
                try
                {
                    y = Int32.Parse(text2);
                }
                catch
                {
                    error Error = new error();
                    SystemSounds.Beep.Play();
                    Error.Show();
                }
            }
            else
            {
                error error = new error();
                SystemSounds.Beep.Play();
                error.Show();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
            label15.Visible = true;
            timer1.Start();
            
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                try
                {
                    nclick = Int32.Parse(textBox4.Text);
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }

            }
            

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                try
                {
                    speed = Int32.Parse(textBox3.Text);
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
            }
            

        }











        //loading and saving
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            filepath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            string text = System.IO.File.ReadAllText(filepath);
            string a = text.Substring(10);
            string b= a.Remove(6);
            string c = b.Substring(2);
            textBox2.Text = c;
            textBox1.Text = c.Remove(2);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            strfilename = saveFileDialog1.InitialDirectory + saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(strfilename);
            casted = textBox1.Text + textBox2.Text;
            sw.Write("1132121324" + casted+"12484538");
            sw.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            close_message close = new close_message();
            SystemSounds.Beep.Play();
            close.Show();
        }

        private void mousePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mousepos pos = new mousepos();
            pos.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Visible = true;
            label15.Visible = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = (int.Parse(label9.Text) - 1).ToString();
            if (int.Parse(label9.Text) == -2)
            {
                timer1.Stop();
                label9.Text = "0";
            }
            if (int.Parse(label9.Text) == -3)
            {
                timer1.Stop();
                label9.Text = "0";
            }
            if (label9.Text == timez)
            {
                aut.MouseClick(Mclick, x, y, nclick, speed);
                label12.Text = (int.Parse(label12.Text) + 1).ToString();
            }
            if (checkBox1.Checked)
            {
                if (label9.Text == "-1")
                {
                    label9.Text = textBox5.Text;
                    timer1.Start();
                }
            }
            else
            {
                if (int.Parse(label9.Text) == -1)
                {
                    timer1.Stop();
                    label9.Text = "0";
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = textBox5.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timez = textBox6.Text;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mclick = "LEFT";
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mclick = "RIGHT";
        }


        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
