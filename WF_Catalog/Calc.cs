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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        double _a, _res;
        char _action;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            _action = '+';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            _action = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            _action = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            _action = '/';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string _temp = textBox1.Text;
                _temp = _temp.Remove(_temp.Length - 1);
                textBox1.Clear();
                textBox1.Text = _temp;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = (_a *_a).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            _action = '&';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = (_a * Convert.ToDouble(textBox1.Text) / 100).ToString();
        }

        private void Calculate()
        {

            switch (_action)
            {

                case '+':
                    _res = _a + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = _res.ToString();
                    break;
                case '-':
                    _res = _a - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = _res.ToString();
                    break;
                case '*':
                    _res = _a * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = _res.ToString();
                    break;
                case '/':
                    if (Convert.ToDouble(textBox1.Text) <= 0)
                    { textBox1.Text = "делить на ноль нельзя"; }
                    else
                    {
                        _res = _a / Convert.ToDouble(textBox1.Text);
                        textBox1.Text = _res.ToString();
                    }
                    break;
                case '^':
                    _res = _a * _a;
                    textBox1.Text = _res.ToString();
                    break;
                case '&':
                    _res = Math.Pow(_a, Convert.ToDouble(textBox1.Text));
                    textBox1.Text = _res.ToString();
                    break;
            }

        }
    }
}
