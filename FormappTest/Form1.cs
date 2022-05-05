using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormappTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        int ED;
        string RaceName;
        double AVGPVI;
        double AVGCQ1;
        double AVGCQ2;
        double AVGCI1;
        double AVGCI2;
        double AVGE1;
        double AVGE2;
        double BatchQ;
        double BatchS;
        double TotalPopulation;
        double AVGMOE;
        double[] Can1Quality = { 70, 70, 70 };
        double[] Can2Quality = { 70, 70, 70 };
        double[] Can1Investment = { 70, 70, 70 };
        double[] Can2Investment = { 70, 70, 70 };
        double[] Can1Enthusiasm = { 70, 70, 70 };
        double[] Can2Enthusiasm = { 70, 70, 70 };
        double[] BatchQuantity = { 50, 90, 70 };
        double[] BatchSpeed = { 90, 50, 70 };
        double[] Population = { 350000, 350000, 350000 };
        double[] MOE = { 3, 3, 3 };
        
        public void ClearVar()
        {
            ED = 3;
            RaceName = "US Presidential Election 2024 in Nebraska";
            ResetPVI();
            ResetCandidateQuality();
            ResetCandidateInvestment(); 
            ResetEnthusiasm();
            ResetMOE();
            ResetPopulation();
            ResetBatch();
            UpdateRuntimeCard();
        }

        public void ResetPVI()
        {
            List<double> PVI = new List<double>();
            PVI.Add(5.0); PVI.Add(15.0); PVI.Add(-5.0);
            AVGPVI = 0;
            foreach (double PVIindi in PVI)
            { AVGPVI += PVIindi; }
            AVGPVI /= (double)PVI.Count;
           
        }
        public void ResetCandidateQuality()
        {
            List<double> CQ1 = new List<double>();
            CQ1.Add(70.0); CQ1.Add(70.0); CQ1.Add(70.0);
            AVGCQ1 = 0;
            foreach (double CQ1indi in CQ1)
            { AVGCQ1 += CQ1indi; }
            AVGCQ1 /= (double)CQ1.Count;
            List<double> CQ2 = new List<double>();
            CQ2.Add(70.0); CQ2.Add(70.0); CQ2.Add(70.0);
            AVGCQ2 = 0;
            foreach (double CQ2indi in CQ2)
            { AVGCQ2 += CQ2indi; }
            AVGCQ2 /= (double)CQ2.Count;            
        }
        public void ResetCandidateInvestment()
        {
            List<double> CI1 = new List<double>();
            CI1.Add(70.0); CI1.Add(70.0); CI1.Add(70.0);
            AVGCI1 = 0;
            foreach (double CI1indi in CI1)
            { AVGCI1 += CI1indi; }
            AVGCI1 /= (double)CI1.Count;
            List<double> CI2 = new List<double>();
            CI2.Add(70.0); CI2.Add(70.0); CI2.Add(70.0);
            AVGCI2 = 0;
            foreach (double CI2indi in CI2)
            { AVGCI2 += CI2indi; }
            AVGCI2 /= (double)CI2.Count;
        }
        public void ResetEnthusiasm()
        {
            List<double> E1 = new List<double>();
            E1.Add(70.0); E1.Add(70.0); E1.Add(70.0);
            AVGE1 = 0;
            foreach (double E1indi in E1)
            { AVGE1 += E1indi; }
            AVGE1 /= (double)E1.Count;
            List<double> E2 = new List<double>();
            E2.Add(70.0); E2.Add(70.0); E2.Add(70.0);
            AVGE2 = 0;
            foreach (double E2indi in E2)
            { AVGE2 += E2indi; }
            AVGE2 /= (double)E2.Count;
        }
        public void ResetBatch()
        {
            List<double> BatchQI = new List<double>();
            BatchQI.Add(1); BatchQI.Add(1); BatchQI.Add(1);
            BatchQ = 0;
            foreach (double BatchQindi in BatchQI)
            { BatchQ += BatchQindi; }
            BatchQ /= (double)BatchQI.Count;
            UpdateRuntimeCard();
            List<double> BatchSI = new List<double>();
            BatchSI.Add(1); BatchSI.Add(1); BatchSI.Add(1);
            BatchS = 0;
            foreach (double BatchSindi in BatchSI)
            { BatchS += BatchSindi; }
            BatchS /= (double)BatchSI.Count;
            UpdateRuntimeCard();

        }
        public void ResetPopulation()
        {
            List<double> PopulationI = new List<double>();
            PopulationI.Add(350000); PopulationI.Add(350000); PopulationI.Add(350000);
            TotalPopulation = 0;
            foreach (double PopulationIndi in PopulationI)
            { TotalPopulation += PopulationIndi; }
            UpdateRuntimeCard();
        }
        public void ResetMOE()
        {
            List<double> MOEI = new List<double>();
            MOEI.Add(0.0); MOEI.Add(15.0); MOEI.Add(-15.0);
            AVGMOE = 0;
            foreach (double MOEindi in MOEI)
            { AVGMOE += MOEindi; }
            AVGMOE /= (double)MOEI.Count;
            UpdateRuntimeCard();
        }

        public void UpdateRuntimeCard()
        {
            RunConditionBox.Text = $"PVI:{AVGPVI}%\r\nCandidate Quality:{AVGCQ1}% - {AVGCQ2}%\r\nInvestment:{AVGCI1}% - {AVGCI2}%\r\n" +
                $"Enthusiasm:{AVGE1}% - {AVGE2}%\r\nBatch Quantity:{BatchQ}\r\nBatch Speed:{BatchS}\r\n" +
                $"Population:{TotalPopulation}\r\nMOE:{AVGMOE}%";
            StartSimSetup.Text = "Start";
        }

        private void StartSimSetup_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearVar();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
