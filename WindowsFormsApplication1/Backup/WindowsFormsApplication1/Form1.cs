using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1(string Who)
        {
            InitializeComponent();
            Userrr = Who;
        }
        //значение роли, переданной с формы 3
        string Userrr;
        //текст ошибки при не правильно вводе логина или пароля
        string error;
        bool check;
        private void Form1_Load(object sender, EventArgs e)
        {
            check = false;
            if (Userrr == "Заказчик")
            {
                button2.Visible = true;
                error = "Неверный логин или пароль, попробуйте снова или зарегистрируйтесь.";
            }
            else
            {
                button2.Visible = false;
                error = "Неверный логин или пароль.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=КС54_К37_02-ПК;Initial Catalog=DemoEkz;Integrated Security=True";
                connection.Open();
                SqlCommand con = new SqlCommand("Select * from Пользователь", connection);
                con.CommandText = "Select * from Пользователь where Логин = '" + textBox1.Text + "' and Пароль ='" + textBox2.Text + "'";
                SqlDataReader reader = con.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string a = reader["Роль"].ToString();
                        if ((a == "Менеджер") && (Userrr == "Менеджер"))
                        {
                            Form Menu = new Form2(Userrr);
                            Menu.Show();
                            check = true;
                            this.Close();
                        }
                    }
                        textBox1.Text = "";
                        textBox2.Text = ""; 
                }
                 else
                 { 
                    MessageBox.Show(error);
                    textBox2.Text = "";
                 }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms["Form3"];
            ifrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form reg = new Form4();
            reg.Show();
            check = true;
            this.Close();
        }
    }
}
