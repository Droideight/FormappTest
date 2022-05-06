namespace FormappTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ElectionTime = new System.Windows.Forms.Label();
            this.ResetSimup = new System.Windows.Forms.Button();
            this.StartSimSetup = new System.Windows.Forms.Button();
            this.RunConditionBox = new System.Windows.Forms.TextBox();
            this.MassSIMBox = new System.Windows.Forms.TextBox();
            this.INPCT = new System.Windows.Forms.Label();
            this.MassSimLabel = new System.Windows.Forms.Label();
            this.RunConditionBanner = new System.Windows.Forms.Label();
            this.ElectionTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Can2PCT = new System.Windows.Forms.Label();
            this.Can2Votes = new System.Windows.Forms.Label();
            this.Can2Name = new System.Windows.Forms.Label();
            this.Can1Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Can1PCT = new System.Windows.Forms.Label();
            this.Can1Votes = new System.Windows.Forms.Label();
            this.livevotechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CAN2Button = new System.Windows.Forms.Button();
            this.Can2Box = new System.Windows.Forms.TextBox();
            this.Can1Button = new System.Windows.Forms.Button();
            this.Can1Box = new System.Windows.Forms.TextBox();
            this.Can2Title = new System.Windows.Forms.TextBox();
            this.Can1Title = new System.Windows.Forms.TextBox();
            this.DistrictButton = new System.Windows.Forms.Button();
            this.RaceTitleButton = new System.Windows.Forms.Button();
            this.RaceTitleBox = new System.Windows.Forms.TextBox();
            this.DistrictBox = new System.Windows.Forms.TextBox();
            this.DistrictTitle = new System.Windows.Forms.TextBox();
            this.RaceTitle = new System.Windows.Forms.TextBox();
            this.SetupTable = new System.Windows.Forms.TableLayoutPanel();
            this.EDT = new System.Windows.Forms.Label();
            this.PVIT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livevotechart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SetupTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.AccessibleName = "";
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Font = new System.Drawing.Font("Cambria", 12F);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1163, 666);
            this.Tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ElectionTime);
            this.tabPage1.Controls.Add(this.ResetSimup);
            this.tabPage1.Controls.Add(this.StartSimSetup);
            this.tabPage1.Controls.Add(this.RunConditionBox);
            this.tabPage1.Controls.Add(this.MassSIMBox);
            this.tabPage1.Controls.Add(this.INPCT);
            this.tabPage1.Controls.Add(this.MassSimLabel);
            this.tabPage1.Controls.Add(this.RunConditionBanner);
            this.tabPage1.Controls.Add(this.ElectionTitle);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.livevotechart);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Result";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ElectionTime
            // 
            this.ElectionTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ElectionTime.AutoSize = true;
            this.ElectionTime.Location = new System.Drawing.Point(1027, 510);
            this.ElectionTime.Name = "ElectionTime";
            this.ElectionTime.Size = new System.Drawing.Size(83, 23);
            this.ElectionTime.TabIndex = 15;
            this.ElectionTime.Text = "19:00ET";
            this.ElectionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetSimup
            // 
            this.ResetSimup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetSimup.BackColor = System.Drawing.Color.LightGray;
            this.ResetSimup.Font = new System.Drawing.Font("Cambria", 16F);
            this.ResetSimup.Location = new System.Drawing.Point(999, 553);
            this.ResetSimup.Name = "ResetSimup";
            this.ResetSimup.Size = new System.Drawing.Size(141, 45);
            this.ResetSimup.TabIndex = 14;
            this.ResetSimup.Text = "Reset";
            this.ResetSimup.UseVisualStyleBackColor = false;
            // 
            // StartSimSetup
            // 
            this.StartSimSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartSimSetup.BackColor = System.Drawing.Color.MistyRose;
            this.StartSimSetup.Font = new System.Drawing.Font("Cambria", 36F);
            this.StartSimSetup.Location = new System.Drawing.Point(666, 510);
            this.StartSimSetup.Name = "StartSimSetup";
            this.StartSimSetup.Size = new System.Drawing.Size(327, 89);
            this.StartSimSetup.TabIndex = 13;
            this.StartSimSetup.Text = "Start";
            this.StartSimSetup.UseVisualStyleBackColor = false;
            this.StartSimSetup.Click += new System.EventHandler(this.StartSimSetup_Click);
            // 
            // RunConditionBox
            // 
            this.RunConditionBox.Location = new System.Drawing.Point(666, 46);
            this.RunConditionBox.Multiline = true;
            this.RunConditionBox.Name = "RunConditionBox";
            this.RunConditionBox.ReadOnly = true;
            this.RunConditionBox.Size = new System.Drawing.Size(474, 229);
            this.RunConditionBox.TabIndex = 12;
            // 
            // MassSIMBox
            // 
            this.MassSIMBox.Location = new System.Drawing.Point(666, 311);
            this.MassSIMBox.Multiline = true;
            this.MassSIMBox.Name = "MassSIMBox";
            this.MassSIMBox.ReadOnly = true;
            this.MassSIMBox.Size = new System.Drawing.Size(474, 192);
            this.MassSIMBox.TabIndex = 11;
            // 
            // INPCT
            // 
            this.INPCT.AutoSize = true;
            this.INPCT.Font = new System.Drawing.Font("Cambria", 10F);
            this.INPCT.Location = new System.Drawing.Point(532, 233);
            this.INPCT.Name = "INPCT";
            this.INPCT.Size = new System.Drawing.Size(77, 20);
            this.INPCT.TabIndex = 10;
            this.INPCT.Text = "In: 0.00%";
            // 
            // MassSimLabel
            // 
            this.MassSimLabel.Font = new System.Drawing.Font("Cambria", 18F);
            this.MassSimLabel.Location = new System.Drawing.Point(748, 278);
            this.MassSimLabel.Name = "MassSimLabel";
            this.MassSimLabel.Size = new System.Drawing.Size(339, 30);
            this.MassSimLabel.TabIndex = 8;
            this.MassSimLabel.Text = "Mass Simulation";
            this.MassSimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunConditionBanner
            // 
            this.RunConditionBanner.Font = new System.Drawing.Font("Cambria", 18F);
            this.RunConditionBanner.Location = new System.Drawing.Point(660, 13);
            this.RunConditionBanner.Name = "RunConditionBanner";
            this.RunConditionBanner.Size = new System.Drawing.Size(489, 30);
            this.RunConditionBanner.TabIndex = 7;
            this.RunConditionBanner.Text = "Run Condition";
            this.RunConditionBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElectionTitle
            // 
            this.ElectionTitle.Font = new System.Drawing.Font("Cambria", 18F);
            this.ElectionTitle.Location = new System.Drawing.Point(3, 13);
            this.ElectionTitle.Name = "ElectionTitle";
            this.ElectionTitle.Size = new System.Drawing.Size(599, 30);
            this.ElectionTitle.TabIndex = 6;
            this.ElectionTitle.Text = "Live Result";
            this.ElectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.14638F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.85362F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Can2Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Can1Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 184);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel3.Controls.Add(this.Can2PCT, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Can2Votes, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(279, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.02469F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 81);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Can2PCT
            // 
            this.Can2PCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Can2PCT.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.Can2PCT.Location = new System.Drawing.Point(11, 47);
            this.Can2PCT.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2PCT.Name = "Can2PCT";
            this.Can2PCT.Size = new System.Drawing.Size(293, 34);
            this.Can2PCT.TabIndex = 3;
            this.Can2PCT.Text = "0.00%";
            this.Can2PCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can2Votes
            // 
            this.Can2Votes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Can2Votes.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can2Votes.Location = new System.Drawing.Point(11, 0);
            this.Can2Votes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2Votes.Name = "Can2Votes";
            this.Can2Votes.Size = new System.Drawing.Size(293, 47);
            this.Can2Votes.TabIndex = 2;
            this.Can2Votes.Text = "0";
            this.Can2Votes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can2Name
            // 
            this.Can2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can2Name.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can2Name.Location = new System.Drawing.Point(5, 93);
            this.Can2Name.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2Name.Name = "Can2Name";
            this.Can2Name.Size = new System.Drawing.Size(263, 88);
            this.Can2Name.TabIndex = 1;
            this.Can2Name.Text = "Joe Biden";
            this.Can2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Can1Name
            // 
            this.Can1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can1Name.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can1Name.Location = new System.Drawing.Point(5, 3);
            this.Can1Name.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1Name.Name = "Can1Name";
            this.Can1Name.Size = new System.Drawing.Size(263, 87);
            this.Can1Name.TabIndex = 0;
            this.Can1Name.Text = "Donald Trump";
            this.Can1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel2.Controls.Add(this.Can1PCT, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Can1Votes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(279, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.02469F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 81);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Can1PCT
            // 
            this.Can1PCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Can1PCT.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.Can1PCT.Location = new System.Drawing.Point(11, 47);
            this.Can1PCT.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1PCT.Name = "Can1PCT";
            this.Can1PCT.Size = new System.Drawing.Size(293, 34);
            this.Can1PCT.TabIndex = 4;
            this.Can1PCT.Text = "0.00%";
            this.Can1PCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can1Votes
            // 
            this.Can1Votes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Can1Votes.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can1Votes.Location = new System.Drawing.Point(11, 0);
            this.Can1Votes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1Votes.Name = "Can1Votes";
            this.Can1Votes.Size = new System.Drawing.Size(293, 47);
            this.Can1Votes.TabIndex = 3;
            this.Can1Votes.Text = "0";
            this.Can1Votes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // livevotechart
            // 
            chartArea1.Name = "ChartArea1";
            this.livevotechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.livevotechart.Legends.Add(legend1);
            this.livevotechart.Location = new System.Drawing.Point(12, 273);
            this.livevotechart.Name = "livevotechart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.livevotechart.Series.Add(series1);
            this.livevotechart.Size = new System.Drawing.Size(608, 326);
            this.livevotechart.TabIndex = 3;
            this.livevotechart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CAN2Button);
            this.tabPage2.Controls.Add(this.Can2Box);
            this.tabPage2.Controls.Add(this.Can1Button);
            this.tabPage2.Controls.Add(this.Can1Box);
            this.tabPage2.Controls.Add(this.Can2Title);
            this.tabPage2.Controls.Add(this.Can1Title);
            this.tabPage2.Controls.Add(this.DistrictButton);
            this.tabPage2.Controls.Add(this.RaceTitleButton);
            this.tabPage2.Controls.Add(this.RaceTitleBox);
            this.tabPage2.Controls.Add(this.DistrictBox);
            this.tabPage2.Controls.Add(this.DistrictTitle);
            this.tabPage2.Controls.Add(this.RaceTitle);
            this.tabPage2.Controls.Add(this.SetupTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1155, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Set Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CAN2Button
            // 
            this.CAN2Button.Location = new System.Drawing.Point(1055, 82);
            this.CAN2Button.Name = "CAN2Button";
            this.CAN2Button.Size = new System.Drawing.Size(82, 34);
            this.CAN2Button.TabIndex = 12;
            this.CAN2Button.Text = "Enter";
            this.CAN2Button.UseVisualStyleBackColor = true;
            // 
            // Can2Box
            // 
            this.Can2Box.Location = new System.Drawing.Point(824, 82);
            this.Can2Box.Name = "Can2Box";
            this.Can2Box.Size = new System.Drawing.Size(225, 31);
            this.Can2Box.TabIndex = 11;
            // 
            // Can1Button
            // 
            this.Can1Button.Location = new System.Drawing.Point(512, 82);
            this.Can1Button.Name = "Can1Button";
            this.Can1Button.Size = new System.Drawing.Size(82, 34);
            this.Can1Button.TabIndex = 10;
            this.Can1Button.Text = "Enter";
            this.Can1Button.UseVisualStyleBackColor = true;
            // 
            // Can1Box
            // 
            this.Can1Box.Location = new System.Drawing.Point(245, 82);
            this.Can1Box.Name = "Can1Box";
            this.Can1Box.Size = new System.Drawing.Size(261, 31);
            this.Can1Box.TabIndex = 9;
            // 
            // Can2Title
            // 
            this.Can2Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can2Title.Enabled = false;
            this.Can2Title.Location = new System.Drawing.Point(601, 82);
            this.Can2Title.Multiline = true;
            this.Can2Title.Name = "Can2Title";
            this.Can2Title.Size = new System.Drawing.Size(217, 34);
            this.Can2Title.TabIndex = 8;
            this.Can2Title.Text = "Candidate 2 Name:";
            this.Can2Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Can1Title
            // 
            this.Can1Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can1Title.Enabled = false;
            this.Can1Title.Location = new System.Drawing.Point(22, 82);
            this.Can1Title.Multiline = true;
            this.Can1Title.Name = "Can1Title";
            this.Can1Title.Size = new System.Drawing.Size(217, 34);
            this.Can1Title.TabIndex = 7;
            this.Can1Title.Text = "Candidate 1 Name:";
            this.Can1Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DistrictButton
            // 
            this.DistrictButton.Location = new System.Drawing.Point(1055, 32);
            this.DistrictButton.Name = "DistrictButton";
            this.DistrictButton.Size = new System.Drawing.Size(82, 34);
            this.DistrictButton.TabIndex = 6;
            this.DistrictButton.Text = "Enter";
            this.DistrictButton.UseVisualStyleBackColor = true;
            // 
            // RaceTitleButton
            // 
            this.RaceTitleButton.Location = new System.Drawing.Point(513, 32);
            this.RaceTitleButton.Name = "RaceTitleButton";
            this.RaceTitleButton.Size = new System.Drawing.Size(82, 34);
            this.RaceTitleButton.TabIndex = 5;
            this.RaceTitleButton.Text = "Enter";
            this.RaceTitleButton.UseVisualStyleBackColor = true;
            // 
            // RaceTitleBox
            // 
            this.RaceTitleBox.Location = new System.Drawing.Point(245, 32);
            this.RaceTitleBox.Name = "RaceTitleBox";
            this.RaceTitleBox.Size = new System.Drawing.Size(261, 31);
            this.RaceTitleBox.TabIndex = 4;
            // 
            // DistrictBox
            // 
            this.DistrictBox.Location = new System.Drawing.Point(824, 32);
            this.DistrictBox.Name = "DistrictBox";
            this.DistrictBox.Size = new System.Drawing.Size(225, 31);
            this.DistrictBox.TabIndex = 3;
            // 
            // DistrictTitle
            // 
            this.DistrictTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DistrictTitle.Enabled = false;
            this.DistrictTitle.Location = new System.Drawing.Point(601, 32);
            this.DistrictTitle.Multiline = true;
            this.DistrictTitle.Name = "DistrictTitle";
            this.DistrictTitle.Size = new System.Drawing.Size(217, 34);
            this.DistrictTitle.TabIndex = 2;
            this.DistrictTitle.Text = "Districts:";
            this.DistrictTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceTitle
            // 
            this.RaceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaceTitle.Enabled = false;
            this.RaceTitle.Location = new System.Drawing.Point(22, 32);
            this.RaceTitle.Multiline = true;
            this.RaceTitle.Name = "RaceTitle";
            this.RaceTitle.Size = new System.Drawing.Size(217, 34);
            this.RaceTitle.TabIndex = 1;
            this.RaceTitle.Text = "Race Title:";
            this.RaceTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetupTable
            // 
            this.SetupTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetupTable.AutoScroll = true;
            this.SetupTable.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.SetupTable.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.SetupTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetupTable.BackColor = System.Drawing.Color.LightGray;
            this.SetupTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SetupTable.ColumnCount = 12;
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SetupTable.Controls.Add(this.label10, 11, 0);
            this.SetupTable.Controls.Add(this.label9, 10, 0);
            this.SetupTable.Controls.Add(this.label8, 9, 0);
            this.SetupTable.Controls.Add(this.label7, 8, 0);
            this.SetupTable.Controls.Add(this.label6, 7, 0);
            this.SetupTable.Controls.Add(this.label5, 6, 0);
            this.SetupTable.Controls.Add(this.label4, 5, 0);
            this.SetupTable.Controls.Add(this.label3, 4, 0);
            this.SetupTable.Controls.Add(this.label2, 3, 0);
            this.SetupTable.Controls.Add(this.label1, 2, 0);
            this.SetupTable.Controls.Add(this.PVIT, 1, 0);
            this.SetupTable.Controls.Add(this.EDT, 0, 0);
            this.SetupTable.Location = new System.Drawing.Point(22, 134);
            this.SetupTable.Name = "SetupTable";
            this.SetupTable.RowCount = 4;
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.Size = new System.Drawing.Size(1115, 471);
            this.SetupTable.TabIndex = 0;
            // 
            // EDT
            // 
            this.EDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EDT.AutoSize = true;
            this.EDT.Location = new System.Drawing.Point(21, 8);
            this.EDT.Name = "EDT";
            this.EDT.Size = new System.Drawing.Size(91, 46);
            this.EDT.TabIndex = 0;
            this.EDT.Text = "Electoral District";
            // 
            // PVIT
            // 
            this.PVIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVIT.AutoSize = true;
            this.PVIT.Location = new System.Drawing.Point(158, 19);
            this.PVIT.Name = "PVIT";
            this.PVIT.Size = new System.Drawing.Size(39, 23);
            this.PVIT.TabIndex = 1;
            this.PVIT.Text = "PVI";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cand. Qua1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cand. Qua2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cand. Inv1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cand. Inv2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cand. Enthu1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cand. Enthu2";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 46);
            this.label7.TabIndex = 8;
            this.label7.Text = "Batch Qty";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 46);
            this.label8.TabIndex = 9;
            this.label8.Text = "Batch Speed";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(946, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Voters";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1043, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "MOE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 690);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livevotechart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.SetupTable.ResumeLayout(false);
            this.SetupTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label ElectionTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Can2PCT;
        private System.Windows.Forms.Label Can2Votes;
        private System.Windows.Forms.Label Can2Name;
        private System.Windows.Forms.Label Can1Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Can1PCT;
        private System.Windows.Forms.Label Can1Votes;
        private System.Windows.Forms.DataVisualization.Charting.Chart livevotechart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label RunConditionBanner;
        private System.Windows.Forms.Label MassSimLabel;
        private System.Windows.Forms.Label INPCT;
        private System.Windows.Forms.TextBox RunConditionBox;
        private System.Windows.Forms.TextBox MassSIMBox;
        private System.Windows.Forms.TableLayoutPanel SetupTable;
        private System.Windows.Forms.TextBox RaceTitle;
        private System.Windows.Forms.TextBox DistrictTitle;
        private System.Windows.Forms.TextBox RaceTitleBox;
        private System.Windows.Forms.TextBox DistrictBox;
        private System.Windows.Forms.Label ElectionTime;
        private System.Windows.Forms.Button ResetSimup;
        private System.Windows.Forms.Button StartSimSetup;
        private System.Windows.Forms.Button DistrictButton;
        private System.Windows.Forms.Button RaceTitleButton;
        private System.Windows.Forms.Button Can1Button;
        private System.Windows.Forms.TextBox Can1Box;
        private System.Windows.Forms.TextBox Can2Title;
        private System.Windows.Forms.TextBox Can1Title;
        private System.Windows.Forms.Button CAN2Button;
        private System.Windows.Forms.TextBox Can2Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PVIT;
        private System.Windows.Forms.Label EDT;
    }
}

