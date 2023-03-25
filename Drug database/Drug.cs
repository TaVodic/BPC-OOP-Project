using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drug_database
{
    internal class Drug
    {
        public int ID = 0;
        public string Name = null;
        public string Description = null;
        public string Producer = null;
        private int InStock = 0;
        private double Price = 0;
        private string PhotoPath = null;

        public Drug(int ID, string name, string desctription, string producer, int inStock, double price, string photoPath)
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
