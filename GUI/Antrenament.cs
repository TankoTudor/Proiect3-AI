using Proiect3_AI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect3_AI
{
    public partial class Antrenament : Form
    {
        static Random random = new Random();
        public Antrenament()
        {
            InitializeComponent();
        }

        private void nrHLNUD_ValueChanged(object sender, EventArgs e)
        {
            if(nrHLNUD.Value == 1)
            {
                hl2Label.Visible = false;
                neuHL2NUD.Visible = false;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if(nrHLNUD.Value == 2)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if(nrHLNUD.Value == 3)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = true;
                neuHL3NUD.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ReteaHL();
            GenerateRetea();
            StorageData.nrEpoci = int.Parse(EpocaTxt.Text);
        }

        private void ReteaHL()
        {
            if((int)nrHLNUD.Value == 1)
            {
                StorageData.nrNeuHL1 = (int)neuHL1NUD.Value;
            }
            if((int)nrHLNUD.Value == 2)
            {
                StorageData.nrNeuHL1 = (int)neuHL1NUD.Value;
                StorageData.nrNeuHL2 = (int)neuHL2NUD.Value;
            }
            if ((int)nrHLNUD.Value == 3)
            {
                StorageData.nrNeuHL1 = (int)neuHL1NUD.Value;
                StorageData.nrNeuHL2 = (int)neuHL2NUD.Value;
                StorageData.nrNeuHL3 = (int)neuHL3NUD.Value;
            }
        }

        private void GenerateRetea()
        {
            for (int i = 0; i < 19; i++)
            {
                Neuron neuron_IL = new Neuron();
                StorageData.inputLayer.Add(neuron_IL);
            }

            if(StorageData.nrHL == 1)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < neuHL1NUD.Value; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);
            }
            if(StorageData.nrHL == 2)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < neuHL1NUD.Value; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);

                List<Neuron> h2 = new List<Neuron>();
                for (int i = 0; i < neuHL2NUD.Value; i++)
                {
                    Neuron neuron_h2 = new Neuron();
                    h1.Add(neuron_h2);
                }
                StorageData.neuronHLList.Add(h2);
            }
            if (StorageData.nrHL == 3)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < neuHL1NUD.Value; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);

                List<Neuron> h2 = new List<Neuron>();
                for (int i = 0; i < neuHL2NUD.Value; i++)
                {
                    Neuron neuron_h2 = new Neuron();
                    h1.Add(neuron_h2);
                }
                StorageData.neuronHLList.Add(h2);

                List<Neuron> h3 = new List<Neuron>();
                for (int i = 0; i < neuHL3NUD.Value; i++)
                {
                    Neuron neuron_h3 = new Neuron();
                    h1.Add(neuron_h3);
                }
                StorageData.neuronHLList.Add(h3);
            }

            Neuron neuron_output = new Neuron();
            StorageData.outputLayer.Add(neuron_output);
        }

        public static void InitializareWait()
        {
            if (StorageData.nrHL == 1)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 1])
                {
                    neuron.waitvalue = new double[StorageData.inputLayer.Count];
                    neuron.inputvalue = new double[StorageData.inputLayer.Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }
            }

            if (StorageData.nrHL == 2)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 2])
                {
                    neuron.waitvalue = new double[StorageData.inputLayer.Count];
                    neuron.inputvalue = new double[StorageData.inputLayer.Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 1])
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 2].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 2].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }
            }

            if (StorageData.nrHL == 2)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 3])
                {
                    neuron.waitvalue = new double[StorageData.inputLayer.Count];
                    neuron.inputvalue = new double[StorageData.inputLayer.Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 2])
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 3].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 3].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.neuronHLList[StorageData.nrHL - 1])
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 2].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 2].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.waitvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];
                    neuron.inputvalue = new double[StorageData.neuronHLList[StorageData.nrHL - 1].Count];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }
            }
        }

        public static void feedForward_backPropagation()
        {

            for (int i = 0; i < StorageData.nrEpoci; i++)
            {
                foreach (var obiect in StorageData.normalizedCirozaList)
                {

                    feedforward_obiect(obiect);
                    setareErori(StorageData.neuronHLList, StorageData.outputLayer, obiect);
                    schimbare_weights(StorageData.inputLayer, StorageData.neuronHLList, StorageData.outputLayer, obiect);
                    calculare_eroare_pas(StorageData.outputLayer, obiect);
                    //Functii_Date.afisare_layere();


                }

                StorageData.errorEpoca = StorageData.errorStep / StorageData.normalizedCirozaList.Count;
            }

        }

        public static void FeedForward(NormalizedCirozaData obiect)
        {
            StorageData.inputLayer[0].output = obiect.NumberDays;
            StorageData.inputLayer[1].output = obiect.Status;
            StorageData.inputLayer[2].output = obiect.Drug;
            StorageData.inputLayer[3].output = obiect.Age;
            StorageData.inputLayer[4].output = obiect.Sex;
            StorageData.inputLayer[5].output = obiect.Ascites;
            StorageData.inputLayer[6].output = obiect.Hepatomegaly;
            StorageData.inputLayer[7].output = obiect.Spiders;
            StorageData.inputLayer[8].output = obiect.Edema;
            StorageData.inputLayer[9].output = obiect.Bilirubin;
            StorageData.inputLayer[10].output = obiect.Cholesterol;
            StorageData.inputLayer[11].output = obiect.Albumin;
            StorageData.inputLayer[12].output = obiect.Copper;
            StorageData.inputLayer[13].output = obiect.Alk_Phos;
            StorageData.inputLayer[14].output = obiect.SGOT;
            StorageData.inputLayer[15].output = obiect.Tryglicerid;
            StorageData.inputLayer[16].output = obiect.Platelets;
            StorageData.inputLayer[17].output = obiect.Prothrombin;
            StorageData.inputLayer[18].output = obiect.Stage;

            int j = 0;
            int j_minus = 0;
            foreach (var layer in Stocare_Date.lista_de_liste_Hidden_Layere)
            {
                if (j == 0)
                {
                    //suntem la primul hidden layer si transferam datele
                    TransferData(Stocare_Date.neuroni_IL_List, Stocare_Date.lista_de_liste_Hidden_Layere[0]);
                    //am transferat outputurile 

                    //calculam global inputul, activation si outputul
                    CalculeazaOutput_HiddenLayer(Stocare_Date.lista_de_liste_Hidden_Layere[0]);

                    j_minus = j;
                    j++;

                }
                else
                {
                    TransferData(Stocare_Date.lista_de_liste_Hidden_Layere[j_minus], Stocare_Date.lista_de_liste_Hidden_Layere[j]);
                    CalculeazaOutput_HiddenLayer(Stocare_Date.lista_de_liste_Hidden_Layere[j]);
                    j_minus = j;
                    j++;
                }

            }

            // PASUL 2 INCHEIAT
            //*************************************************************************************


            //--------------------------------------------------------------------------------------


            //*************************************************************************************
            //PASUL 3

            //transmiterea outputului din ultimul layer in vectorul de inputuri al output layer

            TransferData(Stocare_Date.lista_de_liste_Hidden_Layere[j - 1], Stocare_Date.neuroni_OL_List);
            CalculeazaOutput_OutputLayer(Stocare_Date.neuroni_OL_List);

            Stocare_Date.valoare_output_nn = Stocare_Date.neuroni_OL_List[0].val_output;

            // PASUL 3 INCHEIAT
            //*************************************************************************************


            //Console.WriteLine("valoarea de output al nn dupa rularea nr: " + contor + " este: " + Stocare_Date.valoare_output_nn);
            //contor++;
        }

    }
}
