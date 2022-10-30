using Microsoft.Graph;
using Microsoft.Graph.TermStore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Proiect3_AI
{
    public partial class Antrenament : Form
    {
        static Random random = new Random();
        public Antrenament()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
            zedGraphControl1.IsShowPointValues = true;
        }

        private void nrHLNUD_ValueChanged(object sender, EventArgs e)
        {
            if (nrHLNUD.Value == 1)
            {
                hl2Label.Visible = false;
                neuHL2NUD.Visible = false;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if (nrHLNUD.Value == 2)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if (nrHLNUD.Value == 3)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = true;
                neuHL3NUD.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StorageData.nrHL = (int)nrHLNUD.Value;
            StorageData.nrEpoci = int.Parse(EpocaTxt.Text);
            StorageData.rata_invatare = (double)ratadeinvNud.Value;
            ReteaHL();
            GenerateRetea();
            InitializareWait();
            feedForward_backPropagation(backgroundWorker1);
            backgroundWorker1.RunWorkerAsync();
        }

        private void ReteaHL()
        {
            if ((int)nrHLNUD.Value == 1)
            {
                StorageData.nrNeuHL1 = (int)neuHL1NUD.Value;
            }
            if ((int)nrHLNUD.Value == 2)
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

            if (StorageData.nrHL == 1)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL1; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);
            }
            if (StorageData.nrHL == 2)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL1; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);

                List<Neuron> h2 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL2; i++)
                {
                    Neuron neuron_h2 = new Neuron();
                    h1.Add(neuron_h2);
                }
                StorageData.neuronHLList.Add(h2);
            }
            if (StorageData.nrHL == 3)
            {
                List<Neuron> h1 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL1; i++)
                {
                    Neuron neuron_h1 = new Neuron();
                    h1.Add(neuron_h1);
                }
                StorageData.neuronHLList.Add(h1);

                List<Neuron> h2 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL2; i++)
                {
                    Neuron neuron_h2 = new Neuron();
                    h1.Add(neuron_h2);
                }
                StorageData.neuronHLList.Add(h2);

                List<Neuron> h3 = new List<Neuron>();
                for (int i = 0; i < StorageData.nrNeuHL3; i++)
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

            if (StorageData.nrHL == 3)
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

        public static void feedForward_backPropagation(BackgroundWorker worker)
        {
            for (int i = 0; i < StorageData.nrEpoci; i++)
            {

                if (worker.CancellationPending)
                {
                    StorageData.inputLayer.Clear();
                    StorageData.hiddenLayer.Clear();
                    StorageData.outputLayer.Clear();
                    StorageData.neuronHLList.Clear();

                    break;
                }
                else
                {

                    foreach (var obiect in StorageData.antrenamentList)
                    {
                        FeedForward(obiect);
                        double error = CalculateError(StorageData.outputLayer, obiect);
                        StorageData.epochErrorList.Add(error);
                        setareErori_and_weights(StorageData.inputLayer, StorageData.neuronHLList, StorageData.outputLayer, obiect);
                    }

                    double epochError = CalculateEpochError(StorageData.epochErrorList);

                    worker.ReportProgress(0, new PointPair(i, epochError));

                    StorageData.errorEpoca = epochError;
                    Console.WriteLine("epoch " + i + "= " + StorageData.errorEpoca);

                }
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
            foreach (var layer in StorageData.neuronHLList)
            {
                if (j == 0)
                {
                    TransferData(StorageData.inputLayer, StorageData.neuronHLList[0]);
                    CalculeazaOutput_HiddenLayer(StorageData.neuronHLList[0]);
                    j_minus = j;
                    j++;
                }
                else
                {
                    TransferData(StorageData.neuronHLList[j_minus], StorageData.neuronHLList[j]);
                    CalculeazaOutput_HiddenLayer(StorageData.neuronHLList[j]);
                    j_minus = j;
                    j++;
                }

            }

            TransferData(StorageData.neuronHLList[j - 1], StorageData.outputLayer);
            CalculeazaOutput_OutputLayer(StorageData.outputLayer);
            StorageData.rezultatOut = StorageData.outputLayer[0].output;
        }

        public static void setareErori_and_weights(List<Neuron> inputList, List<List<Neuron>> neuHLList, List<Neuron> outputList, NormalizedCirozaData data)
        {
            foreach (var neuron_ol in outputList)
            {
                double delta = (neuron_ol.output - data.Stage) * neuron_ol.activation * (1 - neuron_ol.activation);
                neuron_ol.delta = delta;
                for (int k = 0; k < neuron_ol.waitvalue.Length; k++)
                {
                    double deltaWeight = StorageData.rata_invatare * neuHLList[StorageData.nrHL - 1][k].output * delta;
                    neuron_ol.waitvalue[k] -= deltaWeight;
                }
            }

            if (StorageData.nrHL == 2)
            {
                double val_suma = 0;
                int index_neuron_hl = 0;

                foreach (var neuron_hl in neuHLList[StorageData.nrHL - 1])
                {
                    double deltaS = 0;

                    for (int k = 0; k < outputList.Count; k++)
                    {
                        deltaS += outputList[k].waitvalue[index_neuron_hl] * outputList[k].delta;
                    }

                    double delta = deltaS * neuron_hl.activation * (1 - neuron_hl.activation);
                    neuron_hl.delta = delta;

                    for (int k = 0; k < neuron_hl.waitvalue.Length; k++)
                    {
                        double deltaWeight = StorageData.rata_invatare * neuHLList[StorageData.nrHL - 2][k].output * delta;
                        neuron_hl.waitvalue[k] -= deltaWeight;
                    }

                    index_neuron_hl++;
                    val_suma = 0;
                }
                index_neuron_hl = 0;


                foreach (var neuron_hl_stanga in neuHLList[StorageData.nrHL - 2])
                {
                    double deltaS = 0;

                    for (int k = 0; k < neuHLList[StorageData.nrHL - 1].Count; k++)
                    {
                        deltaS += neuHLList[StorageData.nrHL - 1][k].waitvalue[index_neuron_hl] * neuHLList[StorageData.nrHL - 1][k].delta;
                    }

                    double delta = deltaS * neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation);
                    neuron_hl_stanga.delta = delta;

                    for (int k = 0; k < neuron_hl_stanga.waitvalue.Length; k++)
                    {
                        double deltaWeight = StorageData.rata_invatare * inputList[k].output * delta;
                        neuron_hl_stanga.waitvalue[k] -= deltaWeight;
                    }

                    index_neuron_hl++;
                    val_suma = 0;
                }
                index_neuron_hl = 0;
            }

            if (StorageData.nrHL == 3)
            {
                double val_suma = 0;
                int index_neuron_hl = 0;

                foreach (var neuron_hl in neuHLList[StorageData.nrHL - 1])
                {
                    double deltaS = 0;

                    for (int k = 0; k < outputList.Count; k++)
                    {
                        deltaS += outputList[k].waitvalue[index_neuron_hl] * outputList[k].delta;
                    }

                    double delta = deltaS * neuron_hl.activation * (1 - neuron_hl.activation);
                    neuron_hl.delta = delta;

                    for (int k = 0; k < neuron_hl.waitvalue.Length; k++)
                    {
                        double deltaWeight = StorageData.rata_invatare * neuHLList[StorageData.nrHL - 2][k].output * delta;
                        neuron_hl.waitvalue[k] -= deltaWeight;
                    }

                    index_neuron_hl++;
                    val_suma = 0;
                }
                index_neuron_hl = 0;

                foreach (var neuron_hl_stanga in neuHLList[StorageData.nrHL - 2])
                {
                    double deltaS = 0;

                    for (int k = 0; k < neuHLList[StorageData.nrHL - 1].Count; k++)
                    {
                        deltaS += neuHLList[StorageData.nrHL - 1][k].waitvalue[index_neuron_hl] * neuHLList[StorageData.nrHL - 1][k].delta;
                    }

                    double delta = deltaS * neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation);
                    neuron_hl_stanga.delta = delta;

                    for (int k = 0; k < neuron_hl_stanga.waitvalue.Length; k++)
                    {
                        double deltaWeight = StorageData.rata_invatare * neuHLList[StorageData.nrHL - 3][k].output * delta;
                        neuron_hl_stanga.waitvalue[k] -= deltaWeight;
                    }

                    index_neuron_hl++;
                    val_suma = 0;
                }
                index_neuron_hl = 0;

                foreach (var neuron_hl_stanga in neuHLList[StorageData.nrHL - 3])
                {
                    double deltaS = 0;

                    for (int k = 0; k < neuHLList[StorageData.nrHL - 2].Count; k++)
                    {
                        deltaS += neuHLList[StorageData.nrHL - 2][k].waitvalue[index_neuron_hl] * neuHLList[StorageData.nrHL - 2][k].delta;
                    }

                    double delta = deltaS * neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation);
                    neuron_hl_stanga.delta = delta;

                    for (int k = 0; k < neuron_hl_stanga.waitvalue.Length; k++)
                    {
                        double deltaWeight = StorageData.rata_invatare * inputList[k].output * delta;
                        neuron_hl_stanga.waitvalue[k] -= deltaWeight;
                    }

                    index_neuron_hl++;
                    val_suma = 0;
                }
                index_neuron_hl = 0;
            }
        }

        public static void schimbare_weights(List<Neuron> inputList, List<List<Neuron>> neuHLList, List<Neuron> outputList, NormalizedCirozaData data)
        {

            if (StorageData.nrHL == 1)
            {
                int nr_hidden_layere = StorageData.nrHL;
                foreach (var neuron in outputList)
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 1][i].output * neuron.delta);
                    }
                }

                foreach (var neuron in neuHLList[nr_hidden_layere - 1])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * inputList[i].output * neuron.delta);
                    }
                }
            }
            else if (StorageData.nrHL == 2)
            {
                int nr_hidden_layere = StorageData.nrHL;
                foreach (var neuron in outputList)
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 1][i].output * neuron.delta);
                    }
                }

                foreach (var neuron in neuHLList[nr_hidden_layere - 1])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 2][i].output * neuron.delta);
                    }
                }


                foreach (var neuron in neuHLList[nr_hidden_layere - 2])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * inputList[i].output * neuron.delta);
                    }
                }
            }
            else if (StorageData.nrHL == 3)
            {
                int nr_hidden_layere = StorageData.nrHL;
                foreach (var neuron in outputList)
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 1][i].output * neuron.delta);
                    }
                }

                foreach (var neuron in neuHLList[nr_hidden_layere - 1])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 2][i].output * neuron.delta);
                    }
                }

                foreach (var neuron in neuHLList[nr_hidden_layere - 2])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * neuHLList[nr_hidden_layere - 3][i].output * neuron.delta);
                    }
                }


                foreach (var neuron in neuHLList[nr_hidden_layere - 3])
                {
                    int nr_weighturi = neuron.waitvalue.Length;
                    for (int i = 0; i < nr_weighturi; i++)
                    {
                        neuron.waitvalue[i] = neuron.waitvalue[i] + (StorageData.rata_invatare * inputList[i].output * neuron.delta);
                    }
                }
            }

        }

        public static void setareErori(List<List<Neuron>> lista_de_liste_Hidden_Layere, List<Neuron> lista_Output_Layer, NormalizedCirozaData data)
        {
            int nr_hidden_layers = StorageData.nrHL;

            foreach (var neuron_ol in lista_Output_Layer)
            {
                neuron_ol.delta = (neuron_ol.output - data.Stage) * (neuron_ol.activation * (1 - neuron_ol.activation));
            }

            if (nr_hidden_layers == 1)
            {
                double val_suma = 0;
                int index_neuron_hl = 0;

                foreach (var neuron_hl in lista_de_liste_Hidden_Layere[nr_hidden_layers - 1])
                {
                    foreach (var neuron_ol in lista_Output_Layer)
                    {
                        val_suma = val_suma + neuron_ol.delta * neuron_ol.waitvalue[index_neuron_hl];
                    }
                    neuron_hl.delta = val_suma * (neuron_hl.activation * (1 - neuron_hl.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }
            }
            else if (nr_hidden_layers == 2)
            {
                double val_suma = 0;
                int index_neuron_hl = 0;

                foreach (var neuron_hl in lista_de_liste_Hidden_Layere[nr_hidden_layers - 1])
                {
                    foreach (var neuron_ol in lista_Output_Layer)
                    {
                        val_suma = val_suma + neuron_ol.delta * neuron_ol.waitvalue[index_neuron_hl];
                    }
                    neuron_hl.delta = val_suma * (neuron_hl.activation * (1 - neuron_hl.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }

                foreach (var neuron_hl_stanga in lista_de_liste_Hidden_Layere[nr_hidden_layers - 2])
                {
                    foreach (var neuron_hl_dreapta in lista_de_liste_Hidden_Layere[nr_hidden_layers - 1])
                    {
                        val_suma = val_suma + neuron_hl_dreapta.delta * neuron_hl_dreapta.waitvalue[index_neuron_hl];
                    }
                    neuron_hl_stanga.delta = val_suma * (neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }

            }
            else if (nr_hidden_layers == 3)
            {
                double val_suma = 0;
                int index_neuron_hl = 0;

                foreach (var neuron_hl in lista_de_liste_Hidden_Layere[nr_hidden_layers - 1])
                {
                    foreach (var neuron_ol in lista_Output_Layer)
                    {
                        val_suma = val_suma + neuron_ol.delta * neuron_ol.waitvalue[index_neuron_hl];
                    }
                    neuron_hl.delta = val_suma * (neuron_hl.activation * (1 - neuron_hl.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }

                foreach (var neuron_hl_stanga in lista_de_liste_Hidden_Layere[nr_hidden_layers - 2])
                {
                    foreach (var neuron_hl_dreapta in lista_de_liste_Hidden_Layere[nr_hidden_layers - 1])
                    {
                        val_suma = val_suma + neuron_hl_dreapta.delta * neuron_hl_dreapta.waitvalue[index_neuron_hl];
                    }
                    neuron_hl_stanga.delta = val_suma * (neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }

                foreach (var neuron_hl_stanga in lista_de_liste_Hidden_Layere[nr_hidden_layers - 3])
                {
                    foreach (var neuron_hl_dreapta in lista_de_liste_Hidden_Layere[nr_hidden_layers - 2])
                    {
                        val_suma = val_suma + neuron_hl_dreapta.delta * neuron_hl_dreapta.waitvalue[index_neuron_hl];
                    }
                    neuron_hl_stanga.delta = val_suma * (neuron_hl_stanga.activation * (1 - neuron_hl_stanga.activation));
                    index_neuron_hl++;
                    val_suma = 0;
                    index_neuron_hl = 0;
                }
            }
        }

        private static double CalculateEpochError(List<double> errorEpch)
        {
            double error = 0;
            foreach (double value in errorEpch)
            {
                error += value;
            }
            error /= errorEpch.Count;
            return error;
        }

        private static double CalculateError(List<Neuron> ol_list, NormalizedCirozaData obiect)
        {
            double sum = 0;
            for (int i = 0; i < 1; i++)
            {
                sum += Math.Pow((getTargetOutput(ol_list, obiect) - getOutput(ol_list, obiect)), 2);
            }
            sum = sum / (2 * 1);
            return sum;
        }

        public static double getOutput(List<Neuron> ol_list, NormalizedCirozaData obiect)
        {
            return StorageData.outputLayer[0].output;
        }

        public static double getTargetOutput(List<Neuron> ol_list, NormalizedCirozaData obiect)
        {
            return obiect.Stage;
        }

        public static void calculare_eroare_pas(List<Neuron> lista_Output_Layer, NormalizedCirozaData data)
        {
            StorageData.errorStep = (1.0 / (2.0 * lista_Output_Layer.Count)) * Math.Pow((lista_Output_Layer[0].output - data.Stage), 2);
            StorageData.errorSum = StorageData.errorSum + StorageData.errorStep;
        }

        public static void TransferData(List<Neuron> left, List<Neuron> right)
        {
            for (int i = 0; i < right.Count; i++)
            {
                for (int j = 0; j < right[i].inputvalue.Count(); j++)
                {
                    right[i].inputvalue[j] = left[j].output;
                }
            }
        }

        public static void CalculeazaOutput_HiddenLayer(List<Neuron> neuronHl)
        {
            foreach (var neuron in neuronHl)
            {
                neuron.input = CalculSuma(neuron);
                neuron.activation = CalculTanh(neuron);
                neuron.output = neuron.activation;
            }
        }

        public static void CalculeazaOutput_OutputLayer(List<Neuron> neuronOL)
        {
            foreach (var neuron in neuronOL)
            {
                neuron.input = CalculSuma(neuron);
                neuron.activation = CalculSigmoidala(neuron);
                neuron.output = neuron.activation;
            }
        }

        public static double CalculSuma(Neuron neuron)
        {
            double sum = 0;
            for (int i = 0; i < neuron.inputvalue.Length; i++)
            {
                sum += neuron.inputvalue[i] * neuron.waitvalue[i];
            }
            return sum;
        }

        public static double CalculSigmoidala(Neuron neuron)
        {
            double numarator = 1.0;
            double numitor = 1 + Math.Pow(Math.E, -1 * 1 * (neuron.input - 0));
            return numarator / numitor;
        }

        public static double CalculTanh(Neuron neuron)
        {
            double numarator = 1f;
            double numitor = 1 + Math.Exp(-1 * neuron.input);
            double act = numarator / numitor;

            return act;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            EroarepasLbl.Text = StorageData.errorEpoca.ToString();
        }

        public static void initializare_vectori_weights_inputs()
        {

            if (StorageData.nrHL == 1)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List)
                {
                    neuron.numberOfInput = StorageData.inputLayer.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

            }

            else if (StorageData.nrHL == 2)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 2].neuroni_HL_List)
                {

                    neuron.numberOfInput = StorageData.inputLayer.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List)
                {

                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 2].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }


                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }
            }


            else if (StorageData.nrHL == 3)
            {
                double maximum = 1;
                double minimum = -1;

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 3].neuroni_HL_List)
                {

                    neuron.numberOfInput = StorageData.inputLayer.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 2].neuroni_HL_List)
                {
     
                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 3].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List)
                {
                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 2].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

                foreach (var neuron in StorageData.outputLayer)
                {
                    neuron.numberOfInput = StorageData.hiddenLayer[StorageData.nrHL - 1].neuroni_HL_List.Count;
                    neuron.waitvalue = new double[neuron.numberOfInput];
                    neuron.inputvalue = new double[neuron.numberOfInput];

                    for (int i = 0; i < neuron.waitvalue.Length; i++)
                    {
                        neuron.waitvalue[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
                    }
                }

            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            StorageData.point.Clear();
            GenerateRetea();
            initializare_vectori_weights_inputs();
            zedGraphControl1.GraphPane.AddCurve("Error", StorageData.point, Color.Red);

            zedGraphControl1.GraphPane.XAxis.Scale.Min = -1;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = StorageData.nrEpoci + 1;

            zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 0.01;

            feedForward_backPropagation(backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            PointPair point = e.UserState as PointPair;
            StorageData.point.Add(point.X, point.Y);
            EpocaTxt.Text = point.Y.ToString();
            zedGraphControl1.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("Canceled");
            }
            else if (e.Error != null)
            {
                Console.WriteLine("No fucking idea");
            }
            else
            {
                Console.WriteLine("DONE");
            }
        }
    }
}
