using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace hguide
{
    public partial class Anime : Form
    {
        public Anime()
        {
            InitializeComponent();
        }
        //drag
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;//end drag

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentaihaven.xxx/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentai.tv/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentaimama.io/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentaidude.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://hanime.tv/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://miohentai.com/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentaiprn.com/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentai2w.com/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://hentaiyes.com/");
        }
    }
}
