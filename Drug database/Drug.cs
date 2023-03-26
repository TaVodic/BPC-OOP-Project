using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drug_database
{
    internal class Drug
    {
        public uint ID { get; }
        public string Name { get; }
        public string Description { get; }
        public string Producer { get; }
        public int InStock  { get; }
        public double Price  { get; }
        public string PhotoPath { get; }

public Drug(uint ID, string name, string desctription, string producer, int inStock, double price, string photoPath)
        {
            this.ID = ID;
            this.Name = name;
            this.Description = desctription;
            this.Producer = producer;
            this.InStock = inStock;
            this.Price = price;
            this.PhotoPath = photoPath;
        }
        public Drug(uint ID, string name, string desctription)
        {
            this.ID = ID;
            this.Name = name;
            this.Description = desctription;
        }
        public void sell(int amout)
        {

        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0},{1},\"{2}\",{3},{4},{5},{6}", this.ID ,this.Name, this.Description, this.Producer, this.InStock, this.Price.ToString("0,0.00", new CultureInfo("en-US", false)), this.PhotoPath);
            return str.ToString();
        }
    }
}


