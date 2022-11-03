using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DemoGrechka007ca1
{

    public partial class Shag4 : Form
    {

        string strConn = @"Data Source=DBSRV\DEMO;Initial Catalog=ewqrew;Integrated Security=True";

        public Shag4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Shag4_Load(object sender, EventArgs e)
        { // загрузка формы в оперативную память
            PopulateGrid();
        }


        private void PopulateGrid()
        {  // наполнение сетки DataGridView данными
            int num = DataBank.numDays * DataBank.numHuman;
            int st = DataBank.star;
            string park;
            string trans;

            if (DataBank.parking == true)
            {
                park = "> 0 ";

            } else {
                park = ">= 0 ";
            }

            if (DataBank.transfer == true)
            {
                trans = "да";
            } else {
                trans = "нет";
            }

            int minprice = DataBank.min;
            int maxprice = DataBank.max;

            /*int num = 8;*/
            //int st = 4;
            //string park = "> 0 ";
            //string trans = "да";
            /*int minprice = 10000;
            int maxprice = 50000;*/

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                //string sql = "select * from Договор";
                //string sql = "select Sort.[Название отеля], Sort.[Страна], Sort.[Адрес], Договор.Стоимость*" + 8 + "as[A] from Договор, (select * from Отели where Парковка > 0 and Трансфер ='да' and [Количество звезд] > " + 3 +") as Sort where Sort.[ID отеля] = ДОговор.[ID отеля] and Договор.Стоимость * 8 < 50000 and Договор.Стоимость * 8 > 10000";
                //string sql = "select Sort.[Название отеля], Sort.[Страна], Sort.[Адрес], Договор.Стоимость*" + 8 + " as[Стоимость] from Договор, (select * from Отели where Парковка " + "> 0 " + " and Трансфер ='" + "да" + "' and [Количество звезд] >= " + 4 + ") as Sort where Sort.[ID отеля] = Договор.[ID отеля] and Договор.Стоимость *" + 8 + " <" + 50000 + " and Договор.Стоимость *" + 8 + " >" + 10000;
                string sql = "select Sort.[Название отеля], Sort.[Страна], Sort.[Адрес], Договор.Стоимость*" + num + " as[Стоимость] from Договор, (select * from Отели where Парковка " + park + " and Трансфер ='" + trans + "' and [Количество звезд] >= " + st + ") as Sort where Sort.[ID отеля] = Договор.[ID отеля] and Договор.Стоимость *" + num + " <" + DataBank.max +" and Договор.Стоимость *" + num +  " >" + DataBank.min;
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }


        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shag3 pr = new Shag3();
            pr.Show();
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

    }
}
