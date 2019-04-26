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
    public partial class Zakaz : Form
    {
        public Zakaz(int userrr)
        {
            InitializeComponent();
            user = userrr;
        }

        //для ограничения по пользователям
        int user;

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.ilyaPapkaDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.ilyaPapkaDataSet.Заказ);
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

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.ilyaPapkaDataSet);
        }
    }
}
