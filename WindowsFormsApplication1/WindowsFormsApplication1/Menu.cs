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
    public partial class Menu : Form
    {
        public Menu(string who)
        {
            InitializeComponent();
            userrr = who;
        }
        //значение роли, переданной с формы 3
        string userrr;
        int user;

        private void Form2_Load(object sender, EventArgs e)
        {
            string CaseSwitch = userrr;
            switch (CaseSwitch)
            {
                case "Менеджер":
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    menuStrip1.Items[3].Visible = true;
                    menuStrip1.Items[4].Visible = true;
                    menuStrip1.Items[0].Visible = true;
                    user = 1;
                    break;
                case "Директор":
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    menuStrip1.Items[4].Visible = true;
                    menuStrip1.Items[3].Visible = false;
                    menuStrip1.Items[0].Visible = true;
                    user = 1;
                    break;
                case "Кладовщик":
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = false;
                    menuStrip1.Items[3].Visible = false;
                    menuStrip1.Items[4].Visible = true;
                    menuStrip1.Items[0].Visible = true;
                    user = 1;
                    break;
                case "Заказчик":
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    menuStrip1.Items[3].Visible = true;
                    menuStrip1.Items[4].Visible = true;
                    menuStrip1.Items[0].Visible = true;
                    user = 0;
                    break;
            }
        }

        private void тканиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tkan = new tkan(user);
            tkan.MdiParent = this;
            tkan.Show();
        }

        private void тканиИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tkanizd = new TkanIzdelia(user);
            tkanizd.MdiParent = this;
            tkanizd.Show();
        }

        private void складТканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tkansklad = new SkladTkani(user);
            tkansklad.MdiParent = this;
            tkansklad.Show();
        }

        private void фурнитураИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tfurn = new Furnitura(user);
            tfurn.MdiParent = this;
            tfurn.Show();
        }

        private void фурнитураИзделияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tfurnizd = new FurnituraIzdelia(user);
            tfurnizd.MdiParent = this;
            tfurnizd.Show();
        }

        private void складФурнитурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tfurnsklad = new SkladFurnitur(user);
            tfurnsklad.MdiParent = this;
            tfurnsklad.Show();
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form izd = new Izdelie(user);
            izd.MdiParent = this;
            izd.Show();
        }

        private void заказныеИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form zakazizd = new ZakaznieIzdelia(user);
            zakazizd.MdiParent = this;
            zakazizd.Show();
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form zakaz = new Zakaz(user);
            zakaz.MdiParent = this;
            zakaz.Show();
        }

        private void конструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form konstr = new konstruktor();
            konstr.MdiParent = this;
            konstr.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms["Form1"];
            ifrm.Show();
        }
    }
}
