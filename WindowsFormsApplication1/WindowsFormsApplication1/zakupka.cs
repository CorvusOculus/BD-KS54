using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class zakupka : Form
    {
        public zakupka()
        {
            InitializeComponent();
        }

        double col;
        double summ = 0;
        double pay;
        double summ1 = 0;

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Ткань' table. You can move, or remove it, as needed.
            this.тканьTableAdapter.Fill(this.ilyaPapkaDataSet.Ткань);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не введены данные в поле: " + label1.Text);
            }
            if (textBox2.Text == "0")
            {
                MessageBox.Show("Не введены данные в поле: " + label3.Text);
            }
            if (textBox3.Text == "0")
            {
                MessageBox.Show("Не введены данные в поле: " + label4.Text);
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Не введены данные в поле: " + label2.Text);
            }

            if ((textBox1.Text != "") && (textBox2.Text != "0") && (textBox3.Text != "0") && (comboBox1.Text != ""))
            {
                richTextBox1.AppendText(textBox1.Text + (char)13);
                richTextBox2.AppendText(comboBox1.Text + (char)13);
                richTextBox3.AppendText(textBox2.Text + (char)13);
                richTextBox4.AppendText(textBox3.Text + (char)13);
            }

            summ1 = summ + summ1;
            label8.Text = summ1.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.DataSource = тканьBindingSource;
                comboBox1.DisplayMember = "Наименование";
            }
            else
            {
                comboBox1.DataSource = фурнитураBindingSource;
                comboBox1.DisplayMember = "Наименование";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = e.KeyChar;
            if (!Char.IsDigit(s) && (s != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                col = Convert.ToDouble(textBox2.Text);
                pay = Convert.ToDouble(textBox3.Text);
                summ = col * pay;
                label6.Text = summ.ToString();
            }
        }
    }
}
