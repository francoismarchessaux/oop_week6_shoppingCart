using System;
using System.Collections.Generic;
using System.Text;

namespace OOP6_ShoppinCart
{
    public class Fruit
    {
        private string name;
        private decimal price;

        public Fruit(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{name} {price}";
        }
    }
}
