using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_14
{
    public partial class Home_page : Form
    {
        //Данная страница является главной. Тут вам доступны основные вкладки сайта;
        public Home_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                pictureBox1.ImageLocation = @"https://vataga.com.ua/wa-data/public/photos/63/00/63/63.970.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                label1.Text = ("Изображение не найдено");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_user new_user = new New_user();
            new_user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_database edit_database = new Edit_database();
            edit_database.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }
    }
}
