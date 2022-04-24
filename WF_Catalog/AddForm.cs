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
    public partial class AddForm : Form
    {
        Goods _goods=null;
        bool _addNew;
        public AddForm(Goods good , bool addnew)
        {
            InitializeComponent();
            _goods = good;
            _addNew = addnew;
            if (addnew == false)
            {
                tb_name.Text = good._name;
                tb_country.Text = good._manufacturer;
                tb_cost.Text = good._price.ToString();
                Text = "Редактирование товара";
            }
            else Text = "Добавление товара";
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_country.Text == "" || tb_cost.Text == "")
            {
                MessageBox.Show("Не все обязательные поля заполнены");
            }
            else
            {
                if (_goods == null)
                    _goods = new Goods();
                _goods._name = tb_name.Text;
                _goods._manufacturer = tb_country.Text;
                try
                {
                    _goods._price = Convert.ToDouble(tb_cost.Text);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы неправильно ввели сумму, сумма содержит только цифры", "Ошибка задания суммы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
