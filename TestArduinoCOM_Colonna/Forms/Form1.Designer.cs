namespace TestArduinoCOM
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.txtTempUO = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.timePointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TempCUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tempUODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOpenSession = new System.Windows.Forms.Button();
			this.btnCreateSession = new System.Windows.Forms.Button();
			this.txtGetSessionName = new System.Windows.Forms.TextBox();
			this.txtTempCUB = new System.Windows.Forms.Label();
			this.btnSetNumberOflastpoints = new System.Windows.Forms.Button();
			this.txtLastNumberPoints = new System.Windows.Forms.TextBox();
			this.txtMax = new System.Windows.Forms.TextBox();
			this.txtMin = new System.Windows.Forms.TextBox();
			this.btnSetMinMax = new System.Windows.Forms.Button();
			this.btnSetMaxTemper = new System.Windows.Forms.Button();
			this.numericUpDownUpperTemp = new System.Windows.Forms.NumericUpDown();
			this.lblMaxTempInController = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnGoCOM = new System.Windows.Forms.Button();
			this.btnStopCOM = new System.Windows.Forms.Button();
			this.btnUpdCOMLIST = new System.Windows.Forms.Button();
			this.txtPointsLoaded = new System.Windows.Forms.TextBox();
			this.btnAutoMode = new System.Windows.Forms.Button();
			this.btnOpenCloseKlapan = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxProcessing = new System.Windows.Forms.PictureBox();
			this.numericUpDownLowTemp = new System.Windows.Forms.NumericUpDown();
			this.lblMinTempInController = new System.Windows.Forms.Label();
			this.lblKlapanOpenDuration = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2Awaiter = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gPointBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTempUO
			// 
			this.txtTempUO.AutoSize = true;
			this.txtTempUO.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTempUO.Location = new System.Drawing.Point(133, 95);
			this.txtTempUO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txtTempUO.Name = "txtTempUO";
			this.txtTempUO.Size = new System.Drawing.Size(83, 44);
			this.txtTempUO.TabIndex = 5;
			this.txtTempUO.Text = "00.0";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timePointDataGridViewTextBoxColumn,
            this.TempCUB,
            this.tempUODataGridViewTextBoxColumn,
            this.Alco});
			this.dataGridView1.DataSource = this.gPointBindingSource;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView1.Location = new System.Drawing.Point(251, 68);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(472, 513);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// timePointDataGridViewTextBoxColumn
			// 
			this.timePointDataGridViewTextBoxColumn.DataPropertyName = "TimePoint";
			dataGridViewCellStyle7.Format = "HH:mm:ss";
			this.timePointDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.timePointDataGridViewTextBoxColumn.HeaderText = "TimePoint";
			this.timePointDataGridViewTextBoxColumn.Name = "timePointDataGridViewTextBoxColumn";
			this.timePointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// TempCUB
			// 
			this.TempCUB.DataPropertyName = "TempCUB";
			this.TempCUB.HeaderText = "TempCUB";
			this.TempCUB.Name = "TempCUB";
			this.TempCUB.ReadOnly = true;
			// 
			// tempUODataGridViewTextBoxColumn
			// 
			this.tempUODataGridViewTextBoxColumn.DataPropertyName = "TempUO";
			dataGridViewCellStyle8.Format = "#.####";
			this.tempUODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.tempUODataGridViewTextBoxColumn.HeaderText = "TempUO";
			this.tempUODataGridViewTextBoxColumn.Name = "tempUODataGridViewTextBoxColumn";
			this.tempUODataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Alco
			// 
			this.Alco.DataPropertyName = "Alco";
			dataGridViewCellStyle9.Format = "##.##";
			this.Alco.DefaultCellStyle = dataGridViewCellStyle9;
			this.Alco.HeaderText = "Alco";
			this.Alco.Name = "Alco";
			this.Alco.ReadOnly = true;
			// 
			// gPointBindingSource
			// 
			this.gPointBindingSource.DataSource = typeof(TestArduinoCOM.BL.GPoint);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
			this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
			this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(729, 68);
			this.chart1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(811, 514);
			this.chart1.TabIndex = 9;
			this.chart1.Text = "chart1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(251, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Session:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(339, 41);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "session_name";
			// 
			// btnOpenSession
			// 
			this.btnOpenSession.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOpenSession.Location = new System.Drawing.Point(251, 10);
			this.btnOpenSession.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnOpenSession.Name = "btnOpenSession";
			this.btnOpenSession.Size = new System.Drawing.Size(55, 31);
			this.btnOpenSession.TabIndex = 12;
			this.btnOpenSession.Text = "OPN";
			this.btnOpenSession.UseVisualStyleBackColor = true;
			this.btnOpenSession.Click += new System.EventHandler(this.btnOpenSession_Click);
			// 
			// btnCreateSession
			// 
			this.btnCreateSession.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateSession.Location = new System.Drawing.Point(310, 10);
			this.btnCreateSession.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnCreateSession.Name = "btnCreateSession";
			this.btnCreateSession.Size = new System.Drawing.Size(71, 31);
			this.btnCreateSession.TabIndex = 13;
			this.btnCreateSession.Text = "new";
			this.btnCreateSession.UseVisualStyleBackColor = true;
			this.btnCreateSession.Click += new System.EventHandler(this.btnCreateSession_Click);
			// 
			// txtGetSessionName
			// 
			this.txtGetSessionName.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtGetSessionName.Location = new System.Drawing.Point(385, 10);
			this.txtGetSessionName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.txtGetSessionName.Name = "txtGetSessionName";
			this.txtGetSessionName.Size = new System.Drawing.Size(200, 30);
			this.txtGetSessionName.TabIndex = 14;
			// 
			// txtTempCUB
			// 
			this.txtTempCUB.AutoSize = true;
			this.txtTempCUB.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTempCUB.Location = new System.Drawing.Point(47, 431);
			this.txtTempCUB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txtTempCUB.Name = "txtTempCUB";
			this.txtTempCUB.Size = new System.Drawing.Size(83, 44);
			this.txtTempCUB.TabIndex = 15;
			this.txtTempCUB.Text = "00.0";
			// 
			// btnSetNumberOflastpoints
			// 
			this.btnSetNumberOflastpoints.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetNumberOflastpoints.Location = new System.Drawing.Point(785, 34);
			this.btnSetNumberOflastpoints.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnSetNumberOflastpoints.Name = "btnSetNumberOflastpoints";
			this.btnSetNumberOflastpoints.Size = new System.Drawing.Size(91, 27);
			this.btnSetNumberOflastpoints.TabIndex = 17;
			this.btnSetNumberOflastpoints.Text = "set mins";
			this.btnSetNumberOflastpoints.UseVisualStyleBackColor = true;
			this.btnSetNumberOflastpoints.Click += new System.EventHandler(this.btnSetNumberOflastpoints_Click);
			// 
			// txtLastNumberPoints
			// 
			this.txtLastNumberPoints.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtLastNumberPoints.Location = new System.Drawing.Point(729, 34);
			this.txtLastNumberPoints.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.txtLastNumberPoints.Name = "txtLastNumberPoints";
			this.txtLastNumberPoints.Size = new System.Drawing.Size(52, 27);
			this.txtLastNumberPoints.TabIndex = 18;
			this.txtLastNumberPoints.Text = "500";
			// 
			// txtMax
			// 
			this.txtMax.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtMax.Location = new System.Drawing.Point(951, 34);
			this.txtMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(52, 27);
			this.txtMax.TabIndex = 19;
			this.txtMax.Text = "80";
			// 
			// txtMin
			// 
			this.txtMin.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtMin.Location = new System.Drawing.Point(1007, 34);
			this.txtMin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.txtMin.Name = "txtMin";
			this.txtMin.Size = new System.Drawing.Size(52, 27);
			this.txtMin.TabIndex = 20;
			this.txtMin.Text = "70";
			// 
			// btnSetMinMax
			// 
			this.btnSetMinMax.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetMinMax.Location = new System.Drawing.Point(1063, 34);
			this.btnSetMinMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.btnSetMinMax.Name = "btnSetMinMax";
			this.btnSetMinMax.Size = new System.Drawing.Size(59, 27);
			this.btnSetMinMax.TabIndex = 21;
			this.btnSetMinMax.Text = "set";
			this.btnSetMinMax.UseVisualStyleBackColor = true;
			this.btnSetMinMax.Click += new System.EventHandler(this.btnSetMinMax_Click);
			// 
			// btnSetMaxTemper
			// 
			this.btnSetMaxTemper.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetMaxTemper.Location = new System.Drawing.Point(141, 308);
			this.btnSetMaxTemper.Name = "btnSetMaxTemper";
			this.btnSetMaxTemper.Size = new System.Drawing.Size(75, 35);
			this.btnSetMaxTemper.TabIndex = 23;
			this.btnSetMaxTemper.Text = "set";
			this.btnSetMaxTemper.UseVisualStyleBackColor = true;
			this.btnSetMaxTemper.Click += new System.EventHandler(this.btnSetMaxTemper_Click);
			// 
			// numericUpDownUpperTemp
			// 
			this.numericUpDownUpperTemp.DecimalPlaces = 1;
			this.numericUpDownUpperTemp.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownUpperTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownUpperTemp.Location = new System.Drawing.Point(141, 242);
			this.numericUpDownUpperTemp.Name = "numericUpDownUpperTemp";
			this.numericUpDownUpperTemp.Size = new System.Drawing.Size(75, 27);
			this.numericUpDownUpperTemp.TabIndex = 24;
			this.numericUpDownUpperTemp.Value = new decimal(new int[] {
            752,
            0,
            0,
            65536});
			this.numericUpDownUpperTemp.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDownUpperTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
			this.numericUpDownUpperTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
			// 
			// lblMaxTempInController
			// 
			this.lblMaxTempInController.AutoSize = true;
			this.lblMaxTempInController.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMaxTempInController.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lblMaxTempInController.Location = new System.Drawing.Point(134, 156);
			this.lblMaxTempInController.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaxTempInController.Name = "lblMaxTempInController";
			this.lblMaxTempInController.Size = new System.Drawing.Size(83, 44);
			this.lblMaxTempInController.TabIndex = 25;
			this.lblMaxTempInController.Text = "00.0";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(8, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(99, 21);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 26;
			// 
			// btnGoCOM
			// 
			this.btnGoCOM.Location = new System.Drawing.Point(113, 8);
			this.btnGoCOM.Name = "btnGoCOM";
			this.btnGoCOM.Size = new System.Drawing.Size(34, 23);
			this.btnGoCOM.TabIndex = 27;
			this.btnGoCOM.Text = "go";
			this.btnGoCOM.UseVisualStyleBackColor = true;
			this.btnGoCOM.Click += new System.EventHandler(this.btnGoCOM_Click);
			// 
			// btnStopCOM
			// 
			this.btnStopCOM.Location = new System.Drawing.Point(153, 8);
			this.btnStopCOM.Name = "btnStopCOM";
			this.btnStopCOM.Size = new System.Drawing.Size(34, 23);
			this.btnStopCOM.TabIndex = 28;
			this.btnStopCOM.Text = "stp";
			this.btnStopCOM.UseVisualStyleBackColor = true;
			this.btnStopCOM.Click += new System.EventHandler(this.btnStopCOM_Click);
			// 
			// btnUpdCOMLIST
			// 
			this.btnUpdCOMLIST.Location = new System.Drawing.Point(193, 8);
			this.btnUpdCOMLIST.Name = "btnUpdCOMLIST";
			this.btnUpdCOMLIST.Size = new System.Drawing.Size(34, 23);
			this.btnUpdCOMLIST.TabIndex = 29;
			this.btnUpdCOMLIST.Text = "upd";
			this.btnUpdCOMLIST.UseVisualStyleBackColor = true;
			this.btnUpdCOMLIST.Click += new System.EventHandler(this.btnUpdCOMLIST_Click);
			// 
			// txtPointsLoaded
			// 
			this.txtPointsLoaded.Location = new System.Drawing.Point(251, 585);
			this.txtPointsLoaded.Name = "txtPointsLoaded";
			this.txtPointsLoaded.Size = new System.Drawing.Size(100, 20);
			this.txtPointsLoaded.TabIndex = 30;
			// 
			// btnAutoMode
			// 
			this.btnAutoMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
			this.btnAutoMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAutoMode.FlatAppearance.BorderSize = 0;
			this.btnAutoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAutoMode.Location = new System.Drawing.Point(12, 37);
			this.btnAutoMode.Name = "btnAutoMode";
			this.btnAutoMode.Size = new System.Drawing.Size(24, 24);
			this.btnAutoMode.TabIndex = 31;
			this.btnAutoMode.UseVisualStyleBackColor = false;
			this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
			// 
			// btnOpenCloseKlapan
			// 
			this.btnOpenCloseKlapan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
			this.btnOpenCloseKlapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpenCloseKlapan.FlatAppearance.BorderSize = 0;
			this.btnOpenCloseKlapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenCloseKlapan.Location = new System.Drawing.Point(70, 174);
			this.btnOpenCloseKlapan.Name = "btnOpenCloseKlapan";
			this.btnOpenCloseKlapan.Size = new System.Drawing.Size(24, 24);
			this.btnOpenCloseKlapan.TabIndex = 32;
			this.btnOpenCloseKlapan.UseVisualStyleBackColor = false;
			this.btnOpenCloseKlapan.Click += new System.EventHandler(this.btnOpenCloseKlapan_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(18, 201);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(38, 38);
			this.pictureBox2.TabIndex = 22;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TestArduinoCOM.Properties.Resources.colonna;
			this.pictureBox1.Location = new System.Drawing.Point(8, 34);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(239, 489);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBoxProcessing
			// 
			this.pictureBoxProcessing.Location = new System.Drawing.Point(79, 52);
			this.pictureBoxProcessing.Name = "pictureBoxProcessing";
			this.pictureBoxProcessing.Size = new System.Drawing.Size(15, 116);
			this.pictureBoxProcessing.TabIndex = 33;
			this.pictureBoxProcessing.TabStop = false;
			// 
			// numericUpDownLowTemp
			// 
			this.numericUpDownLowTemp.DecimalPlaces = 1;
			this.numericUpDownLowTemp.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownLowTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownLowTemp.Location = new System.Drawing.Point(141, 275);
			this.numericUpDownLowTemp.Name = "numericUpDownLowTemp";
			this.numericUpDownLowTemp.Size = new System.Drawing.Size(75, 27);
			this.numericUpDownLowTemp.TabIndex = 34;
			this.numericUpDownLowTemp.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
			this.numericUpDownLowTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
			this.numericUpDownLowTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
			// 
			// lblMinTempInController
			// 
			this.lblMinTempInController.AutoSize = true;
			this.lblMinTempInController.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMinTempInController.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lblMinTempInController.Location = new System.Drawing.Point(134, 195);
			this.lblMinTempInController.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMinTempInController.Name = "lblMinTempInController";
			this.lblMinTempInController.Size = new System.Drawing.Size(83, 44);
			this.lblMinTempInController.TabIndex = 35;
			this.lblMinTempInController.Text = "00.0";
			// 
			// lblKlapanOpenDuration
			// 
			this.lblKlapanOpenDuration.AutoSize = true;
			this.lblKlapanOpenDuration.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblKlapanOpenDuration.Location = new System.Drawing.Point(10, 112);
			this.lblKlapanOpenDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblKlapanOpenDuration.Name = "lblKlapanOpenDuration";
			this.lblKlapanOpenDuration.Size = new System.Drawing.Size(19, 23);
			this.lblKlapanOpenDuration.TabIndex = 36;
			this.lblKlapanOpenDuration.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 93);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 37;
			this.label3.Text = "Задерж";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(14, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 27);
			this.textBox1.TabIndex = 38;
			this.textBox1.Visible = false;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2Awaiter
			// 
			this.timer2Awaiter.Tick += new System.EventHandler(this.timer2Awaiter_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1551, 610);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblKlapanOpenDuration);
			this.Controls.Add(this.lblMinTempInController);
			this.Controls.Add(this.numericUpDownLowTemp);
			this.Controls.Add(this.pictureBoxProcessing);
			this.Controls.Add(this.btnOpenCloseKlapan);
			this.Controls.Add(this.btnAutoMode);
			this.Controls.Add(this.txtPointsLoaded);
			this.Controls.Add(this.btnUpdCOMLIST);
			this.Controls.Add(this.btnStopCOM);
			this.Controls.Add(this.btnGoCOM);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblMaxTempInController);
			this.Controls.Add(this.numericUpDownUpperTemp);
			this.Controls.Add(this.btnSetMaxTemper);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnSetMinMax);
			this.Controls.Add(this.txtMin);
			this.Controls.Add(this.txtMax);
			this.Controls.Add(this.txtLastNumberPoints);
			this.Controls.Add(this.btnSetNumberOflastpoints);
			this.Controls.Add(this.txtTempCUB);
			this.Controls.Add(this.txtGetSessionName);
			this.Controls.Add(this.btnCreateSession);
			this.Controls.Add(this.btnOpenSession);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtTempUO);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gPointBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowTemp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Label txtTempUO;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOpenSession;
		private System.Windows.Forms.Button btnCreateSession;
		private System.Windows.Forms.TextBox txtGetSessionName;
		private System.Windows.Forms.Label txtTempCUB;
		private System.Windows.Forms.BindingSource gPointBindingSource;
		private System.Windows.Forms.Button btnSetNumberOflastpoints;
		private System.Windows.Forms.TextBox txtLastNumberPoints;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.TextBox txtMin;
		private System.Windows.Forms.Button btnSetMinMax;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnSetMaxTemper;
		private System.Windows.Forms.NumericUpDown numericUpDownUpperTemp;
		private System.Windows.Forms.Label lblMaxTempInController;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnGoCOM;
		private System.Windows.Forms.Button btnStopCOM;
		private System.Windows.Forms.Button btnUpdCOMLIST;
		private System.Windows.Forms.TextBox txtPointsLoaded;
		private System.Windows.Forms.DataGridViewTextBoxColumn timePointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TempCUB;
		private System.Windows.Forms.DataGridViewTextBoxColumn tempUODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alco;
		private System.Windows.Forms.Button btnAutoMode;
		private System.Windows.Forms.Button btnOpenCloseKlapan;
		private System.Windows.Forms.PictureBox pictureBoxProcessing;
		private System.Windows.Forms.NumericUpDown numericUpDownLowTemp;
		private System.Windows.Forms.Label lblMinTempInController;
		private System.Windows.Forms.Label lblKlapanOpenDuration;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2Awaiter;
	}
}

