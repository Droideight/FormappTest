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
        List<double> PVI = new List<double>();
        List<double> CQ1 = new List<double>();
        List<double> CQ2 = new List<double>();
        List<double> CI1 = new List<double>();
        List<double> E1 = new List<double>();
        List<double> E2 = new List<double>();
        List<double> CI2 = new List<double>();
        List<double> BatchQI = new List<double>();
        List<double> BatchSI = new List<double>();
        List<double> PopulationI = new List<double>();
        List<double> MOEI = new List<double>();


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
            SetupTableSize();
        }

        public void ResetPVI()
        {
            PVI.Clear();
            PVI.Add(5.0); PVI.Add(15.0); PVI.Add(-5.0);
            AVGPVI = 0;
            foreach (double PVIindi in PVI)
            { AVGPVI += PVIindi; }
            AVGPVI /= (double)PVI.Count;
        }
        public void ResetCandidateQuality()
        {
            CQ1.Clear();
            CQ1.Add(70.0); CQ1.Add(70.0); CQ1.Add(70.0);
            AVGCQ1 = 0;
            foreach (double CQ1indi in CQ1)
            { AVGCQ1 += CQ1indi; }
            AVGCQ1 /= (double)CQ1.Count;
            CQ2.Clear();
            CQ2.Add(70.0); CQ2.Add(70.0); CQ2.Add(70.0);
            AVGCQ2 = 0;
            foreach (double CQ2indi in CQ2)
            { AVGCQ2 += CQ2indi; }
            AVGCQ2 /= (double)CQ2.Count;            
        }
        public void ResetCandidateInvestment()
        {
            CI1.Clear();
            CI1.Add(70.0); CI1.Add(70.0); CI1.Add(70.0);
            AVGCI1 = 0;
            foreach (double CI1indi in CI1)
            { AVGCI1 += CI1indi; }
            AVGCI1 /= (double)CI1.Count;
            CI2.Clear();
            CI2.Add(70.0); CI2.Add(70.0); CI2.Add(70.0);
            AVGCI2 = 0;
            foreach (double CI2indi in CI2)
            { AVGCI2 += CI2indi; }
            AVGCI2 /= (double)CI2.Count;
        }
        public void ResetEnthusiasm()
        {
            E1.Clear();
            E1.Add(70.0); E1.Add(70.0); E1.Add(70.0);
            AVGE1 = 0;
            foreach (double E1indi in E1)
            { AVGE1 += E1indi; }
            AVGE1 /= (double)E1.Count;
            E2.Clear();
            E2.Add(70.0); E2.Add(70.0); E2.Add(70.0);
            AVGE2 = 0;
            foreach (double E2indi in E2)
            { AVGE2 += E2indi; }
            AVGE2 /= (double)E2.Count;
        }
        public void ResetBatch()
        {
            BatchQI.Clear();
            BatchQI.Add(1); BatchQI.Add(1); BatchQI.Add(1);
            BatchQ = 0;
            foreach (double BatchQindi in BatchQI)
            { BatchQ += BatchQindi; }
            BatchQ /= (double)BatchQI.Count;
            BatchSI.Clear();
            BatchSI.Add(1); BatchSI.Add(1); BatchSI.Add(1);
            BatchS = 0;
            foreach (double BatchSindi in BatchSI)
            { BatchS += BatchSindi; }
            BatchS /= (double)BatchSI.Count;

        }
        public void ResetPopulation()
        {
            PopulationI.Clear();
            PopulationI.Add(350000); PopulationI.Add(350000); PopulationI.Add(350000);
            TotalPopulation = 0;
            foreach (double PopulationIndi in PopulationI)
            { TotalPopulation += PopulationIndi; }
        }
        public void ResetMOE()
        {
            MOEI.Clear();
            MOEI.Add(0.0); MOEI.Add(15.0); MOEI.Add(-15.0);
            AVGMOE = 0;
            foreach (double MOEindi in MOEI)
            { AVGMOE += MOEindi; }
            AVGMOE /= (double)MOEI.Count;
        }

        public void UpdateRuntimeCard()
        {
            RunConditionBox.Text = $"PVI: {AVGPVI}%\r\nCandidate Quality: {AVGCQ1}% - {AVGCQ2}%\r\nInvestment: {AVGCI1}% - {AVGCI2}%\r\n" +
                $"Enthusiasm: {AVGE1}% - {AVGE2}%\r\nBatch Quantity: {BatchQ}\r\nBatch Speed: {BatchS}\r\n" +
                $"Population: {TotalPopulation}\r\nMOE: {AVGMOE}%";
            StartSimSetup.Text = "Start";
        }

        public void SetupTableSize()
        {
            SetupTable.RowCount = 1 + ED;
            SetupTable.RowStyles[0] = new RowStyle(SizeType.Absolute, 60);
            for (int i = 1; i<ED; i++)
            {
                SetupTable.RowStyles[i+1] = new RowStyle(SizeType.Absolute, 100);
            }
            for (int j = 12; j < (ED+1)*12; j++)
            {
                CloneTextBox(j);
            }
            for (int k = 12; k < (ED+1)*12; k++)
            {
                string textboxthing = "new";
                switch (Math.IEEERemainder(k, 12))
                {
                    case 0:
                        { break; }
                    case 1:
                        {
                            textboxthing = PVI[Math.DivRem(k, 12, out int case1) - 1].ToString();
                            break;
                        }
                    case 2:
                        {
                            textboxthing = CQ1[Math.DivRem(k, 12, out int case2) - 1].ToString();
                            break;
                        }
                    case 3:
                        {
                            textboxthing = CQ2[Math.DivRem(k, 12, out int case3) - 1].ToString();
                            break;
                        }
                    case 4:
                        {
                            textboxthing = CI1[Math.DivRem(k, 12, out int case4) - 1].ToString();
                            break;
                        }
                    case 5:
                        {
                            textboxthing = CI2[Math.DivRem(k, 12, out int case5) - 1].ToString();
                            break;
                        }
                    case 6:
                        {
                            textboxthing = E1[Math.DivRem(k, 12, out int case6) - 1].ToString();
                            break;
                        }
                    case 7:
                        {
                            textboxthing = E2[Math.DivRem(k, 12, out int case7) - 1].ToString();
                            break;
                        }
                    case 8:
                        {
                            textboxthing = BatchQI[Math.DivRem(k, 12, out int case8) - 1].ToString();
                            break;
                        }
                    case 9:
                        {
                            textboxthing = BatchSI[Math.DivRem(k, 12, out int case9) - 1].ToString();
                            break;
                        }
                    case 10:
                        {
                            textboxthing = PopulationI[Math.DivRem(k, 12, out int case10) - 1].ToString();
                            break;
                        }
                    case 11:
                        {
                            textboxthing = MOEI[Math.DivRem(k, 12, out int case11) - 1].ToString();
                            break;
                        }
                    default:
                        {
                            textboxthing = k.ToString();
                            break;
                        }
                }
                SetupTable.Controls.Find(k.ToString(), true)[0].Text = textboxthing;
            }
        }

        public TextBox CloneTextBox(int Textboxindex)
        {
          TextBox Textboxname = new TextBox();
            Textboxname.TabIndex = Textboxindex;
            Textboxname.Anchor = AnchorStyles.None;
            Textboxname.Enabled = false;
            Textboxname.Dock = DockStyle.None;
            Textboxname.Name = Textboxindex.ToString();
            SetupTable.Controls.Add(Textboxname);
          return Textboxname;
        }

        private void StartSimSetup_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearVar();
        }
    }

}
