using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3_AI.Classes
{
    public class StorageData
    {
        public static List<CirozaData> cirozaList = new List<CirozaData>();
        public static List<NormalizedCirozaData> normalizedCirozaList = new List<NormalizedCirozaData>();
        public static List<NormalizedCirozaData> antrenamentList = new List<NormalizedCirozaData>();
        public static List<NormalizedCirozaData> testList = new List<NormalizedCirozaData>();
        public static List<List<Neuron>> neuronHLList = new List<List<Neuron>>();
        public static List<Neuron> inputLayer = new List<Neuron>();
        public static List<Neuron> outputLayer = new List<Neuron>();
        public static int min_nr_zile,max_nr_zile;
        public static int min_ani,max_ani;
        public static double min_bilirubin,max_bilirubin;
        public static int min_cholesterol,max_cholesterol;
        public static double min_albumin,max_albumin;
        public static int min_copper,max_copper;
        public static double min_alk_phos,max_alk_phos;
        public static double min_sgot,max_sgot;
        public static int min_tryglicerine,max_tryglicerine;
        public static int min_platelets,max_platelets;
        public static double min_prothombin,max_prothombin;
        public static int min_stage,max_stage;
        public static int nrHL, nrNeuHL1, nrNeuHL2, nrNeuHL3;
        public static double error, rata_invatare;
        public static int nrEpoci;
        public static double errorStep, errorEpoca;
        
    }
}
