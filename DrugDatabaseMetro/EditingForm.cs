using Drug_database;
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
using DrugDatabaseMetro;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace DrugDatabaseMetro
{
    public partial class EditingForm : MetroSetForm
    {
        public enum Mode
        {
            Add,
            Edit
        }

        private Mode _mode;
        private string _editDrug;
        public EditingForm(Mode mode)
        {
            InitializeComponent();            
            _mode = mode;
        }

        public EditingForm(Mode mode, Drug drug)
        {
            InitializeComponent();
            _mode = mode;
            _editDrug = drug.Name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            Drug drug = DrugDatabaseForm.instance.database.GetDrugByName(_editDrug);
            if (_mode == Mode.Edit) 
            {                
                DrgName.Text = drug.Name;
                DrgProducer .Text = drug.Producer;
                DrgDescription.Text = drug.Description;
                DrgInStock.Text = drug.InStock.ToString();
                DrgPrice.Text = drug.Price.ToString();
            }   
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //validate input data
            int stock;
            double price;
            try 
            {
                if (DrgInStock.Text == "")
                    stock = 0;
                else
                    stock = Convert.ToInt16(DrgInStock.Text);

                if (DrgPrice.Text == "")
                    price = 0;
                else
                    price = Convert.ToDouble(DrgPrice.Text.Replace('.', ','));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            // store input data
            if (_mode == Mode.Add) // create new drug
            {                
                var result = DrugDatabaseForm.instance.database.AddNewDrug(new Drug(DrgName.Text, 
                    DrgDescription.Text,
                    DrgProducer.Text,
                    stock,
                    price,
                    string.Empty));
                if (!result)
                    MessageBox.Show("Drug with this name already exist!", "Error");
                else
                    this.Close();
            } else if (_mode == Mode.Edit) // edit existing drug by index
            {               
                var result = DrugDatabaseForm.instance.database.EditDrug(DrugDatabaseForm.instance.database.GetDrugByName(_editDrug),
                    DrgName.Text,
                    DrgDescription.Text,
                    DrgProducer.Text,
                    stock,
                    price);
                if (!result)
                    MessageBox.Show("Drug with this name already exist!", "Error");
                else
                    this.Close();
            }            
        }
    }
}
