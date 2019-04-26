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
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=INSTANCE-1;Initial Catalog=IlyaPapka;Integrated Security=True";
                connection.Open();
                SqlCommand con = new SqlCommand("Select * from Пользователь", connection);
                con.CommandText = "Select * from Пользователь where Логин = '" + textBox1.Text + "' and Пароль ='" + textBox2.Text + "'";
                SqlDataReader reader = con.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string a = reader["Роль"].ToString();
                        if (a == "Менеджер")
                        {
                            Form Menu = new Menu(a);
                            Menu.Show();
                            this.Hide();
                        }
                        if (a == "Заказчик")
                        {
                            Form Menu = new Menu(a);
                            Menu.Show();
                            this.Hide();
                        }
                        if (a == "Кладовщик")
                        {
                            Form Menu = new Menu(a);
                            Menu.Show();
                            this.Hide();
                        }
                        if (a == "Директор")
                        {
                            Form Menu = new Menu(a);
                            Menu.Show();
                            this.Hide();
                        }
                    }
                        textBox1.Text = "";
                        textBox2.Text = ""; 
                }
                 else
                 { 
                    MessageBox.Show("Неверный логин или пароль, попробуйте снова или зарегистрируйтесь.");
                    textBox2.Text = "";
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reg = new registration();
            reg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
