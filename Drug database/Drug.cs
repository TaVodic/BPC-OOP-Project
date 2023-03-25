using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drug_database
{
    internal class Drug
    {
        public uint ID = 0;
        public string Name = string.Empty;
        public string Description = string.Empty;
        public string Producer = string.Empty;
        private int InStock = 0;
        private double Price = 0;
        private string PhotoPath = string.Empty;

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
    }
}
