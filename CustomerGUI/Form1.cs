using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customers;

namespace CustomerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void постояльцыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постояльцыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гостиница_DBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиница_DBDataSet.постояльцы". При необходимости она может быть перемещена или удалена.
            this.постояльцыTableAdapter.Fill(this.гостиница_DBDataSet.постояльцы);
            label4.Text = (постояльцыBindingSource.IndexOf(постояльцыBindingSource.Current) + 1).ToString() + " из " + (постояльцыBindingSource.Count);
            this.постояльцыDataGridView.Columns[0].Visible = false;
            this.textBox1.DataBindings.Add("Text", постояльцыBindingSource, "фио_постояльца", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBox2.DataBindings.Add("Text", постояльцыBindingSource, "паспортные_данные", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBox3.DataBindings.Add("Text", постояльцыBindingSource, "данные_реквизитов", true, DataSourceUpdateMode.OnPropertyChanged);
            this.постояльцыDataGridView.AllowUserToAddRows = false;
            постояльцыDataGridView.AutoResizeColumn(1);
            постояльцыDataGridView.AutoResizeColumn(2);
            постояльцыDataGridView.AutoResizeColumn(3);
        }

        private void постояльцыDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int a = постояльцыBindingSource.IndexOf(постояльцыBindingSource.Current);
                int b = постояльцыBindingSource.Count;
                label4.Text = (a + 1).ToString() + " из " + (b);
            }
            catch (Exception) { }
        }

        private void prev_first_btn_Click(object sender, EventArgs e)
        {
            постояльцыBindingSource.MoveFirst();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            постояльцыBindingSource.MovePrevious();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            постояльцыBindingSource.MoveNext();
        }

        private void next_last_btn_Click(object sender, EventArgs e)
        {
            постояльцыBindingSource.MoveLast();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cust = new Customer();
                int temp = cust._insert(textBox1.Text, textBox2.Text, textBox3.Text);
                label5.Text = "Добавлен новый гость";
                постояльцыTableAdapter.Fill(гостиница_DBDataSet.постояльцы);
            }
            catch (Exception)
            {
                label5.Text = "Введены недопустимые данные";
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView r = (DataRowView)постояльцыBindingSource.Current;
                int id_r = (int)r["код_постояльца"];
                Customer cust = new Customer();
                bool temp = cust._update(id_r, textBox1.Text, textBox2.Text, textBox3.Text);
                label5.Text = "Данные гостя успешно изменены";
                постояльцыTableAdapter.Fill(гостиница_DBDataSet.постояльцы);
            }
            catch (Exception)
            {
                label5.Text = "Введены недопустимые данные";
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                DataRowView drv;
                int i = постояльцыBindingSource.Count;
                if (i > 0)
                {
                    drv = (DataRowView)постояльцыBindingSource.Current;
                    id = (int)drv["код_постояльца"];
                    Customer cust = new Customer();
                    bool temp = cust._delete(id);
                    label5.Text = "Гость успешно удален";
                    постояльцыTableAdapter.Fill(гостиница_DBDataSet.постояльцы);
                }
            }
            catch (Exception)
            {
                label5.Text = "Невозможно удалить элемент.";
            }
        }
    }
}
