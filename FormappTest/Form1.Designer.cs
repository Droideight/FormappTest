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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ElectionTitle = new System.Windows.Forms.Label();
            this.ElectionTime = new System.Windows.Forms.Label();
            this.ResetSimup = new System.Windows.Forms.Button();
            this.StartSimSetup = new System.Windows.Forms.Button();
            this.RunConditionBox = new System.Windows.Forms.TextBox();
            this.MassSIMBox = new System.Windows.Forms.TextBox();
            this.INPCT = new System.Windows.Forms.Label();
            this.MassSimLabel = new System.Windows.Forms.Label();
            this.INFOBanner = new System.Windows.Forms.Label();
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
            this.ResetSetUp = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EditFormBTN = new System.Windows.Forms.Button();
            this.CAN2Button = new System.Windows.Forms.Button();
            this.Can2Box = new System.Windows.Forms.TextBox();
            this.Can1Button = new System.Windows.Forms.Button();
            this.Can1Box = new System.Windows.Forms.TextBox();
            this.DistrictButton = new System.Windows.Forms.Button();
            this.RaceTitleButton = new System.Windows.Forms.Button();
            this.RaceTitleBox = new System.Windows.Forms.TextBox();
            this.DistrictBox = new System.Windows.Forms.TextBox();
            this.SetupTable = new System.Windows.Forms.TableLayoutPanel();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livevotechart)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.Tab.Size = new System.Drawing.Size(1350, 720);
            this.Tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ElectionTitle);
            this.tabPage1.Controls.Add(this.ElectionTime);
            this.tabPage1.Controls.Add(this.ResetSimup);
            this.tabPage1.Controls.Add(this.StartSimSetup);
            this.tabPage1.Controls.Add(this.RunConditionBox);
            this.tabPage1.Controls.Add(this.MassSIMBox);
            this.tabPage1.Controls.Add(this.INPCT);
            this.tabPage1.Controls.Add(this.MassSimLabel);
            this.tabPage1.Controls.Add(this.INFOBanner);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.livevotechart);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Result";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ElectionTitle
            // 
            this.ElectionTitle.Font = new System.Drawing.Font("Cambria", 18F);
            this.ElectionTitle.Location = new System.Drawing.Point(18, 272);
            this.ElectionTitle.Name = "ElectionTitle";
            this.ElectionTitle.Size = new System.Drawing.Size(686, 43);
            this.ElectionTitle.TabIndex = 16;
            this.ElectionTitle.Text = "Live Result";
            this.ElectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElectionTime
            // 
            this.ElectionTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ElectionTime.AutoSize = true;
            this.ElectionTime.Location = new System.Drawing.Point(1198, 556);
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
            this.ResetSimup.Location = new System.Drawing.Point(1166, 600);
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
            this.StartSimSetup.Location = new System.Drawing.Point(760, 556);
            this.StartSimSetup.Name = "StartSimSetup";
            this.StartSimSetup.Size = new System.Drawing.Size(400, 89);
            this.StartSimSetup.TabIndex = 13;
            this.StartSimSetup.Text = "Start";
            this.StartSimSetup.UseVisualStyleBackColor = false;
            this.StartSimSetup.Click += new System.EventHandler(this.StartSimSetup_Click);
            // 
            // RunConditionBox
            // 
            this.RunConditionBox.Font = new System.Drawing.Font("Cambria", 11F);
            this.RunConditionBox.Location = new System.Drawing.Point(760, 46);
            this.RunConditionBox.Multiline = true;
            this.RunConditionBox.Name = "RunConditionBox";
            this.RunConditionBox.ReadOnly = true;
            this.RunConditionBox.Size = new System.Drawing.Size(547, 223);
            this.RunConditionBox.TabIndex = 12;
            // 
            // MassSIMBox
            // 
            this.MassSIMBox.Font = new System.Drawing.Font("Cambria", 11F);
            this.MassSIMBox.Location = new System.Drawing.Point(760, 328);
            this.MassSIMBox.Multiline = true;
            this.MassSIMBox.Name = "MassSIMBox";
            this.MassSIMBox.ReadOnly = true;
            this.MassSIMBox.Size = new System.Drawing.Size(547, 206);
            this.MassSIMBox.TabIndex = 11;
            // 
            // INPCT
            // 
            this.INPCT.AutoSize = true;
            this.INPCT.Font = new System.Drawing.Font("Cambria", 10F);
            this.INPCT.Location = new System.Drawing.Point(627, 23);
            this.INPCT.Name = "INPCT";
            this.INPCT.Size = new System.Drawing.Size(77, 20);
            this.INPCT.TabIndex = 10;
            this.INPCT.Text = "In: 0.00%";
            // 
            // MassSimLabel
            // 
            this.MassSimLabel.Font = new System.Drawing.Font("Cambria", 18F);
            this.MassSimLabel.Location = new System.Drawing.Point(754, 272);
            this.MassSimLabel.Name = "MassSimLabel";
            this.MassSimLabel.Size = new System.Drawing.Size(553, 43);
            this.MassSimLabel.TabIndex = 8;
            this.MassSimLabel.Text = "Mass Simulation";
            this.MassSimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INFOBanner
            // 
            this.INFOBanner.Font = new System.Drawing.Font("Cambria", 18F);
            this.INFOBanner.Location = new System.Drawing.Point(754, 7);
            this.INFOBanner.Name = "INFOBanner";
            this.INFOBanner.Size = new System.Drawing.Size(553, 43);
            this.INFOBanner.TabIndex = 7;
            this.INFOBanner.Text = "Info";
            this.INFOBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 223);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel3.Controls.Add(this.Can2PCT, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Can2Votes, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(311, 116);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.02469F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 101);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Can2PCT
            // 
            this.Can2PCT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Can2PCT.Font = new System.Drawing.Font("Cambria", 14F);
            this.Can2PCT.Location = new System.Drawing.Point(0, 62);
            this.Can2PCT.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2PCT.Name = "Can2PCT";
            this.Can2PCT.Size = new System.Drawing.Size(360, 34);
            this.Can2PCT.TabIndex = 3;
            this.Can2PCT.Text = "0.00%";
            this.Can2PCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can2Votes
            // 
            this.Can2Votes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Can2Votes.Font = new System.Drawing.Font("Cambria", 30F);
            this.Can2Votes.Location = new System.Drawing.Point(0, 5);
            this.Can2Votes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2Votes.Name = "Can2Votes";
            this.Can2Votes.Size = new System.Drawing.Size(360, 47);
            this.Can2Votes.TabIndex = 2;
            this.Can2Votes.Text = "0";
            this.Can2Votes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can2Name
            // 
            this.Can2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can2Name.Font = new System.Drawing.Font("Cambria", 28F);
            this.Can2Name.Location = new System.Drawing.Point(21, 122);
            this.Can2Name.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can2Name.Name = "Can2Name";
            this.Can2Name.Size = new System.Drawing.Size(263, 88);
            this.Can2Name.TabIndex = 1;
            this.Can2Name.Text = "Joe Biden";
            this.Can2Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Can1Name
            // 
            this.Can1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Can1Name.Font = new System.Drawing.Font("Cambria", 28F);
            this.Can1Name.Location = new System.Drawing.Point(21, 13);
            this.Can1Name.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1Name.Name = "Can1Name";
            this.Can1Name.Size = new System.Drawing.Size(263, 87);
            this.Can1Name.TabIndex = 0;
            this.Can1Name.Text = "Donald Trump";
            this.Can1Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel2.Controls.Add(this.Can1PCT, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Can1Votes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(311, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.02469F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 101);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Can1PCT
            // 
            this.Can1PCT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Can1PCT.Font = new System.Drawing.Font("Cambria", 14F);
            this.Can1PCT.Location = new System.Drawing.Point(0, 62);
            this.Can1PCT.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1PCT.Name = "Can1PCT";
            this.Can1PCT.Size = new System.Drawing.Size(360, 34);
            this.Can1PCT.TabIndex = 4;
            this.Can1PCT.Text = "0.00%";
            this.Can1PCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Can1Votes
            // 
            this.Can1Votes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Can1Votes.Font = new System.Drawing.Font("Cambria", 30F);
            this.Can1Votes.Location = new System.Drawing.Point(0, 5);
            this.Can1Votes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Can1Votes.Name = "Can1Votes";
            this.Can1Votes.Size = new System.Drawing.Size(360, 47);
            this.Can1Votes.TabIndex = 3;
            this.Can1Votes.Text = "0";
            this.Can1Votes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // livevotechart
            // 
            chartArea8.Name = "ChartArea1";
            this.livevotechart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.livevotechart.Legends.Add(legend8);
            this.livevotechart.Location = new System.Drawing.Point(24, 328);
            this.livevotechart.Name = "livevotechart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.livevotechart.Series.Add(series8);
            this.livevotechart.Size = new System.Drawing.Size(680, 317);
            this.livevotechart.TabIndex = 3;
            this.livevotechart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResetSetUp);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.EditFormBTN);
            this.tabPage2.Controls.Add(this.CAN2Button);
            this.tabPage2.Controls.Add(this.Can2Box);
            this.tabPage2.Controls.Add(this.Can1Button);
            this.tabPage2.Controls.Add(this.Can1Box);
            this.tabPage2.Controls.Add(this.DistrictButton);
            this.tabPage2.Controls.Add(this.RaceTitleButton);
            this.tabPage2.Controls.Add(this.RaceTitleBox);
            this.tabPage2.Controls.Add(this.DistrictBox);
            this.tabPage2.Controls.Add(this.SetupTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Set Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResetSetUp
            // 
            this.ResetSetUp.BackColor = System.Drawing.Color.MistyRose;
            this.ResetSetUp.Font = new System.Drawing.Font("Cambria", 12F);
            this.ResetSetUp.Location = new System.Drawing.Point(1226, 32);
            this.ResetSetUp.Name = "ResetSetUp";
            this.ResetSetUp.Size = new System.Drawing.Size(86, 84);
            this.ResetSetUp.TabIndex = 104;
            this.ResetSetUp.Text = "Reset";
            this.ResetSetUp.UseVisualStyleBackColor = false;
            this.ResetSetUp.Click += new System.EventHandler(this.ResetSetUp_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(526, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 103;
            this.label14.Text = "Districts:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 23);
            this.label13.TabIndex = 102;
            this.label13.Text = "Can. 2 Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 23);
            this.label12.TabIndex = 101;
            this.label12.Text = "Can. 1 Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 100;
            this.label11.Text = "Race Title:";
            // 
            // EditFormBTN
            // 
            this.EditFormBTN.BackColor = System.Drawing.Color.Honeydew;
            this.EditFormBTN.Font = new System.Drawing.Font("Cambria", 24F);
            this.EditFormBTN.Location = new System.Drawing.Point(1013, 32);
            this.EditFormBTN.Name = "EditFormBTN";
            this.EditFormBTN.Size = new System.Drawing.Size(207, 84);
            this.EditFormBTN.TabIndex = 99;
            this.EditFormBTN.Text = "Edit";
            this.EditFormBTN.UseVisualStyleBackColor = false;
            this.EditFormBTN.Click += new System.EventHandler(this.EditFormBTN_Click);
            // 
            // CAN2Button
            // 
            this.CAN2Button.Location = new System.Drawing.Point(925, 82);
            this.CAN2Button.Name = "CAN2Button";
            this.CAN2Button.Size = new System.Drawing.Size(82, 34);
            this.CAN2Button.TabIndex = 12;
            this.CAN2Button.Text = "Enter";
            this.CAN2Button.UseVisualStyleBackColor = true;
            this.CAN2Button.Click += new System.EventHandler(this.CAN2Button_Click);
            // 
            // Can2Box
            // 
            this.Can2Box.Location = new System.Drawing.Point(670, 82);
            this.Can2Box.Name = "Can2Box";
            this.Can2Box.Size = new System.Drawing.Size(250, 31);
            this.Can2Box.TabIndex = 11;
            // 
            // Can1Button
            // 
            this.Can1Button.Location = new System.Drawing.Point(412, 82);
            this.Can1Button.Name = "Can1Button";
            this.Can1Button.Size = new System.Drawing.Size(82, 34);
            this.Can1Button.TabIndex = 10;
            this.Can1Button.Text = "Enter";
            this.Can1Button.UseVisualStyleBackColor = true;
            this.Can1Button.Click += new System.EventHandler(this.Can1Button_Click);
            // 
            // Can1Box
            // 
            this.Can1Box.Location = new System.Drawing.Point(160, 82);
            this.Can1Box.Name = "Can1Box";
            this.Can1Box.Size = new System.Drawing.Size(250, 31);
            this.Can1Box.TabIndex = 9;
            // 
            // DistrictButton
            // 
            this.DistrictButton.Location = new System.Drawing.Point(925, 32);
            this.DistrictButton.Name = "DistrictButton";
            this.DistrictButton.Size = new System.Drawing.Size(82, 34);
            this.DistrictButton.TabIndex = 6;
            this.DistrictButton.Text = "Enter";
            this.DistrictButton.UseVisualStyleBackColor = true;
            this.DistrictButton.Click += new System.EventHandler(this.DistrictButton_Click);
            // 
            // RaceTitleButton
            // 
            this.RaceTitleButton.Location = new System.Drawing.Point(412, 32);
            this.RaceTitleButton.Name = "RaceTitleButton";
            this.RaceTitleButton.Size = new System.Drawing.Size(82, 34);
            this.RaceTitleButton.TabIndex = 5;
            this.RaceTitleButton.Text = "Enter";
            this.RaceTitleButton.UseVisualStyleBackColor = true;
            this.RaceTitleButton.Click += new System.EventHandler(this.RaceTitleButton_Click);
            // 
            // RaceTitleBox
            // 
            this.RaceTitleBox.Location = new System.Drawing.Point(160, 32);
            this.RaceTitleBox.Name = "RaceTitleBox";
            this.RaceTitleBox.Size = new System.Drawing.Size(250, 31);
            this.RaceTitleBox.TabIndex = 4;
            // 
            // DistrictBox
            // 
            this.DistrictBox.Location = new System.Drawing.Point(670, 32);
            this.DistrictBox.Name = "DistrictBox";
            this.DistrictBox.Size = new System.Drawing.Size(250, 31);
            this.DistrictBox.TabIndex = 3;
            // 
            // SetupTable
            // 
            this.SetupTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetupTable.AutoScroll = true;
            this.SetupTable.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.SetupTable.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.SetupTable.AutoSize = true;
            this.SetupTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetupTable.BackColor = System.Drawing.Color.LightGray;
            this.SetupTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SetupTable.ColumnCount = 12;
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.122449F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.SetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.122449F));
            this.SetupTable.Location = new System.Drawing.Point(30, 169);
            this.SetupTable.MaximumSize = new System.Drawing.Size(1280, 500);
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
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetupTable.Size = new System.Drawing.Size(17, 365);
            this.SetupTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Election Simulator";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label INFOBanner;
        private System.Windows.Forms.Label MassSimLabel;
        private System.Windows.Forms.Label INPCT;
        private System.Windows.Forms.TextBox RunConditionBox;
        private System.Windows.Forms.TextBox MassSIMBox;
        private System.Windows.Forms.TableLayoutPanel SetupTable;
        private System.Windows.Forms.TextBox RaceTitleBox;
        private System.Windows.Forms.TextBox DistrictBox;
        private System.Windows.Forms.Label ElectionTime;
        private System.Windows.Forms.Button ResetSimup;
        private System.Windows.Forms.Button StartSimSetup;
        private System.Windows.Forms.Button DistrictButton;
        private System.Windows.Forms.Button RaceTitleButton;
        private System.Windows.Forms.Button Can1Button;
        private System.Windows.Forms.TextBox Can1Box;
        private System.Windows.Forms.Button CAN2Button;
        private System.Windows.Forms.TextBox Can2Box;
        private System.Windows.Forms.Button EditFormBTN;
        private System.Windows.Forms.Button ResetSetUp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ElectionTitle;
    }
}

