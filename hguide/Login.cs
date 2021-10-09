using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace hguide
{
    public partial class Login : Form
    {
        public Login()
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
            Anime anime = new Anime();
            anime.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manga manga = new Manga();
            manga.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
