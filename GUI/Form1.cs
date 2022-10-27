using Proiect3_AI.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proiect3_AI
{
    public partial class Form1 : Form
    {
        Antrenament antr = new Antrenament();
        public Form1()
        {
            InitializeComponent();
            LoadCirosisData("cirrhosis.csv");
            GetObject();
            Calcul.MaxMinAtribute();
        }

        private void LoadCirosisData(string fileName)
        {
            try
            {
                ReadFile csv = new ReadFile(fileName);

                try
                {
                    cirosisDGV.DataSource = csv.readCSV;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void GetObject()
        {
            StorageData.cirozaList = File.ReadAllLines("D:\\School\\Inteligenta artificiala\\Laborator\\Proiect3 AI\\bin\\Debug\\net6.0-windows\\cirrhosis.csv")
                                           .Skip(1)
                                           .Select(v => CirozaData.FromCsv(v))
                                           .ToList();
        }

        private void normalizaredate()
        {
            foreach (var obiect in StorageData.cirozaList)
            {
                NormalizedCirozaData normalizedCirozaData = new NormalizedCirozaData();

                //nr_zile
                normalizedCirozaData.NumberDays = Calcul.normalizare(obiect.NumberDays, StorageData.min_nr_zile, StorageData.max_nr_zile);

                //status
                if (obiect.Status.Contains("D"))
                {
                    normalizedCirozaData.Status = 0.1;
                }
                else if(obiect.Status.Contains("C"))
                {
                    normalizedCirozaData.Status = 0.5;
                }
                else if(obiect.Status.Contains("CL"))
                {
                    normalizedCirozaData.Status = 0.9;
                }

                //drug
                if (obiect.Drug.Contains("D-penicillamine"))
                {
                    normalizedCirozaData.Drug = 0.1;
                }
                else if (obiect.Drug.Contains("Placebo"))
                {
                    normalizedCirozaData.Drug = 0.9;
                }

                //age
                normalizedCirozaData.Age = Calcul.normalizare(obiect.Age, StorageData.min_ani, StorageData.max_ani);

                //sex
                if (obiect.Sex.Contains("M"))
                {
                    normalizedCirozaData.Sex = 0.1;
                }
                else if (obiect.Sex.Contains("F"))
                {
                    normalizedCirozaData.Sex = 0.9;
                }

                //ascites
                if (obiect.Ascites.Contains("Y"))
                {
                    normalizedCirozaData.Ascites = 0.1;
                }
                else if (obiect.Ascites.Contains("N"))
                {
                    normalizedCirozaData.Ascites = 0.9;
                }

                //hepatomegaly
                if (obiect.Hepatomegaly.Contains("Y"))
                {
                    normalizedCirozaData.Hepatomegaly = 0.1;
                }
                else if (obiect.Hepatomegaly.Contains("N"))
                {
                    normalizedCirozaData.Hepatomegaly = 0.9;
                }

                //spider
                if (obiect.Spiders.Contains("Y"))
                {
                    normalizedCirozaData.Spiders = 0.1;
                }
                else if (obiect.Spiders.Contains("N"))
                {
                    normalizedCirozaData.Spiders = 0.9;
                }

                //edema
                if (obiect.Edema.Contains("Y"))
                {
                    normalizedCirozaData.Edema = 0.1;
                }
                else if (obiect.Edema.Contains("N"))
                {
                    normalizedCirozaData.Edema = 0.9;
                }

                //bilirubin
                normalizedCirozaData.Bilirubin = Calcul.normalizare(obiect.Bilirubin, StorageData.min_bilirubin, StorageData.max_bilirubin);

                //cholesterol
                normalizedCirozaData.Cholesterol = Calcul.normalizare(obiect.Cholesterol, StorageData.min_cholesterol, StorageData.max_cholesterol);

                //albumin
                normalizedCirozaData.Albumin = Calcul.normalizare(obiect.Albumin, StorageData.min_albumin, StorageData.max_albumin);

                //copper
                normalizedCirozaData.Copper = Calcul.normalizare(obiect.Copper, StorageData.min_copper, StorageData.max_copper);

                //alk_phos
                normalizedCirozaData.Alk_Phos = Calcul.normalizare(obiect.Alk_Phos, StorageData.min_alk_phos, StorageData.max_alk_phos);

                //sgot
                normalizedCirozaData.SGOT = Calcul.normalizare(obiect.SGOT, StorageData.min_sgot, StorageData.max_sgot);

                //tryglicerid
                normalizedCirozaData.Tryglicerid = Calcul.normalizare(obiect.Tryglicerid, StorageData.min_tryglicerine, StorageData.max_tryglicerine);

                //platelets
                normalizedCirozaData.Platelets = Calcul.normalizare(obiect.Platelets, StorageData.min_platelets, StorageData.max_platelets);

                //prothrombin
                normalizedCirozaData.Prothrombin = Calcul.normalizare(obiect.Prothrombin, StorageData.min_prothombin, StorageData.max_prothombin);

                //stage
                if (obiect.Stage == 1)
                {
                    normalizedCirozaData.Stage = 0.1;
                }
                else if (obiect.Stage == 2)
                {
                    normalizedCirozaData.Stage = 0.25;
                }
                else if (obiect.Stage == 3)
                {
                    normalizedCirozaData.Stage = 0.5;
                }
                else if (obiect.Stage == 4)
                {
                    normalizedCirozaData.Stage = 0.9;
                }
                StorageData.normalizedCirozaList.Add(normalizedCirozaData);
                SplitData(StorageData.normalizedCirozaList);
            } 
        }

        private void antrenamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            antr.ShowDialog();
        }

        private void normalizeTMS_Click(object sender, EventArgs e)
        {
            normalizaredate();
            cirosisDGV.DataSource = StorageData.normalizedCirozaList;
        }

        private void SplitData(List<NormalizedCirozaData> data)
        {
            Random rnd = new Random();
            foreach (NormalizedCirozaData item in data)
            {
                int number = rnd.Next(1, 100);

                if (number <= 70)
                {
                    StorageData.antrenamentList.Add(item);
                }
                else
                {
                    StorageData.testList.Add(item);
                }
            }
        }
    }
}