using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormappTest
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // 設定ChartArea
            ChartArea chtArea = new ChartArea("ViewArea");
            chtArea.AxisX.Minimum = 0; //X軸數值從0開始
            chtArea.AxisX.ScaleView.Size = 105;
            chtArea.AxisX.Interval = 25;
            chtArea.AxisY.Interval = 0;
            chtArea.AxisY.Minimum = 25;
            chtArea.AxisY.Maximum = -25;
            chtArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chtArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.None; //設定scrollbar
            livevotechart.ChartAreas[0].InnerPlotPosition.X = 0;
            livevotechart.ChartAreas[0].InnerPlotPosition.Y = 0;
            livevotechart.ChartAreas[0] = chtArea;// chart new 出來時就有內建第一個chartarea


            // 設定 Timer

            clsTimer.Tick += new EventHandler(RefreshChart);
                clsTimer.Interval = (int)Stop;
                clsTimer.Stop();         
        }
        private void RefreshChart(object sender, EventArgs e)
        {
            // 新增一個點至Series中
            if (currentpctdiff < 0) 
            { 
                livevotechart.Series[0].Points.AddXY(actualin, currentpctdiff);
                DataPoint Last = livevotechart.Series[0].Points.Last();
                livevotechart.Series[0].Points[livevotechart.Series[0].Points.IndexOf(Last)].Color = Color.Blue;
            }
            if (currentpctdiff >= 0)
            {
                livevotechart.Series[0].Points.AddXY(actualin, currentpctdiff);
                DataPoint Last = livevotechart.Series[0].Points.Last();
                livevotechart.Series[0].Points[livevotechart.Series[0].Points.IndexOf(Last)].Color = Color.Red;
            }
            livevotechart.Series[0].Points.AddXY(actualin, currentpctdiff);
        }
        Timer clsTimer = new Timer();
        public static int ED = 3;
        string RaceName;
        string varCan1name = "Donald Trump";
        string varCan2name = "Joe Biden";
        decimal AVGPVI = 0M;
        decimal AVGCQ1 = 70M;
        decimal AVGCQ2 = 70M;
        decimal AVGCI1 = 70M;
        decimal AVGCI2 = 70M;
        decimal AVGE1 = 70M;
        decimal AVGE2 = 70M;
        decimal BatchQ =1M;
        decimal BatchS = 1M;
        decimal TotalPopulation = 1050000M;
        decimal AVGMOE = 2M;
        decimal QIRatio = 0.6M;
        decimal actualin = 0M;
        decimal VTP = 1.0M;
        double BatchVariety = 1.0;
        static decimal RUNTIME = 100000;
        public decimal Stop = 1000;
        decimal timeelapsed = 0M;
        List<string> DName = new List<string>();
        List<decimal> PVI = new List<decimal>();
        List<decimal> CQ1 = new List<decimal>();
        List<decimal> CQ2 = new List<decimal>();
        List<decimal> CI1 = new List<decimal>();
        List<decimal> E1 = new List<decimal>();
        List<decimal> E2 = new List<decimal>();
        List<decimal> CI2 = new List<decimal>();
        List<decimal> BatchQI = new List<decimal>();
        List<decimal> BatchSI = new List<decimal>();
        List<decimal> PopulationI = new List<decimal>();
        List<decimal> MOEI = new List<decimal>();
        List<decimal> VOTEBATCH1 = new List<decimal>();
        List<decimal> VOTEBATCH2 = new List<decimal>();
        decimal massavg = 0;
        decimal[] inpct1 = new decimal[1000];
        decimal[] inpct2 = new decimal[1000];
        decimal[] inpct = new decimal[1000];
        decimal[] invote1 = new decimal[1000];
        decimal[] invote2 = new decimal[1000];
        decimal[] votepct1 = new decimal[1000];
        decimal[] votepct2 = new decimal[1000];
        decimal currentpctdiff = 0M;

        
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
            AVGPVI = 0M;
            PVI.Add(0.0M); PVI.Add(0.0M); PVI.Add(0.0M);
        }
        public void ResetCandidateQuality()
        {
            CQ1.Clear();
            AVGCQ1 = 70M;
            CQ1.Add(70.0M); CQ1.Add(70.0M); CQ1.Add(70.0M);
            CQ2.Clear();
            AVGCQ2 = 70;
            CQ2.Add(70.0M); CQ2.Add(70.0M); CQ2.Add(70.0M);         
        }
        public void ResetCandidateInvestment()
        {
            CI1.Clear();
            AVGCI1 = 70M;
            CI1.Add(70.0M); CI1.Add(70.0M); CI1.Add(70.0M);
            CI2.Clear();
            AVGCI2 = 70.0M;
            CI2.Add(70.0M); CI2.Add(70.0M); CI2.Add(70.0M);
        }
        public void ResetEnthusiasm()
        {
            E1.Clear();
            AVGE1 = 70M;
            E1.Add(70.0M); E1.Add(70.0M); E1.Add(70.0M);
            E2.Clear();
            AVGE2 = 70M;
            E2.Add(70.0M); E2.Add(70.0M); E2.Add(70.0M);
        }
        public void ResetBatch()
        {
            BatchQI.Clear();
            BatchQ = 1M;
            BatchQI.Add(1M); BatchQI.Add(1M); BatchQI.Add(1M);
            BatchSI.Clear();
            BatchS = 1M;
            BatchSI.Add(1M); BatchSI.Add(1M); BatchSI.Add(1M);
        }
        public void ResetPopulation()
        {
            PopulationI.Clear();
            TotalPopulation = 1050000M;
            PopulationI.Add(350000M); PopulationI.Add(350000M); PopulationI.Add(350000M);
        }
        public void ResetMOE()
        {
            MOEI.Clear();
            AVGMOE = 2M;
            MOEI.Add(2.0M); MOEI.Add(2.0M); MOEI.Add(2.0M);
        }

        public void UpdateRuntimeCard()
        {
            AVGPVI = 0M;
            TotalPopulation = 0M;
            foreach (decimal PopulationIndi in PopulationI)
            { TotalPopulation += PopulationIndi; }
            AVGPVI = 0M;
            AVGCQ1 = 0M;
            AVGCQ2 = 0M;
            AVGCI1 = 0M;
            AVGCI2 = 0M;
            AVGE1 = 0M;
            AVGE2 = 0M;
            AVGMOE = 0M;
            BatchQ = 0M;
            BatchS = 0M;
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
            RunConditionBox.Text = $"PVI: {Math.Round(AVGPVI, 2, MidpointRounding.AwayFromZero)}%; Population: {Math.Round(TotalPopulation, 2, MidpointRounding.AwayFromZero)}\r\n\r\n===Ability===\r\nCan. Quality: {Math.Round(AVGCQ1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCQ2, 2, MidpointRounding.AwayFromZero)}%" +
                $"; Investment: {Math.Round(AVGCI1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGCI2, 2, MidpointRounding.AwayFromZero)}%" +
                $"; Enthusiasm: {Math.Round(AVGE1, 2, MidpointRounding.AwayFromZero)}% - {Math.Round(AVGE2, 2, MidpointRounding.AwayFromZero)}%\r\n\r\n===Vote Tally===\r\n" +
                $"Batch Quantity: {Math.Round(BatchQ, 2, MidpointRounding.AwayFromZero)}; Speed: {Math.Round(BatchS, 2, MidpointRounding.AwayFromZero)}; MOE: {Math.Round(AVGMOE, 2, MidpointRounding.AwayFromZero)}%\r\n";
             
            StartSimSetup.Text = "Start";
        }
        public void MassSimShow()
        {
            decimal m1 = Decimal.Round(quicksimarrayC1.Max(), 2);
            decimal m2 = Decimal.Round(quicksimarrayC2.Max(), 2);
            decimal l1 = Decimal.Round(quicksimarrayC1.Min(), 2);
            decimal l2 = Decimal.Round(quicksimarrayC2.Min(), 2);
            decimal avg1 = Decimal.Round(quicksimarrayC1.Average(), 2);
            decimal avg2 = Decimal.Round(quicksimarrayC2.Average(), 2);
            decimal sumOfSquaresOfDifferences1 = quicksimarrayC1.Select(val => (val - avg1) * (val - avg1)).Sum();
            decimal sumOfSquaresOfDifferences2 = quicksimarrayC2.Select(val => (val - avg2) * (val - avg2)).Sum();
            decimal sd1 = (decimal)Math.Sqrt((double)sumOfSquaresOfDifferences1 / quicksimarrayC1.Count());
            decimal sd2 = (decimal)Math.Sqrt((double)sumOfSquaresOfDifferences2 / quicksimarrayC2.Count());
            decimal lsd1 = Decimal.Round((decimal)avg1 - sd1, 2);
            decimal lsd2 = Decimal.Round((decimal)avg2 - sd2, 2);
            decimal hsd1 = Decimal.Round((decimal)avg1 + sd1, 2);
            decimal hsd2 = Decimal.Round((decimal)avg2 + sd2, 2);
            if (lsd1 > 100) lsd1 = 100M;
            if (lsd1 < 0) lsd1 = 0M;
            if (m1 > 100) m1 = 100M;
            if (m1 < 0) m1 = 0M;
            if (m2 > 100) m2 = 100M;
            if (m2 < 0) m2 = 0M;
            if (l1 > 100) l1 = 100M;
            if (l1 < 0) l1 = 0M;
            if (l2 > 100) l2 = 100M;
            if (l2 < 0) l2 = 0M;
            if (hsd1 < 0) hsd1 = 0M;
            if (hsd1 > 100) hsd1 = 100M;
            if (lsd2 > 100) lsd2 = 100M;
            if (lsd2 < 0) lsd2 = 0M;
            if (hsd2 < 0) hsd2 = 0M;
            if (hsd2 > 100) hsd2 = 100M;
            if (avg1 > 100) avg1 = 100M;
            if (avg1 < 0) avg1 = 0M;
            if (avg2 > 100) avg2 = 100M;
            if (avg2 < 0) avg2 = 0M;
            decimal[] temparrayforquicksim = new decimal[Convert.ToInt32(RUNTIME)];
            temparrayforquicksim = Array.FindAll(differences, j => j > 0).ToArray();
            decimal newlength = temparrayforquicksim.Count();
            decimal win = Decimal.Round(newlength / RUNTIME * 100, 3);
            MassSIMBox.Text = $"====Average====\r\n{varCan1name}: {Decimal.Round(avg1, 2)}%\r\n{varCan2name}: {Decimal.Round(avg2, 2)}%\r\n\r\n" +
                $"====Likely====\r\n{varCan1name}: {Decimal.Round(lsd1, 2)} ~ {Decimal.Round(hsd1, 2)}% ({l1}~{m1})\r\n{varCan2name}: {Decimal.Round(lsd2, 2)} ~ {Decimal.Round(hsd2, 2)}% ({l2}~{m2})" +
                $"\r\n\r\n{varCan1name} wins {win}% of times (n= {Convert.ToInt32(RUNTIME)}). \r\n";
            if (win > 97) {MassSIMBox.Text += $"Race Rating: Solid {varCan1name}"; }
            else if (win > 90) {MassSIMBox.Text += $"Race Rating: Likely {varCan1name}"; }
            else if (win > 80) { MassSIMBox.Text += $"Race Rating: Lean {varCan1name}"; }
            else if (win > 60) { MassSIMBox.Text += $"Race Rating: Tilt {varCan1name}"; }
            else if (win > 40) { MassSIMBox.Text += $"Race Rating: Toss Up"; }
            else if (win > 20) { MassSIMBox.Text += $"Race Rating: Tilt {varCan2name}"; }
            else if (win > 10) { MassSIMBox.Text += $"Race Rating: Lean {varCan2name}"; }
            else if (win > 3) { MassSIMBox.Text += $"Race Rating: Likely {varCan2name}"; }
            else { MassSIMBox.Text += $"Race Rating: Solid {varCan2name}"; }
            massavg = Decimal.Round(avg1, 2)- Decimal.Round(avg2, 2);
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
            Fillcontent();
        }

        public void Fillcontent()
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
            Textboxname.Dock = DockStyle.Fill;
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
                StartSimSetup.Text = "Tally";
                StartSimSetup.BackColor = Color.LightGreen;
                RunMassSim();
                MassSimShow();
            }
            else if (StartSimSetup.Text == "Tally")
            {
                RunQuickSim();
                StartSimSetup.Enabled = false;
                StartSimSetup.BackColor = Color.LightGray;
                livevotechart.ChartAreas[0].BackColor = Color.LightGray;
                livevotechart.ChartAreas[0].BackGradientStyle = GradientStyle.DiagonalRight;
                if (Math.Abs(massavg) > 60)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 100;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -100;
                }
                else if (Math.Abs(massavg) > 40)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 80;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -80;
                }
                else if (Math.Abs(massavg) > 32)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 70;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -70;
                }
                else if (Math.Abs(massavg) > 24)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 60;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -60;
                }
                else if (Math.Abs(massavg) > 16)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 50;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -50;
                }
                else if (Math.Abs(massavg) > 8)
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 40;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -40;
                }
                else
                {
                    livevotechart.ChartAreas[0].AxisY.Maximum = 30;
                    livevotechart.ChartAreas[0].AxisY.Minimum = -30;
                }
                livevotechart.ChartAreas[0].AxisY.Interval = 10;
                livevotechart.ChartAreas[0].InnerPlotPosition.X = 2;
                livevotechart.ChartAreas[0].InnerPlotPosition.Y = 0;
                TallyVote();
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
                    DName.Add("District "+i.ToString()); PVI.Add(0.0M); CQ1.Add(70.0M); CQ2.Add(70.0M); CI1.Add(70.0M); CI2.Add(70.0M); 
                    E1.Add(70.0M); E2.Add(70.0M); BatchSI.Add(1.0M); BatchQI.Add(1.0M); 
                    PopulationI.Add(350000M); MOEI.Add(2.0M); };
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
                            PVI[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 2:
                        {
                            CQ1[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 3:
                        {
                            CQ2[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 4:
                        {
                            CI1[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 5:
                        {
                            CI2[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 6:
                        {
                            E1[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 7:
                        {
                            E2[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 8:
                        {
                            BatchQI[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 9:
                        {
                            BatchSI[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 10:
                        {
                            PopulationI[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
                            break;
                        }
                    case 11:
                        {
                            MOEI[Math.DivRem(k, 12, out int case0) - 1] = Decimal.Parse(SetupTable.Controls.Find(k.ToString(), true)[0].Text);
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
        public decimal GetPVI(int District)
        {
            return PVI[District - 1];
        }
        public decimal GetCQ1(int District)
        {
            return CQ1[District - 1];
        }
        public decimal GetCQ2(int District)
        {
            return CQ2[District - 1];
        }
        public decimal GetCI1(int District)
        {
            return CI1[District - 1];
        }
        public decimal GetCI2(int District)
        {
            return CI2[District - 1];
        }
        public decimal GetE1(int District)
        {
            return E1[District - 1];
        }
        public decimal GetE2(int District)
        {
            return E2[District - 1];
        }
        public decimal GetMOE(int District)
        {
            return MOEI[District - 1];
        }
        public decimal GetVoters(int District)
        {
            return PopulationI[District - 1];
        }
        decimal[] quicksimarrayC1 = new decimal[Convert.ToInt32(RUNTIME)];
        decimal[] quicksimarrayC2 = new decimal[Convert.ToInt32(RUNTIME)];
        decimal[] differences = new decimal[Convert.ToInt32(RUNTIME)];
        Random rnd = new Random();
        decimal[] C1PCT = new decimal[1000];
        decimal[] C2PCT = new decimal[1000];
        decimal[] thirdPCT = new decimal[1000];
        decimal[] C1Vote = new decimal[1000];
        decimal[] C2Vote = new decimal[1000];
        public void RunMassSim()
        {
            for (int i =0; i< Convert.ToInt32(RUNTIME); i++)
            {
                decimal tempC1 = (decimal)((50 + (double)AVGPVI / 2) * (Math.Pow((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)AVGCQ1), 1 / ((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)AVGCI1)))));
                decimal tempC2 = (decimal)((50 - (double)AVGPVI / 2) * (Math.Pow((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)AVGCQ2), 1 / ((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)AVGCI2)))));
                decimal remainder = 100.0M - tempC1 - tempC2;
                decimal thirdPCT = (remainder) * (1M - (0.015M * AVGE1 - 0.5M)) * (1M - (0.015M * AVGE2 - 0.5M));
                decimal C1EntBonus = (remainder - thirdPCT) * (AVGE1 / (AVGE1 + AVGE2));
                decimal C2EntBonus = (remainder - thirdPCT) * (AVGE2 / (AVGE1 + AVGE2));
                tempC1 += C1EntBonus;
                tempC2 += C2EntBonus;
                double u1 = 1.0-rnd.NextDouble();
                double u2 = 1.0-rnd.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

                tempC1 += (AVGMOE * (decimal)randStdNormal);
                if (tempC1 < 0)
                {
                    tempC1 = 0M;
                }
                else
                if (tempC1 > 100)
                {                   
                    tempC1 = 100M;
                }

                u1 = 1.0-rnd.NextDouble();
                u2 = 1.0-rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

                tempC2 += (AVGMOE * (decimal)randStdNormal);
                if (tempC2 < 0)
                {
                    tempC2 = 0M;
                }
                else
                if (tempC2 > 100)
                {
                    tempC2 = 100M;
                }

                if (tempC1 + tempC2 > 100) 
                {
                    decimal originaltotal = tempC1 + tempC2;
                    tempC1 /= originaltotal;
                    tempC1 *= 100M;
                    tempC2 /= originaltotal;
                    tempC2 *= 100M;
                    thirdPCT = 0M;
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
                decimal tempC1 = (decimal)((50 + ((double)GetPVI(i + 1)) / 2) * (Math.Pow((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)GetCQ1(i + 1)), 1 / ((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)GetCI1(i + 1))))));
                decimal tempC2 = (decimal)((50 - ((double)GetPVI(i + 1)) / 2) * (Math.Pow((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)GetCQ2(i + 1)), 1 / ((double)QIRatio + (0.01 * (1 - (double)QIRatio) * (double)GetCI2(i + 1))))));
                decimal remainder = 100.0M - tempC1 - tempC2;
                thirdPCT[i] = (remainder) * (1M - (0.015M * GetE1(i + 1) - 0.5M)) * (1M - (0.015M * GetE2(i + 1) - 0.5M));
                decimal C1EntBonus = (remainder - thirdPCT[i]) * (GetE1(i + 1) / (GetE1(i + 1) + (GetE2(i + 1))));
                decimal C2EntBonus = (remainder - thirdPCT[i]) * (GetE2(i + 1) / (GetE1(i + 1) + (GetE2(i + 1))));
                tempC1 += C1EntBonus;
                tempC2 += C2EntBonus;
                double u1 = 1.0 - rnd.NextDouble();
                double u2 = 1.0 - rnd.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                tempC1 += (GetMOE(i + 1) * (decimal)randStdNormal);
                u1 = 1.0 - rnd.NextDouble();
                u2 = 1.0 - rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                tempC2 += (GetMOE(i + 1) * (decimal)randStdNormal);
                if (tempC1 + tempC2 > 100)
                {
                    decimal originaltotal = tempC1 + tempC2;
                    tempC1 /= originaltotal;
                    tempC1 *= 100M;
                    tempC2 /= originaltotal;
                    tempC2 *= 100M;
                    thirdPCT[i] = 0M;
                }
                C1PCT[i] = tempC1;
                C2PCT[i] = tempC2;
                //Total Vote
                u1 = 1.0 - rnd.NextDouble();
                u2 = 1.0 - rnd.NextDouble();
                randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                decimal C1VOTE = C1PCT[i] * 0.01M * GetVoters(i + 1) * 0.01M * GetE1(i + 1) * 0.01M * GetE2(i + 1) * (0.9825M + (0.035M * (decimal)randStdNormal));
                decimal C2VOTE = C2PCT[i] * 0.01M * GetVoters(i + 1) * 0.01M * GetE1(i + 1) * 0.01M * GetE2(i + 1) * (0.9825M + (0.035M * (decimal)randStdNormal));
                C1Vote[i] = Math.Ceiling(VTP*C1VOTE);
                C2Vote[i] = Math.Ceiling(VTP*C2VOTE);
            }
        }
        public decimal GetVote1(int district)
        {
            return C1Vote[district - 1];
        }
        public decimal GetVote2(int district)
        {
            return C2Vote[district - 1];
        }
        int finished = 0;
        public async void TallyVote()
        {
            clsTimer.Start();
            finished = 0;
            timeelapsed = 0;
            do
            {                
                for (int i = 0; i < ED; i++)
                {
                    if (timeelapsed< 100/BatchSI[i]) { }
                    else if (inpct1[i] == 100M && inpct2[i] == 100M) { }
                    else if (inpct1[i] >= 99.7M && inpct2[i] >= 99.7M)
                    {
                        LiveUpdate((decimal)i + 1M, 0.1M * BatchQI[i], 0.25M * BatchQI[i], 0.1M * BatchQI[i], 0.25M * BatchQI[i]);
                        finished++;
                        inpct1[i] = 100.0M;
                        inpct2[i] = 100.0M;
                        inpct[i] = 100.0M;
                    }
                    else if (inpct1[i] >= 99.7M && inpct2[i] < 99.7M) { LiveUpdate((decimal)i + 1M, 0.02M * BatchQI[i], 0.05M * BatchQI[i], 0.2M * BatchQI[i], 0.5M * BatchQI[i]); }
                    else if (inpct1[i] < 99.7M && inpct2[i] >= 99.7M) { LiveUpdate((decimal)i + 1M, 0.2M * BatchQI[i], 0.5M * BatchQI[i], 0.02M * BatchQI[i], 0.05M * BatchQI[i]); }
                    else if (inpct1[i] >= 90.0M && inpct2[i] >= 90.0M) { LiveUpdate((decimal)i + 1M, 0.1M * BatchQI[i], 0.25M * BatchQI[i], 0.1M * BatchQI[i], 0.25M * BatchQI[i]); }
                    else if (inpct1[i] >= 90.0M && inpct2[i] < 90.0M) { LiveUpdate((decimal)i + 1M, 0.1M * BatchQI[i], 0.25M * BatchQI[i], 0.2M * BatchQI[i], 0.5M * BatchQI[i]); }
                    else if (inpct1[i] < 90.0M && inpct2[i] >= 90.0M) { LiveUpdate((decimal)i + 1M, 0.2M * BatchQI[i], 0.5M * BatchQI[i], 0.1M * BatchQI[i], 0.25M * BatchQI[i]); }
                    else { LiveUpdate((decimal)i + 1M, 0.2M * BatchQI[i], 0.5M * BatchQI[i], 0.2M * BatchQI[i], 0.5M * BatchQI[i]); }
                }
                Can1Votes.Text = String.Format("{0:n0}", invote1.Sum());
                Can2Votes.Text = String.Format("{0:n0}", invote2.Sum());
                if (invote1.Sum() + invote2.Sum() == 0) 
                { Can1PCT.Text = "--.-%";
                    Can2PCT.Text = "--.-%";
                    currentpctdiff = 0;
                }
                else { Can1PCT.Text = String.Format("{0:0.00}", 100 * (invote1.Sum() / (invote1.Sum() + invote2.Sum()))) + "%";
                    Can2PCT.Text = String.Format("{0:0.00}", 100 * (invote2.Sum() / (invote1.Sum() + invote2.Sum()))) + "%";
                    currentpctdiff = Convert.ToDecimal(100 * (invote1.Sum() / (invote1.Sum() + invote2.Sum()))) - Convert.ToDecimal(100 * (invote2.Sum() / (invote1.Sum() + invote2.Sum())));
                }
                                   
               
                
                for (int i = 0; i<ED; i++)
                {
                    actualin += PopulationI[i] * inpct[i];
                }
                actualin /= PopulationI.Sum();
                INPCT.Text = "In: " + String.Format("{0:0.00}", actualin) + "%";
                timeelapsed += 1;
                ElectionTime.Text = ShowTime(timeelapsed.ToString());
                await Task.Delay((int)Stop);
            } 
            while (finished < ED);
        }
        public void LiveUpdate(decimal district, decimal lower1, decimal higher1, decimal lower2, decimal higher2)
        {
            Random LU = new Random();
            lower1 *= (decimal)(1/Math.Floor(Math.Sqrt(BatchVariety)));
            higher1 *= (decimal)(Math.Ceiling(Math.Sqrt(BatchVariety)));
            lower2 *= (decimal)(1 / Math.Floor(Math.Sqrt(BatchVariety)));
            higher2 *= (decimal)(Math.Ceiling(Math.Sqrt(BatchVariety)));
            if (lower1 >= higher1) { higher1 = lower1 + 0.01M; }
            if (lower2 >= higher2) { higher2 = lower2 + 0.01M; }
            double thisbatch1 = 0;
            double thisbatch2 = 0;
            double thisbatchvotes1 = 0;
            double thisbatchvotes2 = 0;
            thisbatch1 = 0.01* LU.Next((int)(100*lower1), (int)(100*higher1));
            thisbatch2 = 0.01* LU.Next((int)(100*lower2), (int)(100*higher2));
            inpct1[(int)district-1] += (decimal)thisbatch1;
            inpct2[(int)district-1] += (decimal)thisbatch2;
            thisbatchvotes1 = (double)GetVote1((int)district) * thisbatch1 *0.01;
            thisbatchvotes2 = (double)GetVote2((int)district) * thisbatch2 *0.01;
            invote1[(int)district-1] += (decimal)thisbatchvotes1;
            invote2[(int)district-1] += (decimal)thisbatchvotes2;
            votepct1[(int)district - 1] = (100 * invote1[(int)district - 1]) / (invote1[(int)district - 1] + invote2[(int)district - 1]);
            votepct2[(int)district - 1] = (100 * invote2[(int)district - 1]) / (invote1[(int)district - 1] + invote2[(int)district - 1]);
            inpct[(int)district-1] = 100* (invote1[(int)district-1] + invote2[(int)district-1]) / (GetVote1((int)district) + GetVote2((int)district));
        }
        public string ShowTime(string Timeelapsed)
        {
            decimal minute = 0;
            string returning = "0:00 ET";
            minute = Convert.ToDecimal(Timeelapsed) / 2M;
            if (minute < 59.5M) 
            { 
                if (minute < 9.5M) { returning = "19:0" + Math.Ceiling(minute) + " ET"; }
                else { returning = "19:" + (int)Math.Ceiling(minute) + " ET"; }
                return returning;
            }
            else if (minute < 299.5M) 
            {
                if (minute %60 == 0M || minute%60 == 59.5M) { returning = (Math.DivRem((int)minute, 60, out int result) + 19) + ":00 ET"; }
                else if (minute%60 < 9.5M) { returning = (Math.DivRem((int)minute, 60, out int result) + 19) + ":0" + Math.Ceiling(minute%60) + " ET"; }
                else { returning = (Math.DivRem((int)minute, 60, out int result) + 19) + ":" + (int)Math.Ceiling(minute%60) + " ET"; }
                return returning;
            }
            else 
            {
                if (minute % 60 == 0M || minute % 60 == 59.5M) { returning = (Math.DivRem((int)minute, 60, out int result) - 5) + ":00 ET"; }
                else if (minute % 60 < 9.5M) { returning = (Math.DivRem((int)minute, 60, out int result) -5) + ":0" + Math.Ceiling(minute%60) + " ET"; }
                else { returning = (Math.DivRem((int)minute, 60, out int result) - 5) + ":" + (int)Math.Ceiling(minute%60) + " ET"; }
                return returning;
            }
            

        }
        private void ResetSimup_Click(object sender, EventArgs e)
        {
            finished = ED;
            ClearTally();
            StartSimSetup.Text = "Start";
            StartSimSetup.BackColor = Color.MistyRose;
            StartSimSetup.Enabled = true;
        }
        public void ClearTally()
        {
            Array.Clear(inpct, 0, 1000);
            Array.Clear(inpct1, 0, 1000);
            Array.Clear(inpct2, 0, 1000);
            Array.Clear(invote1, 0, 1000);
            Array.Clear(invote2, 0, 1000);
            Array.Clear(votepct1, 0, 1000);
            Array.Clear(votepct2, 0, 1000);
            Can1Votes.Text = "0";
            Can2Votes.Text = "0";
            Can1PCT.Text = "0.00%";
            Can2PCT.Text = "0.00%";
            INPCT.Text = "In: 0.00%";
            clsTimer.Stop();
            livevotechart.Series[0].Points.Clear();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
           Stop = Convert.ToDecimal(IntervalBox.Text);
            clsTimer.Interval = Convert.ToInt32(IntervalBox.Text);
            INintervallabelcount.Text = "(" + IntervalBox.Text +"ms)";
        }

        private void VTPButton_Click(object sender, EventArgs e)
        {
            VTP = Convert.ToDecimal(VTPBox.Text);
            VTPlabelcount.Text = "(" + VTPBox.Text + ")";
        }

        private void btbbutton_Click(object sender, EventArgs e)
        {
            BatchVariety = Convert.ToDouble(btbbox.Text);
            Btblabelcount.Text = "(" + btbbox.Text + ")";
        }
    }
}
