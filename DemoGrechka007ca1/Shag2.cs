using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGrechka007ca1
{
    public partial class Shag2 : Form
    {
        public Shag2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag1 pr = new Shag1();
            pr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag3 pr = new Shag3();
            pr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag3 pr = new Shag3();
            pr.Show();
        }
    }
}
