using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3_AI
{
    public class CirozaData
    {
        public int NumberDays { get; set; }
        public string Status { get; set; }
        public string Drug { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Ascites { get; set; }
        public string Hepatomegaly { get; set; }
        public string Spiders { get; set; }
        public string Edema { get; set; }
        public double Bilirubin { get; set; } 
        public int Cholesterol { get; set; }
        public double Albumin { get; set; }
        public int Copper { get; set; }
        public double Alk_Phos { get; set; }
        public double SGOT { get; set; }
        public int Tryglicerid { get; set; }
        public int Platelets { get; set; }
        public double Prothrombin { get; set; }
        public int Stage { get; set; }

        public static CirozaData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            CirozaData cirozaData = new CirozaData();
            cirozaData.NumberDays = Convert.ToInt32(values[0]);
            cirozaData.Status = Convert.ToString(values[1]);
            cirozaData.Drug = Convert.ToString(values[2]);
            cirozaData.Age = Convert.ToInt32(values[3]);
            cirozaData.Sex = Convert.ToString(values[4]);
            cirozaData.Ascites = Convert.ToString(values[5]);
            cirozaData.Hepatomegaly = Convert.ToString(values[6]);
            cirozaData.Spiders = Convert.ToString(values[7]);
            cirozaData.Edema = Convert.ToString(values[8]);
            cirozaData.Bilirubin = Convert.ToDouble(values[9]);
            cirozaData.Cholesterol = Convert.ToInt32(values[10]);
            cirozaData.Albumin = Convert.ToDouble(values[11]);
            cirozaData.Copper = Convert.ToInt32(values[12]);
            cirozaData.Alk_Phos = Convert.ToDouble(values[13]);
            cirozaData.SGOT = Convert.ToDouble(values[14]);
            cirozaData.Tryglicerid = Convert.ToInt32(values[15]);
            cirozaData.Platelets = Convert.ToInt32(values[16]);
            cirozaData.Prothrombin = Convert.ToDouble(values[17]);
            cirozaData.Stage = Convert.ToInt32(values[18]);
            return cirozaData;
        }

    }
}
