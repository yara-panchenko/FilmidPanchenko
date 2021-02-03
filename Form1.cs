using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilmidPanchenko
{
    public partial class Form1 : Form
    {
        DataGridView dataGridView1 = new DataGridView();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
        private SqlCommand command;
        private SqlDataAdapter adapter;
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Filmid.mdf; Integrated Security = True");
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
            dataGridView1.Height = 220;
            dataGridView1.Width = 770;
            pictureBox1.Size = (100, 100);
            pictureBox2.Size = (100, 100);
            pictureBox3.Size = (100, 100);
            pictureBox4.Size = (100, 100);
            pictureBox5.Size = (100, 100);

            pictureBox1.ImageLocation = "avengers.jpeg";
            pictureBox2.ImageLocation = "deadpool.jpg";
            pictureBox3.ImageLocation = "superman.jpg";
            pictureBox4.ImageLocation = "thor.jpg";
            pictureBox5.ImageLocation = "terminator.jpg";

            pictureBox1.Location = (0, 0);
            pictureBox2.Location = (101, 0);
            pictureBox3.Location = (202, 0);
            pictureBox4.Location = (303, 0);
            pictureBox5.Location = (404, 0);

        }

        private void DisplayData()
        {
            //connect.Open();
            //DataTable table = new DataTable();
            //adapter = new SqlDataAdapter("SELECT * FROM Films", connect);
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;
            //connect.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

    }
}
