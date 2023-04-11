﻿using Drug_database;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugDatabaseMetro
{
    public partial class DrugDatabase : MetroSetForm
    {
        public DrugDatabase()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void DrugDatabase_Load(object sender, EventArgs e)
        {
            DrgName.Text = string.Empty;
            //database.AddNewDrug(new Drug("Paralen Rapid 100mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních. Také pomáhají při bolesti hlavy, zubů, zad, bolestivé menstruaci, při bolesti svalů a kloubů provázející chřipku a nachlazení. Paralen Rapid 500 mg mohou užívat dospělí a dospívající od 12 let.", "Zentiva", 5, 2.50, "xccv"));
            //database.AddNewDrug(new Drug("Paralen Rapid 500mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních.", "Zentiva", 5, 2.50, "image"));
            //database.AddNewDrug(new Drug("Paralen Rapid 300mg", "Šumivé tablety Paralen Rapid 500 mg snižují horečku při chřipce, nachlazení a jiných infekčních onemocněních.", "Zentiva", 0, 2.50, "image"));
            //AutoCompleteInit();
            ListDrugs();
        }

        private void AutoCompleteInit()
        {
            var MyCollection = new AutoCompleteStringCollection();
            foreach (string name in database.GetDrugNames())
            {
                MyCollection.Add(name); // add drugs to autocomplete
            }
            DrgSearch.AutoCompleteCustomSource = MyCollection;
        }

        private void SearchBtn_Click(object sender, EventArgs e) // display search results
        {
            Drug drug = database.GetDrugByName(DrgSearch.Text);
            if (drug != null)
            {
                DrgName.Text = drug.Name;
                DrgDescription.Text = drug.Description;
                DrgProducer.Text = drug.Producer;
                DrgPrice.Text = drug.Price.ToString("0.00") + " €";
                DrgInStock.Text = drug.InStock.ToString("0") + " pcs";
                if (drug.InStock == 0)
                    DrgInStock.ForeColor = Color.Red;
                else
                    DrgInStock.ForeColor = Color.Green;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "csv files (*.csv)|*.csv";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                database.ExportToCSV(fileDialog.FileName);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "csv files (*.csv)|*.csv";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!database.ImportFromCSV(fileDialog.FileName))
                {
                    Error.Text = "Not compatible or corrupted file! Import Failed.";
                    Error.ForeColor = Color.Red;
                }
                else
                {
                    Error.Text = "Import has been successful";
                    Error.ForeColor = Color.Green;
                }
            }
            AutoCompleteInit();
            ListDrugs();
        }

        private void ListDrugs()
        {
            if (Menu.SelectedIndex == 1)
            {
                DrugList.Items.Clear();
                var list = database.GetDrugList();
                int ID = 0;
                foreach (var drug in list)
                {                    
                    ListViewItem item = new ListViewItem(ID.ToString());
                    item.SubItems.Add(drug.Name);
                    item.SubItems.Add(drug.Producer);
                    item.SubItems.Add(drug.InStock.ToString());
                    item.SubItems.Add(drug.Price.ToString("0.00") + " €");
                    item.SubItems.Add(drug.Description);
                    DrugList.Items.Add(item);
                    ID++;
                }
            }
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Error.Text = string.Empty;
            ListDrugs();
        }
    }
}