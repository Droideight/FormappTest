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
        string varCan1name = "Donald Trump";
        string varCan2name = "Joe Biden";
        double AVGPVI = 0;
        double AVGCQ1 = 70;
        double AVGCQ2 = 70;
        double AVGCI1 = 70;
        double AVGCI2 = 70;
        double AVGE1 = 70;
        double AVGE2 = 70;
        double BatchQ =1;
        double BatchS =1;
        double TotalPopulation = 1050000;
        double AVGMOE = 2;
        double QIRatio = 0.55;
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
            RaceName = "Live Result";
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
            AVGPVI = 0;
            PVI.Add(0.0); PVI.Add(0.0); PVI.Add(0.0);
        }
        public void ResetCandidateQuality()
        {
            CQ1.Clear();
            AVGCQ1 = 70;
            CQ1.Add(70.0); CQ1.Add(70.0); CQ1.Add(70.0);
            CQ2.Clear();
            AVGCQ2 = 70;
            CQ2.Add(70.0); CQ2.Add(70.0); CQ2.Add(70.0);         
        }
        public void ResetCandidateInvestment()
        {
            CI1.Clear();
            AVGCI1 = 70;
            CI1.Add(70.0); CI1.Add(70.0); CI1.Add(70.0);
            CI2.Clear();
            AVGCI2 = 70;
            CI2.Add(70.0); CI2.Add(70.0); CI2.Add(70.0);
        }
        public void ResetEnthusiasm()
        {
            E1.Clear();
            AVGE1 = 70;
            E1.Add(70.0); E1.Add(70.0); E1.Add(70.0);
            E2.Clear();
            AVGE2 = 70;
            E2.Add(70.0); E2.Add(70.0); E2.Add(70.0);
        }
        public void ResetBatch()
        {
            BatchQI.Clear();
            BatchQ = 1;
            BatchQI.Add(1); BatchQI.Add(1); BatchQI.Add(1);
            BatchSI.Clear();
            BatchS = 1;
            BatchSI.Add(1); BatchSI.Add(1); BatchSI.Add(1);
        }
        public void ResetPopulation()
        {
            PopulationI.Clear();
            TotalPopulation = 1050000;
            PopulationI.Add(350000); PopulationI.Add(350000); PopulationI.Add(350000);
        }
        public void ResetMOE()
        {
            MOEI.Clear();
            AVGMOE = 2;
            MOEI.Add(2.0); MOEI.Add(2.0); MOEI.Add(2.0);
        }

        public void UpdateRuntimeCard()
        {
            AVGPVI = 0;
            TotalPopulation = 0;
            foreach (double PopulationIndi in PopulationI)
            { TotalPopulation += PopulationIndi; }
            AVGPVI = 0;
            AVGCQ1 = 0;
            AVGCQ2 = 0;
            AVGCI1 = 0;
            AVGCI2 = 0;
            AVGE1 = 0;
            AVGE2 = 0;
            AVGMOE = 0;
            BatchQ = 0;
            BatchS = 0;
            for (int i =0; i< PVI.Count; i++)
            {
                AVGPVI += (PVI[i] * PopulationI[i]/TotalPopulation);
            }
            for (int i = 0; i < CQ1.Count; i++)
            {
                AVGCQ1 += (CQ1[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < CQ2.Count; i++)
            {
                AVGCQ2 += (CQ2[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < CI1.Count; i++)
            {
                AVGCI1 += (CI1[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < CI2.Count; i++)
            {
                AVGCI2 += (CI2[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < E1.Count; i++)
            {
                AVGE1 += (E1[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < E2.Count; i++)
            {
                AVGE2 += (E2[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < BatchQI.Count; i++)
            {
                BatchQ += (BatchQI[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < BatchSI.Count; i++)
            {
                BatchS += (BatchSI[i] * PopulationI[i] / TotalPopulation);
            }
            for (int i = 0; i < MOEI.Count; i++)
            {
                AVGMOE += (MOEI[i] * PopulationI[i] / TotalPopulation);
            }
            RunConditionBox.Text = $"PVI: {Math.Round(AVGPVI, 2, MidpointRounding.AwayFromZero)}%; Population: {Math.Round(TotalPopulation, 2, MidpointRounding.AwayFromZero)};\r\n\r\n===Ability===\r\nQuality: {Math.Round(AVGCQ1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCQ2, 2, MidpointRounding.AwayFromZero)}%;" +
                $"\r\nInvestment: {Math.Round(AVGCI1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCI2, 2, MidpointRounding.AwayFromZero)}%\r\n" +
                $"Enthusiasm: {Math.Round(AVGE1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGE2, 2, MidpointRounding.AwayFromZero)}%\r\n\r\n===Vote Tally===\r\n" +
                $"Batch Quantity: {Math.Round(BatchQ, 2, MidpointRounding.AwayFromZero)}; Speed: {Math.Round(BatchS, 2, MidpointRounding.AwayFromZero)}; MOE: {Math.Round(AVGMOE, 2, MidpointRounding.AwayFromZero)}%\r\n";
             
            StartSimSetup.Text = "Start";
        }
        public void MassSimShow()
        {
            double m1 = Math.Round(quicksimarrayC1.Max(), 2);
            double m2 = Math.Round(quicksimarrayC2.Max(), 2);
            double l1 = Math.Round(quicksimarrayC1.Min(), 2);
            double l2 = Math.Round(quicksimarrayC2.Min(), 2);
            double avg1 = Math.Round(quicksimarrayC1.Average(), 2);
            double avg2 = Math.Round(quicksimarrayC2.Average(), 2);
            double sumOfSquaresOfDifferences1 = quicksimarrayC1.Select(val => (val - avg1) * (val - avg1)).Sum();
            double sumOfSquaresOfDifferences2 = quicksimarrayC2.Select(val => (val - avg2) * (val - avg2)).Sum();
            double sd1 = Math.Sqrt((double)sumOfSquaresOfDifferences1 / quicksimarrayC1.Length);
            double sd2 = Math.Sqrt((double)sumOfSquaresOfDifferences2 / quicksimarrayC2.Length);
            double lsd1 = Math.Round((double)avg1 - sd1, 2);
            double lsd2 = Math.Round((double)avg2 - sd2, 2);
            double hsd1 = Math.Round((double)avg1 + sd1, 2);
            double hsd2 = Math.Round((double)avg2 + sd2, 2);
            if (lsd1 > 100) lsd1 = 100;
            if (lsd1 < 0) lsd1 = 0;
            if (m1 > 100) m1 = 100;
            if (m1 < 0) m1 = 0;
            if (m2 > 100) m2 = 100;
            if (m2 < 0) m2 = 0;
            if (l1 > 100) l1 = 100;
            if (l1 < 0) l1 = 0;
            if (l2 > 100) l2 = 100;
            if (l2 < 0) l2 = 0;
            if (hsd1 < 0) hsd1 = 0;
            if (hsd1 > 100) hsd1 = 100;
            if (lsd2 > 100) lsd2 = 100;
            if (lsd2 < 0) lsd2 = 0;
            if (hsd2 < 0) hsd2 = 0;
            if (hsd2 > 100) hsd2 = 100;
            if (avg1 > 100) avg1 = 100;
            if (avg1 < 0) avg1 = 0;
            if (avg2 > 100) avg2 = 100;
            if (avg2 < 0) avg2 = 0;
            double original = differences.Count();
            double[] temparrayforquicksim = new double[100000];
            temparrayforquicksim = Array.FindAll(differences, j => j > 0).ToArray();
            double newlength = temparrayforquicksim.Count();
            double win = Math.Round(newlength / original * 100, 4);
            MassSIMBox.Text = $"====Average====\r\n{varCan1name}: {Math.Round(avg1, 2)}%\r\n{varCan2name}: {Math.Round(avg2, 2)}%\r\n\r\n" +
                $"====Likely====\r\n{varCan1name}: {Math.Round(lsd1, 2)} ~ {Math.Round(hsd1, 2)}% ({l1}~{m1})\r\n{varCan2name}: {Math.Round(lsd2, 2)} ~ {Math.Round(hsd2, 2)}% ({l2}~{m2})" +
                $"\r\n\r\n{varCan1name} wins {win}% of times (n=100K).";
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
                RunMassSim();
                MassSimShow();
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
        double[] quicksimarrayC1 = new double[100000];
        double[] quicksimarrayC2 = new double[100000];
        double[] differences = new double[100000];
        Random rnd = new Random();
        double[] C1PCT = new double[1000];
        double[] C2PCT = new double[1000];
        double[] thirdPCT = new double[1000];
        double[] C1Vote = new double[1000];
        double[] C2Vote = new double[1000];
        public void RunMassSim()
        {
            for (int i =0; i<100000; i++)
            {
                double tempC1 = ((50 + AVGPVI / 2) * (Math.Pow(QIRatio + (0.01 * (1 - QIRatio) * AVGCQ1), 1 / (QIRatio + (0.01 * (1 - QIRatio) * AVGCI1)))));
                double tempC2 = ((50 - AVGPVI / 2) * (Math.Pow(QIRatio + (0.01 * (1 - QIRatio) * AVGCQ2), 1 / (QIRatio + (0.01 * (1 - QIRatio) * AVGCI2)))));
                double remainder = 100.0 - tempC1 - tempC2;
                double thirdPCT = (remainder) * (1 - (0.015 * AVGE1 - 0.5)) * (1 - (0.015 * AVGE2 - 0.5));
                double C1EntBonus = (remainder - thirdPCT) * (AVGE1 / (AVGE1 + AVGE2));
                double C2EntBonus = (remainder - thirdPCT) * (AVGE2 / (AVGE1 + AVGE2));
                tempC1 += C1EntBonus;
                tempC2 += C2EntBonus;
                double u1 = 1.0 - rnd.NextDouble();
                double u2 = 1.0 - rnd.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                tempC1 += (AVGMOE * randStdNormal);
                u1 = 1.0 - rnd.NextDouble();
                u2 = 1.0 - rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                tempC2 += (AVGMOE * randStdNormal);
                if (tempC1 + tempC2 > 100) 
                { 
                    tempC1 /= (tempC1 + tempC2);
                    tempC1 *= 100;
                    tempC2 /= (tempC1 + tempC2);
                    tempC2 *= 100;
                    thirdPCT = 0;
                }
                quicksimarrayC1[i] = tempC1;
                quicksimarrayC2[i] = tempC2;
                differences[i] = tempC1- tempC2;
            }
            
        }
        public void RunQuickSim()
        {
            for (int i = 0; i < ED; i++)
            {
                double tempC1 = (50 + (GetPVI(i + 1)) / 2) * (Math.Pow(QIRatio + (0.01 * (1 - QIRatio) * GetCQ1(i + 1)), 1 / (QIRatio + (0.01 * (1 - QIRatio) * GetCI1(i + 1)))));
                double tempC2 = (50 - (GetPVI(i + 1)) / 2) * (Math.Pow(QIRatio + (0.01 * (1 - QIRatio) * GetCQ2(i + 1)), 1 / (QIRatio + (0.01 * (1 - QIRatio) * GetCI2(i + 1)))));
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
                if (tempC1 + tempC2 > 100)
                {
                    tempC1 /= (tempC1 + tempC2);
                    tempC1 *= 100;
                    tempC2 /= (tempC1 + tempC2);
                    tempC2 *= 100;
                    thirdPCT[i] = 0;
                }
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
