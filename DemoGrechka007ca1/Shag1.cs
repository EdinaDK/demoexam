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
    public partial class Shag1 : Form
    {
        DataBase db = new DataBase();

        public Shag1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numHuman.Text != "")
            {
                this.Hide();
                Shag2 pr = new Shag2();
                pr.Show();
                DataBank.numHuman = Convert.ToInt32(numHuman.Text);
                DataBank.numDays = Convert.ToInt32(numDays.Text);
                DataBank.date1 = dateTimePicker1.Value;
                DataBank.date2 = dateTimePicker2.Value;
            } else
            {
                var Mess = MessageBox.Show("Введите количество людей");
                if (Mess == DialogResult.OK)
                {
                    numHuman.Text = "1";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numHuman.Text != "")
            {
                this.Hide();
                Shag2 pr = new Shag2();
                pr.Show();
                DataBank.numHuman = Convert.ToInt32(numHuman.Text);
                DataBank.numDays = Convert.ToInt32(numDays.Text);
                DataBank.date1 = dateTimePicker1.Value;
                DataBank.date2 = dateTimePicker2.Value;
            }
            else
            {
                var Mess = MessageBox.Show("Введите количество людей");
                if (Mess == DialogResult.OK)
                {
                    numHuman.Text = "1";
                }
            }
        }

        private void Shag1_Load(object sender, EventArgs e)
        {

        }

        private void numDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if((!Char.IsDigit(num)) && (num!= 8))
            {
                e.Handled = true;
                
            }

            if (numDays.Text != null)
            {
                if (numDays.Text == "0")
                {
                    var Mess = MessageBox.Show("Введите положительное число");
                    if (Mess == DialogResult.OK)
                    {
                        numDays.Text = "1";
                    }
                }
            }

        }

        private void numHuman_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if ((!Char.IsDigit(num)) && (num != 8))
            {
                e.Handled = true;

            }

            if (numHuman.Text != null)
            {
                if (numHuman.Text == "0")
                {
                    var Mess = MessageBox.Show("Введите положительное число");
                    if (Mess == DialogResult.OK)
                    {
                        numHuman.Text = "1";
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;
            if (date2 < date1)
            {
                var Mess = MessageBox.Show("Выберите корректную дату");
                if (Mess == DialogResult.OK)
                {
                    dateTimePicker2.Value = dateTimePicker1.Value;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;
            if (date2 < date1)
            {
                var Mess = MessageBox.Show("Выберите корректную дату");
                if (Mess == DialogResult.OK)
                {
                    dateTimePicker2.Value = dateTimePicker1.Value;
                }
            }
        }
    }
}
