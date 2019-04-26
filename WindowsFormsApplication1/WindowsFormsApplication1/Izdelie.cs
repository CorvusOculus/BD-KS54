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
    public partial class Izdelie : Form
    {
        public Izdelie(int userrr)
        {
            InitializeComponent();
            user = userrr;
        }

        //для ограничения по пользователям
        int user;

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilyaPapkaDataSet.Изделие' table. You can move, or remove it, as needed.
            this.изделиеTableAdapter.Fill(this.ilyaPapkaDataSet.Изделие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Изделие". При необходимости она может быть перемещена или удалена.
            //this.изделиеTableAdapter.Fill(this.dataSet1.Изделие);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = e.ColumnIndex.ToString();
            if (index == "5")
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                pictureBox1.Image = Image.FromFile(name);
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изделиеBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(this.dataSet1);
        }
    }
}
