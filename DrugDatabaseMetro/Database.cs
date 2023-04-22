using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Drug_database
{
    public class Database
    {
        private List<Drug> drugs = new List<Drug>();
        public Database() {

        }
        public bool AddNewDrug(Drug drug)
        {
            foreach (string name in GetDrugNames())
                if (name == drug.Name) return false;

            drugs.Add(drug);
            return true;
        }
        public bool EditDrug(Drug drug, string name, string desctription, string producer, int inStock, double price)
        {
            //foreach (string currentNames in GetDrugNames())
            //    if (currentNames == name) return false;

            drug.EditDrug(name, desctription, producer, inStock, price);
            return true;
        }

        public void DeleteDrug(Drug drug)
        {
            drugs.Remove(drug);
        }

        public Drug GetDrugByName(string name)
        {
            IEnumerable<Drug> searchedDrug =
                from drg in drugs 
                where drg.Name == name
                select drg;

            try
            {
                return searchedDrug.First();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Cannot find selectes drug!", "Error");
                return null;
            }            
        }

        public Drug GetDrugByIndex(int index) // method that not use ID property
        {
            if (index >= drugs.Count || index < 0)
                return null;
            else
                return drugs[index];
        }

        public List<string> GetDrugNames()
        {
            var names = new List<string>();
            foreach (Drug drug in drugs)
            {
                names.Add(drug.Name);
            }
            return names;
        }

        public List <Drug> GetDrugList()
        {
            return drugs.ToList();
        }

        public bool ExportToCSV(string FilePath)
        {
            if (!drugs.Any()) return false;
            String firstline = string.Join(",", drugs[0].GetType().GetProperties().Select(p => p.Name));
            var data = from drug in drugs
                       let dataLine = drug.ToString()
                       select dataLine;
            var csvFile = new List<string>();
            csvFile.Add(firstline);
            csvFile.AddRange(data);
            Console.WriteLine(csvFile.ToArray());
            System.IO.File.WriteAllLines(FilePath, csvFile, Encoding.UTF8);

            return true;
        }

        public bool ImportFromCSV(string FilePath)
        {
            if (!File.Exists(FilePath)) return false;
            StreamReader file = new StreamReader(FilePath);
            string[] headers = file.ReadLine().Split(',');
            DataTable CSVfile = new DataTable();
            foreach (string header in headers)
            {
                CSVfile.Columns.Add(header);
            }
            while (!file.EndOfStream)
            {
                string row = file.ReadLine();
                string description = row;
                int from = description.IndexOf("\"") + 1;
                int to = description.LastIndexOf("\"");
                try
                {
                    description = description.Substring(from, to - from);
                    row = row.Replace(description, "#");
                    string[] rows = row.Split(',');
                    DataRow dr = CSVfile.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        if (rows[i].IndexOf("#") != -1) dr[i] = description;
                        else dr[i] = rows[i];
                    }
                    CSVfile.Rows.Add(dr);
                }
                catch
                {
                    return false;
                }
            }
            object okno = CSVfile.Rows[0][0];
            for (int i = 0; i < CSVfile.Rows.Count; i++)
            {
                /*drugs.Add(new Drug(CSVfile.Rows[i].Field<string>("Name"), 
                    CSVfile.Rows[i].Field<string>("Description"), 
                    CSVfile.Rows[i].Field<string>("Producer"), 
                    Convert.ToInt32(CSVfile.Rows[i].Field<string>("InStock")), 
                    ((double)Convert.ToInt32(CSVfile.Rows[i].Field<string>("Price"))) / 100.00, 
                    CSVfile.Rows[i].Field<string>("PhotoPath")));*/
                drugs.Add(new Drug(CSVfile.Rows[i].Field<string>("Name"), 
                    CSVfile.Rows[i].Field<string>("Description"), 
                    CSVfile.Rows[i].Field<string>("Producer"), 
                    Convert.ToInt32(CSVfile.Rows[i].Field<string>("InStock")), 
                    0, 
                    CSVfile.Rows[i].Field<string>("PhotoPath")));
            }
            return true;
        }

    }
}
