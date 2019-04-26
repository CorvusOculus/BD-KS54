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
    public partial class Form2 : Form
    {
        public Form2(string who)
        {
            InitializeComponent();
            userrr = who;
        }
        //значение роли, переданной с формы 3
        string userrr;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form login = new Form1(userrr);
            login.Show();    
        }

        private void тканиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tkan = new Form5();
            tkan.MdiParent = this;
            tkan.Show();
        }
    }
}
