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
    public partial class Shag3 : Form
    {
       
        public Shag3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag4 pr = new Shag4();
            pr.Show();
            DataBank.min = Convert.ToInt32(textBox1.Text);
            DataBank.max = Convert.ToInt32(textBox2.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag4 pr = new Shag4();
            pr.Show();
            DataBank.min = Convert.ToInt32(textBox1.Text);
            DataBank.max = Convert.ToInt32(textBox2.Text);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag2 pr = new Shag2();
            pr.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag1 pr = new Shag1();
            pr.Show();
        }

        private void Shag3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox2.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox3.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox4.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox5.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            DataBank.star = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox2.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox3.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox4.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox5.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            DataBank.star = 4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox2.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox3.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox4.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox5.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            DataBank.star = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox2.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox3.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox4.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            pictureBox5.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\зв.png";
            DataBank.star = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox2.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox3.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox4.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            pictureBox5.ImageLocation = @"\\iscsi\profiles\Zadorozhnayavv\Desktop\звж.png";
            DataBank.star = 5;
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBank.typeFood = comboBox1.SelectedValue.ToString();
        }*/

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                DataBank.parking = true;
            } else
            {
                DataBank.parking = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                DataBank.transfer = true;
            }
            else
            {
                DataBank.transfer = false;
            }
        }

        /*private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            trackBar2.Minimum = trackBar1.Value;
            trackBar2.Maximum = trackBar1.Value + 50000;
            label10.Text = trackBar2.Minimum.ToString();
            label11.Text = trackBar2.Maximum.ToString();
            textBox2.Text = trackBar1.Value.ToString();
        }*/


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if ((!Char.IsDigit(num)) && (num != 8))
            {
                e.Handled = true;
                if (textBox1.Text != "")

                    if (Convert.ToInt32(textBox1.Text) > 50000)
                    {
                        textBox1.Text = "50000";
                        trackBar1.Value = 50000;
                        trackBar1.Value = Convert.ToInt32(textBox1.Text);
                        trackBar2.Minimum = trackBar1.Value;
                        trackBar2.Maximum = trackBar1.Value + 50000;
                        label10.Text = trackBar2.Minimum.ToString();
                        label11.Text = trackBar2.Maximum.ToString();
                        DataBank.min = Convert.ToInt32(textBox1.Text);
                    } else
                    {
                        trackBar1.Value = Convert.ToInt32(textBox1.Text);
                        trackBar2.Minimum = trackBar1.Value;
                        trackBar2.Maximum = trackBar1.Value + 50000;
                        label10.Text = trackBar2.Minimum.ToString();
                        label11.Text = trackBar2.Maximum.ToString();
                        DataBank.min = Convert.ToInt32(textBox1.Text);
                    }
                }
                
            }

        /*private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }*/

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if ((!Char.IsDigit(num)) && (num != 8))
            {
                e.Handled = true;
                if (textBox2.Text != "")

                    if (Convert.ToInt32(textBox2.Text) > 50000)
                    {
                        textBox2.Text = "50000";
                        trackBar2.Value = 50000;
                        trackBar2.Value = Convert.ToInt32(textBox2.Text);
                        DataBank.max = Convert.ToInt32(textBox2.Text);
                    }
                    else
                    {
                        trackBar2.Value = Convert.ToInt32(textBox2.Text);
                        DataBank.max = Convert.ToInt32(textBox2.Text);
                    }
            }
        }
    }
}
