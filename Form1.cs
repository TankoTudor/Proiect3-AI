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

        private void antrenamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            antr.ShowDialog();
        }
    }
}