using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
                if (name == drug.Name) return false; // Check if a drug with the same name already exists

            drugs.Add(drug); // Add the new drug to the list
            return true; // Return true to indicate that the addition was successful
        }

        public bool EditDrug(Drug drug, string name, string desctription, string producer, int inStock, double price)
        {
            drug.EditDrug(name, desctription, producer, inStock, price); // Call the EditDrug method of the given drug object
            return true; // Return true to indicate that the edit was successful
        }

        public void DeleteDrug(Drug drug)
        {
            drugs.Remove(drug); // Remove the given drug from the list
        }

        public Drug GetDrugByName(string name)
        {
            IEnumerable<Drug> searchedDrug =
                from drg in drugs
                where drg.Name == name // Find a drug with the given name
                select drg;

            return searchedDrug.First(); // Return the first drug with the given name
        }

        public Drug GetDrugByIndex(int index)
        {
            if (index >= drugs.Count || index < 0)
                return null; // If the index is out of range, return null
            else
                return drugs[index]; // Otherwise, return the drug at the given index
        }

        public List<string> GetDrugNames()
        {
            var names = new List<string>();
            foreach (Drug drug in drugs)
            {
                names.Add(drug.Name); // Add each drug's name to the list
            }
            return names; // Return the list of drug names
        }

        public List<Drug> GetDrugList()
        {
            return drugs.ToList(); // Return a copy of the list of drugs
        }


        public bool ExportToCSV(string FilePath)
        {
            if (!drugs.Any()) return false; // Check if there are any drugs in the system

            // Get the headers from the first drug object's properties
            String firstline = string.Join(",", drugs[0].GetType().GetProperties().Select(p => p.Name));

            // Get the data from each drug object and format it as a CSV line
            var data = from drug in drugs
                       let dataLine = drug.ToString()
                       select dataLine;

            var csvFile = new List<string>(); // Create a new list to store the CSV lines
            csvFile.Add(firstline); // Add the headers to the list
            csvFile.AddRange(data); // Add the data to the list

            Console.WriteLine(csvFile.ToArray()); // Write the CSV lines to the console

            System.IO.File.WriteAllLines(FilePath, csvFile, Encoding.UTF8); // Write the CSV lines to a file

            return true; // Return true to indicate that the export was successful
        }

        public void ImportFromCSV(string FilePath)
        {
            if (!File.Exists(FilePath)) new FileNotFoundException(); // Check if file exists

            StreamReader file = new StreamReader(FilePath); // Create a StreamReader object to read from file
            string[] headers = file.ReadLine().Split(','); // Read the first line of the file as header and split it by comma
            DataTable CSVfile = new DataTable(); // Create a new DataTable to store the data

            // Add columns to the DataTable based on the headers
            foreach (string header in headers)
            {
                CSVfile.Columns.Add(header);
            }

            // Read the remaining lines of the file and add the data to the DataTable
            while (!file.EndOfStream)
            {
                string row = file.ReadLine(); // Read a row from the file
                string description = row;
                int from = description.IndexOf("\"") + 1;
                int to = description.LastIndexOf("\"");

                // Extract the description field and replace it with a placeholder
                description = description.Substring(from, to - from);
                row = row.Replace(description, "#");
                string[] rows = row.Split(','); // Split the row by comma to get the data fields
                DataRow dr = CSVfile.NewRow(); // Create a new DataRow object to store the data

                // Add the data to the DataRow object
                for (int i = 0; i < headers.Length; i++)
                {
                    if (rows[i].IndexOf("#") != -1) dr[i] = description; // Replace the placeholder with the actual description value
                    else dr[i] = rows[i];
                }

                CSVfile.Rows.Add(dr); // Add the DataRow object to the DataTable
            }

            // Loop through the DataTable and add each row to the system as a new Drug object
            for (int i = 0; i < CSVfile.Rows.Count; i++)
            {
                var temp = CSVfile.Rows[i].Field<string>("Price");

                // Create a new Drug object and add it to the system
                AddNewDrug(new Drug(CSVfile.Rows[i].Field<string>("Name"),
                    CSVfile.Rows[i].Field<string>("Description"),
                    CSVfile.Rows[i].Field<string>("Producer"),
                    Convert.ToInt32(CSVfile.Rows[i].Field<string>("InStock")),
                    Convert.ToDouble(temp, CultureInfo.InvariantCulture),
                    CSVfile.Rows[i].Field<string>("PhotoPath")));
            }
        }

        public bool SellDrug(Drug drug, int amount) //this function is obvious
        {
            if (amount < 0)
                return false;
            drug.SellDrug(amount);
            return true;
        }

    }
}
