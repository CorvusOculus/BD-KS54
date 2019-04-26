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
    public partial class FurnituraIzdelia : Form
    {
        public FurnituraIzdelia(int userrr)
        {
            InitializeComponent();
            user = userrr;
        }

        //для ограничения по пользователям
        int user;

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Фурнитура_изделия' table. You can move, or remove it, as needed.
            this.фурнитура_изделияTableAdapter.Fill(this.ilyaPapkaDataSet.Фурнитура_изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Фурнитура_изделия". При необходимости она может быть перемещена или удалена.
            //this.фурнитура_изделияTableAdapter.Fill(this.dataSet1.Фурнитура_изделия);
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
            this.фурнитураИзделияBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(this.dataSet1);
        }
    }
}
