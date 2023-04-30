using Drug_database;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugDatabaseMetro
{
    public partial class DrugDatabaseForm : MetroSetForm
    {
        public DrugDatabaseForm()
        {
            InitializeComponent();
        }

        private Drug searchedDrug;

        public static DrugDatabaseForm instance;

        public Database database = new Database();

        private void DrugDatabase_Load(object sender, EventArgs e)
        {
            instance = this;
            AutoCompleteInit();

          /*  string FileName = "C:\\Users\\Martin\\source\\repos\\TaVodic\\BPC-OOP-Project\\CSV\\default.csv";
            try
            {
                database.ImportFromCSV(FileName);
            }
            catch (FileNotFoundException ex)
            {
                Error.Text = "Initial import failed! Please import database manualy.";
                Error.ForeColor = Color.Red;
                return;
            }*/
            /*catch (Exception ex)
            {
                Error.Text = "Initial import failed! " + ex.Message;
                Error.ForeColor = Color.Red;
                return;
            }*/
            Error.Text = "Initial import has been successful";
            Error.ForeColor = Color.Green;

            ListDrugs();            
        }

        private void SearchBtn_Click(object sender, EventArgs e) // display search results
        {
            Drug drug;
            try
            {
                 drug = database.GetDrugByName(DrgSearch.Text);
            }
            catch
            {
                MessageBox.Show("Cannot find selectes drug!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DrgSearch.Text = string.Empty;
                return;
            }

            searchedDrug = drug;
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

        // Add, edit and remove functions

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EditingForm form2 = new EditingForm(EditingForm.Mode.Add);
            form2.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = DrugList.Items.IndexOf(DrugList.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Select item for editing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            EditingForm form2 = new EditingForm(EditingForm.Mode.Edit, database.GetDrugByIndex(index).Name);
            form2.ShowDialog();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = DrugList.Items.IndexOf(DrugList.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Select item to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            database.DeleteDrug(database.GetDrugByIndex(index));
            AutoCompleteInit();
            ListDrugs();
        }

        private void EditBtnSerach_Click(object sender, EventArgs e)
        {
            if (searchedDrug != null)
            {
                EditingForm form2 = new EditingForm(EditingForm.Mode.Edit, searchedDrug.Name);
                form2.ShowDialog();
            }
            else            
                MessageBox.Show("Search item to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void DeleteBtnSerach_Click(object sender, EventArgs e)
        {
            if (searchedDrug != null)
            {
                database.DeleteDrug(searchedDrug);
                AutoCompleteInit();
                Error.Text = "Drug successfully deleted!";
                Error.ForeColor = Color.Orange;
                DrgSearch.Text = string.Empty;
                DrgName.Text = string.Empty;
                DrgDescription.Text = string.Empty;
                DrgProducer.Text = string.Empty;
                DrgPrice.Text = string.Empty;
                DrgInStock.Text = string.Empty;
            }
            else       
                MessageBox.Show("Search item to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            if (searchedDrug != null)
            {
                try
                {
                    if (Convert.ToInt16(sellBox.Text) < 0)
                        throw new FormatException();
                    database.SellDrug(searchedDrug, Convert.ToInt16(sellBox.Text));
                }
                catch
                {
                    MessageBox.Show("Input in incorect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SearchBtn_Click(sender, e);
            }
            else            
                MessageBox.Show("First search the item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        // CSV import and export
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
                try
                {
                    database.ImportFromCSV(fileDialog.FileName);
                }
                catch (Exception es)
                {
                    Error.Text = "Import failed!" + es.Message;
                    Error.ForeColor = Color.Red;
                    return;
                }
                Error.Text = "Import has been successful";
                Error.ForeColor = Color.Green;
            }
            AutoCompleteInit();
            ListDrugs();
        }

        // own functions

        private void AutoCompleteInit()
        {
            var MyCollection = new AutoCompleteStringCollection();
            foreach (string name in database.GetDrugNames())
            {
                MyCollection.Add(name); // add drugs to autocomplete
            }
            DrgSearch.AutoCompleteCustomSource = MyCollection;
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

        // other GUI functions
        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Error.Text = string.Empty;
            AutoCompleteInit();
            ListDrugs();
        }

        private void DrugDatabaseForm_Activated(object sender, EventArgs e)
        {
            AutoCompleteInit();
            ListDrugs();
            if (searchedDrug != null)
            {
                SearchBtn_Click(sender, e);
            }
        }
        private void DrugList_DoubleClick(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }
    }
}
