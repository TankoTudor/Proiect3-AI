using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3_AI.Classes
{
    public class Neuron
    {
        public double[] inputvalue = null;
        public double[] waitvalue = null;

        public double delta;
        public double input;
        public double activation;
        public double output;
        public double targetoutput;
    }
}
