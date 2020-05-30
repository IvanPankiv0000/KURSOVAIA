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
    public partial class Edit_user_data : Form
    {
        //Данная страница является промежуточной вкладкой для открывания других страниц, вы можете перейти на вкладку "Переназначить номер" или "Изменить данные";
        public Edit_user_data()
        {
            InitializeComponent();
        }

        private void Edit_user_data_Load(object sender, EventArgs e)
        {
            MessageBox.Show("На данной странице вы можете переназначить свободный номер другому абоненту либо изменить раннее введенные данные.");
            this.CenterToScreen();
            try
            {
                pictureBox1.ImageLocation = @"https://www.3cx.ru/wp-content/uploads/sites/22/corporate-network.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                label1.Text = ("Изображение не найдено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_user_name edit_User_Name = new Edit_user_name();
            edit_User_Name.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign_number assign_Number = new Assign_number();
            assign_Number.Show();
        }
    }
}
