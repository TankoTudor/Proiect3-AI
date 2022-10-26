using Microsoft.VisualBasic.FileIO;
using Proiect3_AI.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3_AI
{
    public class ReadFile
    {
        public DataTable readCSV;

        public ReadFile(string fileName, bool firstRowContainsFieldNames = true)
        {
            readCSV = GenerateDataTable(fileName, firstRowContainsFieldNames);
        }

        private static DataTable GenerateDataTable(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();
            CirozaData cirozaData = new CirozaData();

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                        {
                            result.Columns.Add(fields[i]);
                        }
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }
            return result;
        }
    }    
}
