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
    public partial class registration : Form
    {

        public registration()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms["Form1"];
            ifrm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //массив с символами
            var x = new HashSet<char>() {'!','@','#','$','%','^'};
            try
            {
                //проверки
                Boolean a = false;
                Boolean b = false;
                Boolean c = false;
                if (textBox2.Text.Length >= 6)
                {
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    { 
                        char y = textBox2.Text[i];
                        char n = textBox2.Text[i];
                        if (char.IsDigit(n))
                        {
                            a = true;
                        }
                        if (char.IsLower(n))
                        {
                            b = true;
                        }
                        if (x.Contains(y))
                        {
                            c = true;
                        }
                    }
                }
                if ((a == true) && (b == true) && (c == true) && (textBox1.Text != ""))
                {
                    using (SqlConnection connection = new SqlConnection())
                    {
                        connection.ConnectionString = @"Data Source=INSTANCE-1;Initial Catalog=IlyaPapka;Integrated Security=True";
                        SqlCommand con = new SqlCommand("insert into Пользователь(Логин,Пароль,Роль) values (@login,@password,'Заказчик')", connection);
                        con.Parameters.AddWithValue("@login", textBox1.Text);
                        con.Parameters.AddWithValue("@password", textBox2.Text);
                        con.ExecuteNonQuery();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароль не подходит или такой пользователь уже существует");
                }
            }
            catch 
            {
                MessageBox.Show("Такой пользователь уже существует.");
            }
        }

    }
}
