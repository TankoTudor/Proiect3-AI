using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3_AI.Classes
{
    public class Calcul
    {
        public static void MaxMinAtribute()
        {

            //numar zile
            StorageData.min_nr_zile = StorageData.cirozaList[0].NumberDays;
            StorageData.max_nr_zile = StorageData.cirozaList[0].NumberDays;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.NumberDays <= StorageData.min_nr_zile)
                {
                    StorageData.min_nr_zile = obj.NumberDays;
                }
                if (obj.NumberDays >= StorageData.max_nr_zile)
                {
                    StorageData.max_nr_zile = obj.NumberDays;
                }
            }

            //ani
            StorageData.min_ani = StorageData.cirozaList[0].Age;
            StorageData.max_ani = StorageData.cirozaList[0].Age;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Age <= StorageData.min_ani)
                {
                    StorageData.min_ani = obj.Age;
                }
                if (obj.Age >= StorageData.max_ani)
                {
                    StorageData.max_ani = obj.Age;
                }
            }

            //bilirubin
            StorageData.min_bilirubin = StorageData.cirozaList[0].Bilirubin;
            StorageData.max_bilirubin = StorageData.cirozaList[0].Bilirubin;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Bilirubin <= StorageData.min_bilirubin)
                {
                    StorageData.min_bilirubin = obj.Bilirubin;
                }
                if (obj.Bilirubin >= StorageData.max_bilirubin)
                {
                    StorageData.max_bilirubin = obj.Bilirubin;
                }
            }

            //cholesterol
            StorageData.min_cholesterol = StorageData.cirozaList[0].Cholesterol;
            StorageData.max_cholesterol = StorageData.cirozaList[0].Cholesterol;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Cholesterol <= StorageData.min_cholesterol)
                {
                    StorageData.min_cholesterol = obj.Cholesterol;
                }
                if (obj.Cholesterol >= StorageData.max_cholesterol)
                {
                    StorageData.max_cholesterol = obj.Cholesterol;
                }
            }

            //albumin
            StorageData.min_albumin = StorageData.cirozaList[0].Albumin;
            StorageData.max_albumin = StorageData.cirozaList[0].Albumin;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Albumin <= StorageData.min_albumin)
                {
                    StorageData.min_albumin = obj.Albumin;
                }
                if (obj.Albumin >= StorageData.max_albumin)
                {
                    StorageData.max_albumin = obj.Albumin;
                }
            }

            //cooper
            StorageData.min_copper = StorageData.cirozaList[0].Copper;
            StorageData.max_copper = StorageData.cirozaList[0].Copper;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Copper <= StorageData.min_copper)
                {
                    StorageData.min_copper = obj.Copper;
                }
                if (obj.Copper >= StorageData.max_copper)
                {
                    StorageData.max_copper = obj.Copper;
                }
            }

            //alk_phos
            StorageData.min_alk_phos = StorageData.cirozaList[0].Alk_Phos;
            StorageData.max_alk_phos = StorageData.cirozaList[0].Alk_Phos;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Alk_Phos <= StorageData.min_alk_phos)
                {
                    StorageData.min_alk_phos = obj.Alk_Phos;
                }
                if (obj.Alk_Phos >= StorageData.max_alk_phos)
                {
                    StorageData.max_alk_phos = obj.Alk_Phos;
                }
            }

            //sgot
            StorageData.min_sgot = StorageData.cirozaList[0].SGOT;
            StorageData.max_sgot = StorageData.cirozaList[0].SGOT;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.SGOT <= StorageData.min_sgot)
                {
                    StorageData.min_sgot = obj.SGOT;
                }
                if (obj.SGOT >= StorageData.max_sgot)
                {
                    StorageData.max_sgot = obj.SGOT;
                }
            }

            //tryglicerine
            StorageData.min_tryglicerine = StorageData.cirozaList[0].Tryglicerid;
            StorageData.max_tryglicerine = StorageData.cirozaList[0].Tryglicerid;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Tryglicerid <= StorageData.min_tryglicerine)
                {
                    StorageData.min_tryglicerine = obj.Tryglicerid;
                }
                if (obj.Tryglicerid >= StorageData.max_tryglicerine)
                {
                    StorageData.max_tryglicerine = obj.Tryglicerid;
                }
            }

            //platelets
            StorageData.min_platelets = StorageData.cirozaList[0].Platelets;
            StorageData.max_platelets = StorageData.cirozaList[0].Platelets;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Platelets <= StorageData.min_platelets)
                {
                    StorageData.min_platelets = obj.Platelets;
                }
                if (obj.Platelets >= StorageData.max_platelets)
                {
                    StorageData.max_platelets = obj.Platelets;
                }
            }

            //prothomnim
            StorageData.min_prothombin = StorageData.cirozaList[0].Prothrombin;
            StorageData.max_prothombin = StorageData.cirozaList[0].Prothrombin;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Prothrombin <= StorageData.min_prothombin)
                {
                    StorageData.min_prothombin = obj.Prothrombin;
                }
                if (obj.Prothrombin >= StorageData.max_prothombin)
                {
                    StorageData.max_prothombin = obj.Prothrombin;
                }
            }

            //stage
            StorageData.min_stage = StorageData.cirozaList[0].Stage;
            StorageData.max_stage = StorageData.cirozaList[0].Stage;
            foreach (var obj in StorageData.cirozaList)
            {
                if (obj.Stage <= StorageData.min_stage)
                {
                    StorageData.min_stage = obj.Stage;
                }
                if (obj.Stage >= StorageData.max_stage)
                {
                    StorageData.max_stage = obj.Stage;
                }
            }
        }
        public static double normalizare(double value,double min,double max)
        {
            double normalizare = (value - min) / (max - min);
            return normalizare;
        }
        public static double normalizare(int value, double min, double max)
        {
            double normalizare = (value - min) / (max - min);
            return normalizare;
        }

    }
}
