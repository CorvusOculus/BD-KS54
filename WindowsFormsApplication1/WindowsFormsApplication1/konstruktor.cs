using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class konstruktor : Form
    {
        public konstruktor()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Фурнитура' table. You can move, or remove it, as needed.
            this.фурнитураTableAdapter.Fill(this.ilyaPapkaDataSet.Фурнитура);
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Ткань' table. You can move, or remove it, as needed.
            this.тканьTableAdapter.Fill(this.ilyaPapkaDataSet.Ткань);
            //string[] files = Directory.GetFiles("C:/Users/student/Desktop/Окантовка");
            //comboBox2.DataSource = files;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && (s != 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                if (Convert.ToInt32(textBox1.Text) < 10)
                {
                    textBox1.Text = "10";
                }
            }
            else
            {
                textBox1.Text = "10";
            }

            if (textBox2.Text != "")
            {
                if (Convert.ToInt32(textBox2.Text) < 10)
                {
                    textBox2.Text = "10";
                }
            }
            else
            {
                textBox2.Text = "10";
            }

            Form govno = new VneshniyVid(textBox1.Text, textBox2.Text);
            govno.MdiParent = this.MdiParent;
            govno.Show();
        }
    }
}
