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
        public static int ED = 3;
        string RaceName;
        string varCan1name;
        string varCan2name;
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
        List<string> DName = new List<string>();
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
            ResetDName();
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
        public void ResetDName()
        {
            DName.Clear();
            DName.Add("District 1"); DName.Add("District 2"); DName.Add("District 3");
        }

        public void ResetPVI()
        {
            PVI.Clear();
            PVI.Add(0.0); PVI.Add(0.0); PVI.Add(0.0);
        }
        public void ResetCandidateQuality()
        {
            CQ1.Clear();
            CQ1.Add(70.0); CQ1.Add(70.0); CQ1.Add(70.0);
            CQ2.Clear();
            CQ2.Add(70.0); CQ2.Add(70.0); CQ2.Add(70.0);         
        }
        public void ResetCandidateInvestment()
        {
            CI1.Clear();
            CI1.Add(70.0); CI1.Add(70.0); CI1.Add(70.0);
            CI2.Clear();
            CI2.Add(70.0); CI2.Add(70.0); CI2.Add(70.0);
        }
        public void ResetEnthusiasm()
        {
            E1.Clear();
            E1.Add(70.0); E1.Add(70.0); E1.Add(70.0);
            E2.Clear();
            E2.Add(70.0); E2.Add(70.0); E2.Add(70.0);
        }
        public void ResetBatch()
        {
            BatchQI.Clear();
            BatchQI.Add(1); BatchQI.Add(1); BatchQI.Add(1);
            BatchSI.Clear();
            BatchSI.Add(1); BatchSI.Add(1); BatchSI.Add(1);
        }
        public void ResetPopulation()
        {
            PopulationI.Clear();
            PopulationI.Add(350000); PopulationI.Add(350000); PopulationI.Add(350000);
        }
        public void ResetMOE()
        {
            MOEI.Clear();
            MOEI.Add(2.0); MOEI.Add(2.0); MOEI.Add(2.0);
        }

        public void UpdateRuntimeCard()
        {
            AVGPVI = 0;
            foreach (double PVIindi in PVI)
            { AVGPVI += PVIindi; }
            AVGPVI /= (double)PVI.Count;
            AVGCQ1 = 0;
            foreach (double CQ1indi in CQ1)
            { AVGCQ1 += CQ1indi; }
            AVGCQ1 /= (double)CQ1.Count;
            AVGCQ2 = 0;
            foreach (double CQ2indi in CQ2)
            { AVGCQ2 += CQ2indi; }
            AVGCQ2 /= (double)CQ2.Count;
            AVGCI1 = 0;
            foreach (double CI1indi in CI1)
            { AVGCI1 += CI1indi; }
            AVGCI1 /= (double)CI1.Count;
            AVGCI2 = 0;
            foreach (double CI2indi in CI2)
            { AVGCI2 += CI2indi; }
            AVGCI2 /= (double)CI2.Count;
            AVGE1 = 0;
            foreach (double E1indi in E1)
            { AVGE1 += E1indi; }
            AVGE1 /= (double)E1.Count;
            AVGE2 = 0;
            foreach (double E2indi in E2)
            { AVGE2 += E2indi; }
            AVGE2 /= (double)E2.Count;
            BatchQ = 0;
            foreach (double BatchQindi in BatchQI)
            { BatchQ += BatchQindi; }
            BatchQ /= (double)BatchQI.Count;
            BatchS = 0;
            foreach (double BatchSindi in BatchSI)
            { BatchS += BatchSindi; }
            BatchS /= (double)BatchSI.Count;
            TotalPopulation = 0;
            foreach (double PopulationIndi in PopulationI)
            { TotalPopulation += PopulationIndi; }
            AVGMOE = 0;
            foreach (double MOEindi in MOEI)
            { AVGMOE += MOEindi; }
            AVGMOE /= (double)MOEI.Count;
            RunConditionBox.Text = $"PVI: {Math.Round(AVGPVI, 2, MidpointRounding.AwayFromZero)}%\r\nCandidate Quality: {Math.Round(AVGCQ1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCQ2, 2, MidpointRounding.AwayFromZero)}%\r\n" +
                $"Investment: {Math.Round(AVGCI1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCI2, 2, MidpointRounding.AwayFromZero)}%\r\n" +
                $"Enthusiasm: {Math.Round(AVGE1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGE2, 2, MidpointRounding.AwayFromZero)}%\r\n" +
                $"Batch Quantity: {Math.Round(BatchQ, 2, MidpointRounding.AwayFromZero)}\r\nBatch Speed: {Math.Round(BatchS, 2, MidpointRounding.AwayFromZero)}\r\n" +
                $"Population: {Math.Round(TotalPopulation, 2, MidpointRounding.AwayFromZero)}\r\nMOE: {Math.Round(AVGMOE, 2, MidpointRounding.AwayFromZero)}%";
            StartSimSetup.Text = "Start";
        }

        public void SetupTableSize()
        {
            SetupTable.Controls.Clear();
            SetupTable.RowCount = 1 + ED;
            SetupTable.RowStyles[0].Height = 50;
            for (int j = 0; j < 12; j++)
            {
                CloneLabel(j);
            }
            for (int i = 1; i<=ED; i++)
            {
                SetupTable.RowStyles[i] = new RowStyle(SizeType.Absolute, 100);
            }
            for (int j = 12; j < (ED+1)*12; j++)
            {
                CloneTextBox(j);
            }
            fillcontent();
        }

        public void fillcontent()
        {
            for (int k = 0; k <  12; k++)
            {
                switch (k)
                {
                    case 0:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Electoral District";
                            break; 
                        }
                    case 1:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "PVI";
                            break;
                        }
                    case 2:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Qua1";
                            break;
                        }
                    case 3:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Qua2";
                            break;
                        }
                    case 4:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Inv1";
                            break;
                        }
                    case 5:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Inv2";
                            break;
                        }
                    case 6:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Enthu1";
                            break;
                        }
                    case 7:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Can. Enthu2";
                            break;
                        }
                    case 8:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Batch Qty";
                            break;
                        }
                    case 9:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Batch Speed";
                            break;
                        }
                    case 10:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "Voters";
                            break;
                        }
                    case 11:
                        {
                            SetupTable.Controls.Find(k.ToString(), true)[0].Text = "MOE";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            for (int k = 12; k < (ED + 1) * 12; k++)
            {
                string textboxthing = "new";
                switch (k % 12)
                {
                    case 0:
                        {
                            textboxthing = DName[Math.DivRem(k, 12, out int case0) - 1].ToString();
                            break; }
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
            Textboxname.Anchor = AnchorStyles.Top;
            Textboxname.Enabled = false;
            Textboxname.Dock = DockStyle.None;
            Textboxname.Name = Textboxindex.ToString();
            SetupTable.Controls.Add(Textboxname);
            return Textboxname;
        }
        public Label CloneLabel(int Labelindex)
        {
            Label Labelname = new Label();
            Labelname.TabIndex = Labelindex;
            Labelname.Anchor = AnchorStyles.Top;
            Labelname.Dock = DockStyle.Fill;
            Labelname.Name = Labelindex.ToString();
            Labelname.AutoSize = false;
            SetupTable.Controls.Add(Labelname);
            return Labelname;
        }
        private void StartSimSetup_Click(object sender, EventArgs e)
        {
            if (StartSimSetup.Text == "Start")
            {
                StartSimSetup.Text = "Pause";
                StartSimSetup.BackColor = Color.LightGray;
                RunQuickSim();
                MassSIMBox.Text = ($"{GetVote1(1).ToString()} to {GetVote2(1).ToString()}");
            }
            else if (StartSimSetup.Text == "Pause")
            {
                StartSimSetup.Text = "Start";
                StartSimSetup.BackColor = Color.MistyRose;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearVar();
        }

        private void EditFormBTN_Click(object sender, EventArgs e)
        {
            if (EditFormBTN.Text == "Edit") 
            { 
                EditFormBTN.Text = "Lock";
                foreach (Control ctr in SetupTable.Controls) { ctr.Enabled = true; }
            }
            else if (EditFormBTN.Text == "Lock") 
            { 
                EditFormBTN.Text = "Edit";
                foreach (Control ctr in SetupTable.Controls) { ctr.Enabled = false; }
                SaveRuntimeConditions();
                UpdateRuntimeCard();
            }
        }
        private void DistrictButton_Click(object sender, EventArgs e)
        {
            ED = Convert.ToInt32(DistrictBox.Text);
            if (PVI.Count < ED) 
                { for (int i = PVI.Count + 1; i <= ED; i++) 
                    {
                    DName.Add("District "+i.ToString()); PVI.Add(0.0); CQ1.Add(70.0); CQ2.Add(70.0); CI1.Add(70.0); CI2.Add(70.0); 
                    E1.Add(70.0); E2.Add(70.0); BatchSI.Add(1.0); BatchQI.Add(1.0); 
                    PopulationI.Add(350000); MOEI.Add(2.0); };
            }
            if (PVI.Count > ED)
            {
                for (int i = PVI.Count - 1; i >= ED; i--)
                {
                    DName.RemoveAt(i); PVI.RemoveAt(i); CQ1.RemoveAt(i); CQ2.RemoveAt(i); CI1.RemoveAt(i); CI2.RemoveAt(i);
                    E1.RemoveAt(i); E2.RemoveAt(i); BatchSI.RemoveAt(i); BatchQI.RemoveAt(i);
                    PopulationI.RemoveAt(i); MOEI.RemoveAt(i);
                };
            }
            SetupTableSize();
            UpdateRuntimeCard();
        }
        public void SaveRuntimeConditions()
        {
            for (int k = 12; k < (ED + 1) * 12; k++)
            {
                switch (k % 12)
                {
                    case 0:
                        {
                            DName[Math.DivRem(k, 12, out int case0) - 1] = SetupTable.Controls.Find(k.ToString(), true)[0].Text;
                            break;
                        }
                    case 1:
                        {
                            PVI[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 2:
                        {
                            CQ1[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 3:
                        {
                            CQ2[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 4:
                        {
                            CI1[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 5:
                        {
                            CI2[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 6:
                        {
                            E1[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 7:
                        {
                            E2[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 8:
                        {
                            BatchQI[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 9:
                        {
                            BatchSI[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 10:
                        {
                            PopulationI[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 11:
                        {
                            MOEI[Math.DivRem(k, 12, out int case0) - 1] = Double.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void ResetSetUp_Click(object sender, EventArgs e)
        {
            ClearVar();
            DistrictBox.Text = "3";
        }

        private void RaceTitleButton_Click(object sender, EventArgs e)
        {
            RaceName = RaceTitleBox.Text;
            ElectionTitle.Text = RaceName;
        }

        private void Can1Button_Click(object sender, EventArgs e)
        {
            varCan1name = Can1Box.Text;
            Can1Name.Text = varCan1name;
        }

        private void CAN2Button_Click(object sender, EventArgs e)
        {
            varCan2name = Can2Box.Text;
            Can2Name.Text = varCan2name;
        }
        public double GetPVI(int District)
        {
            return PVI[District - 1];
        }
        public double GetCQ1(int District)
        {
            return CQ1[District - 1];
        }
        public double GetCQ2(int District)
        {
            return CQ2[District - 1];
        }
        public double GetCI1(int District)
        {
            return CI1[District - 1];
        }
        public double GetCI2(int District)
        {
            return CI2[District - 1];
        }
        public double GetE1(int District)
        {
            return E1[District - 1];
        }
        public double GetE2(int District)
        {
            return E2[District - 1];
        }
        public double GetMOE(int District)
        {
            return MOEI[District - 1];
        }
        public double GetVoters(int District)
        {
            return PopulationI[District - 1];
        }
        double[] quicksimarray = new double[10000];
        Random rnd = new Random();
        double[] C1PCT = new double[ED];
        double[] C2PCT = new double[ED];
        double[] thirdPCT = new double[ED];
        double[] C1Vote = new double[ED];
        double[] C2Vote = new double[ED];
        public void RunQuickSim()
        {
            for (int i = 0; i < ED; i++)
            {
                double tempC1 = (50 + (GetPVI(i + 1)) / 2) * (Math.Pow(0.3 + (0.007 * GetCQ1(i + 1)), 1 / (0.3 + (0.007 * GetCI1(i + 1)))));
                double tempC2 = (50 - (GetPVI(i + 1)) / 2) * (Math.Pow(0.3 + (0.007 * GetCQ2(i + 1)), 1 / (0.3 + (0.007 * GetCI2(i + 1)))));
                double remainder = 100.0 - tempC1 - tempC2;
                thirdPCT[i] = (remainder) * (1 - (0.015 * GetE1(i + 1) - 0.5)) * (1 - (0.015 * GetE2(i + 1) - 0.5));
                double C1EntBonus = (remainder - thirdPCT[i]) * (GetE1(i + 1) / (GetE1(i + 1) + (GetE2(i + 1))));
                double C2EntBonus = (remainder - thirdPCT[i]) * (GetE2(i + 1) / (GetE1(i + 1) + (GetE2(i + 1))));
                tempC1 += C1EntBonus;
                tempC2 += C2EntBonus;
                double u1 = 1.0 - rnd.NextDouble();
                double u2 = 1.0 - rnd.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                tempC1 += (GetMOE(i + 1) * randStdNormal);
                u1 = 1.0 - rnd.NextDouble();
                u2 = 1.0 - rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                tempC2 += (GetMOE(i + 1) * randStdNormal);
                C1PCT[i] = tempC1;
                C2PCT[i] = tempC2;
                //Total Vote
                u1 = 1.0 - rnd.NextDouble();
                u2 = 1.0 - rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                double C1VOTE = C1PCT[i] * 0.01 * GetVoters(i + 1) * 0.01 * GetE1(i + 1) * 0.01 * GetE2(i + 1) * (0.9825 + (0.035 * randStdNormal));
                double C2VOTE = C2PCT[i] * 0.01 * GetVoters(i + 1) * 0.01 * GetE1(i + 1) * 0.01 * GetE2(i + 1) * (0.9825 + (0.035 * randStdNormal));
                C1Vote[i] = Math.Ceiling(C1VOTE);
                C2Vote[i] = Math.Ceiling(C2VOTE);
            }
        }
        public double GetVote1(int district)
        {
            return C1Vote[district - 1];
        }
        public double GetVote2(int district)
        {
            return C2Vote[district - 1];
        }
    }
}
