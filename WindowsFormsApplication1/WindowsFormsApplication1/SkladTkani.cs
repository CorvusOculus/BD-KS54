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
    public partial class SkladTkani : Form
    {
        public SkladTkani(int userrr)
        {
            InitializeComponent();
            user = userrr;
        }

        //для ограничения по пользователям
        int user;

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Склад_ткани' table. You can move, or remove it, as needed.
            this.склад_тканиTableAdapter.Fill(this.ilyaPapkaDataSet.Склад_ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Склад_ткани". При необходимости она может быть перемещена или удалена.
            this.склад_тканиTableAdapter.Fill(this.ilyaPapkaDataSet.Склад_ткани);
            if (user == 0)
            {
                dataGridView1.ReadOnly = true;
                bindingNavigator1.Items[9].Visible = false;
                bindingNavigator1.Items[10].Visible = false;
                bindingNavigator1.Items[11].Visible = false;
            }
            else
            {
                dataGridView1.ReadOnly = false;
                bindingNavigator1.Items[9].Visible = true;
                bindingNavigator1.Items[10].Visible = true;
                bindingNavigator1.Items[11].Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складТканиBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.ilyaPapkaDataSet);
        }
    }
}
