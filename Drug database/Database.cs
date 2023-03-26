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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Drug_database
{
    internal class Database
    {
        private List<Drug> drugs = new List<Drug>();
        public Database() {
        }
        public bool AddNewDrug(Drug drug)
        {
            foreach(string name in GetDrugNames()){
                if (name==drug.Name)return false;
            }
            drugs.Add(drug);
            return true;
        }

        public List<string> GetDrugNames()
        {
            List<string> names = new List<string>();
            foreach (Drug drug in drugs)
            {
                names.Add(drug.Name);
            }
            return names;
        }
        public string GetDrugDescriptipn(uint ID)
        {
            foreach (Drug drug in drugs)
            {
                if (drug.ID == ID) {
                    string description = drug.Description;
                    description = description.Replace("\"", "");
                    return description;
                }
            }
            return null;
        }

        public Drug GetDrugByName(string name)
        {
            Drug searchedDrug = drugs.FirstOrDefault(drug => drug.Name == name);
            if (searchedDrug != null)
            {
                return searchedDrug;
            }
            return null;
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
            object okno = CSVfile.Rows[0][0];
            for (int i = 0; i < CSVfile.Rows.Count; i++)
            {
                drugs.Add(new Drug(Convert.ToUInt32(CSVfile.Rows[i].Field<string>("ID")), CSVfile.Rows[i].Field<string>("Name"), CSVfile.Rows[i].Field<string>("Description"), CSVfile.Rows[i].Field<string>("Producer"), Convert.ToInt32(CSVfile.Rows[i].Field<string>("InStock")), Convert.ToDouble(CSVfile.Rows[i].Field<string>("Price")), CSVfile.Rows[i].Field<string>("PhotoPath")));
            }
            return true;
        }

    }
}
