using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Runtime.InteropServices;

namespace Devil_s_Clicker
{
    public partial class mousepos : Form
    {
        AutoItX3 aut = new AutoItX3();
        public int x ; public int y;
        public string X; public string Y;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public mousepos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = aut.MouseGetPosX();
            y = aut.MouseGetPosY();
            X = x.ToString();
            Y = y.ToString();
            textBox3.Text = ("x pos = "+X+", y pos = "+Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(X);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Y);
        }

        private void mousepos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
