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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.DistrictTitle = new System.Windows.Forms.TextBox();
            this.RaceTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TitleEn2 = new System.Windows.Forms.TextBox();
            this.TitleEn1 = new System.Windows.Forms.TextBox();
            this.TitleIV2 = new System.Windows.Forms.TextBox();
            this.TitleIV1 = new System.Windows.Forms.TextBox();
            this.titleCQ2 = new System.Windows.Forms.TextBox();
            this.TitleCQ1 = new System.Windows.Forms.TextBox();
            this.TitlePVI = new System.Windows.Forms.TextBox();
            this.titleED = new System.Windows.Forms.TextBox();
            this.TitleRandom = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livevotechart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            // 
            // RunConditionBox
            // 
            this.RunConditionBox.Location = new System.Drawing.Point(666, 46);
            this.RunConditionBox.Multiline = true;
            this.RunConditionBox.Name = "RunConditionBox";
            this.RunConditionBox.ReadOnly = true;
            this.RunConditionBox.Size = new System.Drawing.Size(474, 184);
            this.RunConditionBox.TabIndex = 12;
            // 
            // MassSIMBox
            // 
            this.MassSIMBox.Location = new System.Drawing.Point(666, 273);
            this.MassSIMBox.Multiline = true;
            this.MassSIMBox.Name = "MassSIMBox";
            this.MassSIMBox.ReadOnly = true;
            this.MassSIMBox.Size = new System.Drawing.Size(474, 230);
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
            this.MassSimLabel.Location = new System.Drawing.Point(739, 233);
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
            chartArea2.Name = "ChartArea1";
            this.livevotechart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.livevotechart.Legends.Add(legend2);
            this.livevotechart.Location = new System.Drawing.Point(12, 273);
            this.livevotechart.Name = "livevotechart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.livevotechart.Series.Add(series2);
            this.livevotechart.Size = new System.Drawing.Size(608, 326);
            this.livevotechart.TabIndex = 3;
            this.livevotechart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.DistrictTitle);
            this.tabPage2.Controls.Add(this.RaceTitle);
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1155, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Set Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(958, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(156, 32);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(350, 31);
            this.textBox9.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(868, 35);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(83, 31);
            this.textBox8.TabIndex = 3;
            // 
            // DistrictTitle
            // 
            this.DistrictTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DistrictTitle.Location = new System.Drawing.Point(690, 32);
            this.DistrictTitle.Multiline = true;
            this.DistrictTitle.Name = "DistrictTitle";
            this.DistrictTitle.Size = new System.Drawing.Size(172, 34);
            this.DistrictTitle.TabIndex = 2;
            this.DistrictTitle.Text = "Districts:";
            this.DistrictTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceTitle
            // 
            this.RaceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaceTitle.Location = new System.Drawing.Point(22, 32);
            this.RaceTitle.Multiline = true;
            this.RaceTitle.Name = "RaceTitle";
            this.RaceTitle.Size = new System.Drawing.Size(128, 34);
            this.RaceTitle.TabIndex = 1;
            this.RaceTitle.Text = "Race Title:";
            this.RaceTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 12;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.Controls.Add(this.textBox5, 10, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox3, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleEn2, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleEn1, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleIV2, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleIV1, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.titleCQ2, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleCQ1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitlePVI, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.titleED, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TitleRandom, 11, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox4, 9, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(19, 92);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89593F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.10407F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1118, 521);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Cambria", 8F);
            this.textBox5.Location = new System.Drawing.Point(938, 8);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox5.Size = new System.Drawing.Size(83, 51);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Population";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Cambria", 8F);
            this.textBox3.Location = new System.Drawing.Point(760, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(83, 51);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Batch Quant.";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleEn2
            // 
            this.TitleEn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleEn2.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleEn2.Location = new System.Drawing.Point(671, 8);
            this.TitleEn2.Multiline = true;
            this.TitleEn2.Name = "TitleEn2";
            this.TitleEn2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleEn2.Size = new System.Drawing.Size(83, 51);
            this.TitleEn2.TabIndex = 7;
            this.TitleEn2.Text = "Can2. Enthus.";
            this.TitleEn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleEn1
            // 
            this.TitleEn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleEn1.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleEn1.Location = new System.Drawing.Point(582, 8);
            this.TitleEn1.Multiline = true;
            this.TitleEn1.Name = "TitleEn1";
            this.TitleEn1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleEn1.Size = new System.Drawing.Size(83, 51);
            this.TitleEn1.TabIndex = 6;
            this.TitleEn1.Text = "Can1. Enthus.";
            this.TitleEn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleIV2
            // 
            this.TitleIV2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleIV2.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleIV2.Location = new System.Drawing.Point(493, 8);
            this.TitleIV2.Multiline = true;
            this.TitleIV2.Name = "TitleIV2";
            this.TitleIV2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleIV2.Size = new System.Drawing.Size(83, 51);
            this.TitleIV2.TabIndex = 5;
            this.TitleIV2.Text = "Can2. Investmt";
            this.TitleIV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleIV1
            // 
            this.TitleIV1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleIV1.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleIV1.Location = new System.Drawing.Point(404, 8);
            this.TitleIV1.Multiline = true;
            this.TitleIV1.Name = "TitleIV1";
            this.TitleIV1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleIV1.Size = new System.Drawing.Size(83, 51);
            this.TitleIV1.TabIndex = 4;
            this.TitleIV1.Text = "Can1. Investmt";
            this.TitleIV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleCQ2
            // 
            this.titleCQ2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleCQ2.Font = new System.Drawing.Font("Cambria", 8F);
            this.titleCQ2.Location = new System.Drawing.Point(315, 8);
            this.titleCQ2.Multiline = true;
            this.titleCQ2.Name = "titleCQ2";
            this.titleCQ2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.titleCQ2.Size = new System.Drawing.Size(83, 51);
            this.titleCQ2.TabIndex = 3;
            this.titleCQ2.Text = "Can2. Quality";
            this.titleCQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleCQ1
            // 
            this.TitleCQ1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleCQ1.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleCQ1.Location = new System.Drawing.Point(226, 8);
            this.TitleCQ1.Multiline = true;
            this.TitleCQ1.Name = "TitleCQ1";
            this.TitleCQ1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleCQ1.Size = new System.Drawing.Size(83, 51);
            this.TitleCQ1.TabIndex = 2;
            this.TitleCQ1.Text = "Can1. Quality";
            this.TitleCQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitlePVI
            // 
            this.TitlePVI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitlePVI.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitlePVI.Location = new System.Drawing.Point(137, 8);
            this.TitlePVI.Multiline = true;
            this.TitlePVI.Name = "TitlePVI";
            this.TitlePVI.Size = new System.Drawing.Size(83, 51);
            this.TitlePVI.TabIndex = 1;
            this.TitlePVI.Text = "PVI";
            this.TitlePVI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleED
            // 
            this.titleED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleED.Location = new System.Drawing.Point(3, 8);
            this.titleED.Multiline = true;
            this.titleED.Name = "titleED";
            this.titleED.Size = new System.Drawing.Size(128, 51);
            this.titleED.TabIndex = 0;
            this.titleED.Text = "Electoral District";
            this.titleED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleRandom
            // 
            this.TitleRandom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleRandom.Font = new System.Drawing.Font("Cambria", 8F);
            this.TitleRandom.Location = new System.Drawing.Point(1027, 8);
            this.TitleRandom.Multiline = true;
            this.TitleRandom.Name = "TitleRandom";
            this.TitleRandom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleRandom.Size = new System.Drawing.Size(88, 51);
            this.TitleRandom.TabIndex = 11;
            this.TitleRandom.Text = "Random (MOE)";
            this.TitleRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Cambria", 8F);
            this.textBox4.Location = new System.Drawing.Point(849, 8);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(83, 51);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Batch Speed";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 690);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livevotechart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox TitleCQ1;
        private System.Windows.Forms.TextBox TitlePVI;
        private System.Windows.Forms.TextBox titleED;
        private System.Windows.Forms.TextBox titleCQ2;
        private System.Windows.Forms.TextBox TitleEn2;
        private System.Windows.Forms.TextBox TitleEn1;
        private System.Windows.Forms.TextBox TitleIV2;
        private System.Windows.Forms.TextBox TitleIV1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TitleRandom;
        private System.Windows.Forms.TextBox RaceTitle;
        private System.Windows.Forms.TextBox DistrictTitle;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label ElectionTime;
        private System.Windows.Forms.Button ResetSimup;
        private System.Windows.Forms.Button StartSimSetup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

