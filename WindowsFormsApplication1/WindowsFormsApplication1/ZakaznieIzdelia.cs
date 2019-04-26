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
    public partial class ZakaznieIzdelia : Form
    {
        public ZakaznieIzdelia(int userrr)
        {
            InitializeComponent();
            user = userrr;
        }

        //для ограничения по пользователям
        int user;

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказанныеИзделияBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(this.dataSet1);
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Заказанные_изделия' table. You can move, or remove it, as needed.
            this.заказанные_изделияTableAdapter.Fill(this.ilyaPapkaDataSet.Заказанные_изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Заказанные_изделия". При необходимости она может быть перемещена или удалена.
            //this.заказанные_изделияTableAdapter.Fill(this.dataSet1.Заказанные_изделия);
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
    }
}
