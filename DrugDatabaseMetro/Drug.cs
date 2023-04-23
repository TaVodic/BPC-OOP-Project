using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drug_database
{
    public class Drug
    {
        public uint ID { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Producer { get; private set; }
        public int InStock  { get; private set; }
        public double Price  { get; private set; }
        public string PhotoPath { get; private set; }

        public Drug(string name, string desctription, string producer, int inStock, double price, string photoPath)
        {
            this.Name = name;
            this.Description = desctription;
            this.Producer = producer;
            this.InStock = inStock;
            this.Price = price;
            this.PhotoPath = photoPath;
        }

        public bool SellDrug(int amout)
        {
            if((InStock - amout) >= 0)
                InStock = InStock - amout;
            else return false;
            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0},{1},\"{2}\",{3},{4},{5},{6}", this.ID ,this.Name, this.Description, this.Producer, this.InStock, this.Price, this.PhotoPath);
            return str.ToString();
        }

        public void EditDrug(string name, string description, string producer, int inStock, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Producer = producer;
            this.InStock = inStock;
            this.Price = price;
        }
    }
}


