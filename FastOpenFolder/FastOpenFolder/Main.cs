using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace FastOpenFolder
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.TransparencyKey = Color.DarkGray;

            var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
            Top = _point.Y-182;
            Left = _point.X-182;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\YEDEK\Çalışmalarım");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\YEDEK\Çalışmalarım\www");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\YEDEK\Çalışmalarım\Ranorknet");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\YEDEK\Çalışmalarım\WEB");
            Application.Exit();
        }
    }
}