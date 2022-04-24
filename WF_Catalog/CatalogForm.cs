using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF_Catalog
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Error");
            else listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void bt_add_MouseClick(object sender, MouseEventArgs e)
        {   
                Goods _g = new Goods();
                AddForm form = new AddForm(_g, true);
                if (form.ShowDialog() == DialogResult.OK) listBox1.Items.Add(_g);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали элемент для редактирования", "Ошибка");
            else
            {
                int index = listBox1.SelectedIndex;
                Goods _editGood = (Goods)listBox1.SelectedItem;
                AddForm editForm = new AddForm(_editGood, false);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(index);
                    listBox1.Items.Insert(index, _editGood);
                }
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("GoodsList.dat");
            if (listBox1.Items.Count != 0)
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                MessageBox.Show("Запись в файл прошла успешно");
                sw.Close();
            }
            else MessageBox.Show("В списке нет товаров");
            sw.Close();
        
    }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
