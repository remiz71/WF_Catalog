using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Catalog
{
    public class Goods
    {
        public string Name;
        public string Manufacturer;
        public double Price;

        public double _price
        {
            get
            {
                return Price;
            }
            set
            {
                if (Price < 0) throw new Exception("Цена товара должна быть больше нуля");
                else Price = value;
            }
        }
        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _manufacturer
        {
            get { return Manufacturer; }
            set { Manufacturer = value; }
        }

        public Goods()
        {
            _name = "Unknow";
            _manufacturer = "Unknow";
            _price = 0;
        }
        public Goods(string name, string manufacturer, double price)
        {
            _name = name;
            _manufacturer = manufacturer;
            _price = price;
        }
        public override string ToString()
        {
            return _name + "Изготовитель: " + _manufacturer + "Цена: " + _price;
        }

    }
}
