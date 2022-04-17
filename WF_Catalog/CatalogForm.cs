using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
