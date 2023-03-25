using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drug_database
{
    public partial class DatabaseGUI : Form
    {
        public DatabaseGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrgName.Text = string.Empty;
            var drugs = new List<Drug>();

            drugs.Add(new Drug(0, "Paralen Rapid 500mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních. Také pomáhají při bolesti hlavy, zubů, zad, bolestivé menstruaci, při bolesti svalů a kloubů provázející chřipku a nachlazení. Paralen Rapid 500 mg mohou užívat dospělí a dospívající od 12 let.", "Zentiva", 5, 2.50, ""));
            drugs.Add(new Drug(1, "Paralen Rapid 100mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních. Také pomáhají při bolesti hlavy, zubů, zad, bolestivé menstruaci, při bolesti svalů a kloubů provázející chřipku a nachlazení. Paralen Rapid 500 mg mohou užívat dospělí a dospívající od 12 let.", "Zentiva", 5, 2.50, ""));
            drugs.Add(new Drug(2, "Paralen Rapid 300mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních. Také pomáhají při bolesti hlavy, zubů, zad, bolestivé menstruaci, při bolesti svalů a kloubů provázející chřipku a nachlazení. Paralen Rapid 500 mg mohou užívat dospělí a dospívající od 12 let.", "Zentiva", 5, 2.50, ""));

            
            var MyCollection = new AutoCompleteStringCollection();
            foreach(Drug obj in drugs)
            {
                MyCollection.Add(obj.Name);
            }            
            DrgSearch.AutoCompleteCustomSource = MyCollection;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void DrgSearch_TextChanged(object sender, EventArgs e)
        {
            if (DrgSearch.AutoCompleteCustomSource.Contains(DrgSearch.Text))
            {
                DrgName.Text = DrgSearch.Text;                
            }
            else
            {
                DrgName.Text = string.Empty;
            }
        }
    }
}
