namespace OSUBendingTestForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.SeriesFolder_Label = new System.Windows.Forms.Label();
            this.SpecimenNumber_Label = new System.Windows.Forms.Label();
            this.SpecimenNumber_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ImportData_Button = new System.Windows.Forms.Button();
            this.Span_Label = new System.Windows.Forms.Label();
            this.Depth_Label = new System.Windows.Forms.Label();
            this.Width_Label = new System.Windows.Forms.Label();
            this.Method_Label = new System.Windows.Forms.Label();
            this.DataFoldler_BrowserDiolog = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Properties_Label = new System.Windows.Forms.Label();
            this.CalculateProperties_Button = new System.Windows.Forms.Button();
            this.MaxLoad_Label = new System.Windows.Forms.Label();
            this.MOE_Label = new System.Windows.Forms.Label();
            this.MOR_Label = new System.Windows.Forms.Label();
            this.MaxCylindricalDeflection_Label = new System.Windows.Forms.Label();
            this.Range_Label = new System.Windows.Forms.Label();
            this.LowerBound_Label = new System.Windows.Forms.Label();
            this.UpperBound_Label = new System.Windows.Forms.Label();
            this.LowerBound_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpperBound_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxLoadValue_Label = new System.Windows.Forms.Label();
            this.MOEValue_Label = new System.Windows.Forms.Label();
            this.MORValue_Label = new System.Windows.Forms.Label();
            this.MaxCylindricalDeflectionValue_Label = new System.Windows.Forms.Label();
            this.GraphData_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.SpecimenInfomation_Label = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.Span_TaxtBox = new System.Windows.Forms.TextBox();
            this.Depth_TextBox = new System.Windows.Forms.TextBox();
            this.Width_TextBox = new System.Windows.Forms.TextBox();
            this.GraphRegression_Button = new System.Windows.Forms.Button();
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.CurrentSpecimen_Label = new System.Windows.Forms.Label();
            this.CurrentSpecimenValue_Label = new System.Windows.Forms.Label();
            this.CalculateProperties_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LowerBoundNumericUpDown_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpperBoundNumericUpDown_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Logo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecimenNumber_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBound_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBound_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateProperties_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundNumericUpDown_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundNumericUpDown_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 481);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(889, 598);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1269, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Path:";
            // 
            // SeriesFolder_Label
            // 
            this.SeriesFolder_Label.AutoSize = true;
            this.SeriesFolder_Label.Location = new System.Drawing.Point(625, 55);
            this.SeriesFolder_Label.Name = "SeriesFolder_Label";
            this.SeriesFolder_Label.Size = new System.Drawing.Size(111, 20);
            this.SeriesFolder_Label.TabIndex = 10;
            this.SeriesFolder_Label.Text = "Series Folder: ";
            // 
            // SpecimenNumber_Label
            // 
            this.SpecimenNumber_Label.AutoSize = true;
            this.SpecimenNumber_Label.Location = new System.Drawing.Point(972, 55);
            this.SpecimenNumber_Label.Name = "SpecimenNumber_Label";
            this.SpecimenNumber_Label.Size = new System.Drawing.Size(144, 20);
            this.SpecimenNumber_Label.TabIndex = 11;
            this.SpecimenNumber_Label.Text = "Specimen Number:";
            // 
            // SpecimenNumber_NumericUpDown
            // 
            this.SpecimenNumber_NumericUpDown.Location = new System.Drawing.Point(1122, 49);
            this.SpecimenNumber_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SpecimenNumber_NumericUpDown.Name = "SpecimenNumber_NumericUpDown";
            this.SpecimenNumber_NumericUpDown.Size = new System.Drawing.Size(270, 26);
            this.SpecimenNumber_NumericUpDown.TabIndex = 14;
            this.SpecimenNumber_NumericUpDown.ValueChanged += new System.EventHandler(this.SpecimenNumber_NumericUpDown_ValueChanged);
            // 
            // ImportData_Button
            // 
            this.ImportData_Button.Location = new System.Drawing.Point(737, 47);
            this.ImportData_Button.Name = "ImportData_Button";
            this.ImportData_Button.Size = new System.Drawing.Size(113, 35);
            this.ImportData_Button.TabIndex = 16;
            this.ImportData_Button.Text = "Import Data";
            this.ImportData_Button.Click += new System.EventHandler(this.ImportData_Button_Click);
            // 
            // Span_Label
            // 
            this.Span_Label.AutoSize = true;
            this.Span_Label.Location = new System.Drawing.Point(237, 156);
            this.Span_Label.Name = "Span_Label";
            this.Span_Label.Size = new System.Drawing.Size(77, 20);
            this.Span_Label.TabIndex = 17;
            this.Span_Label.Text = "Span (in):";
            // 
            // Depth_Label
            // 
            this.Depth_Label.AutoSize = true;
            this.Depth_Label.Location = new System.Drawing.Point(452, 156);
            this.Depth_Label.Name = "Depth_Label";
            this.Depth_Label.Size = new System.Drawing.Size(83, 20);
            this.Depth_Label.TabIndex = 18;
            this.Depth_Label.Text = "Depth (in.)";
            // 
            // Width_Label
            // 
            this.Width_Label.AutoSize = true;
            this.Width_Label.Location = new System.Drawing.Point(668, 159);
            this.Width_Label.Name = "Width_Label";
            this.Width_Label.Size = new System.Drawing.Size(80, 20);
            this.Width_Label.TabIndex = 19;
            this.Width_Label.Text = "Width (in):";
            // 
            // Method_Label
            // 
            this.Method_Label.AutoSize = true;
            this.Method_Label.Location = new System.Drawing.Point(991, 155);
            this.Method_Label.Name = "Method_Label";
            this.Method_Label.Size = new System.Drawing.Size(67, 20);
            this.Method_Label.TabIndex = 22;
            this.Method_Label.Text = "Method:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1062, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3 Point";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1062, 176);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4 Point";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Properties_Label
            // 
            this.Properties_Label.AutoSize = true;
            this.Properties_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Properties_Label.Location = new System.Drawing.Point(205, 243);
            this.Properties_Label.Name = "Properties_Label";
            this.Properties_Label.Size = new System.Drawing.Size(125, 29);
            this.Properties_Label.TabIndex = 25;
            this.Properties_Label.Text = "Properties";
            // 
            // CalculateProperties_Button
            // 
            this.CalculateProperties_Button.Location = new System.Drawing.Point(394, 243);
            this.CalculateProperties_Button.Name = "CalculateProperties_Button";
            this.CalculateProperties_Button.Size = new System.Drawing.Size(203, 29);
            this.CalculateProperties_Button.TabIndex = 26;
            this.CalculateProperties_Button.Text = "Calculate Properties";
            this.CalculateProperties_Button.UseVisualStyleBackColor = true;
            this.CalculateProperties_Button.Click += new System.EventHandler(this.CalculateProperties_Button_Click);
            // 
            // MaxLoad_Label
            // 
            this.MaxLoad_Label.AutoSize = true;
            this.MaxLoad_Label.Location = new System.Drawing.Point(220, 322);
            this.MaxLoad_Label.Name = "MaxLoad_Label";
            this.MaxLoad_Label.Size = new System.Drawing.Size(82, 20);
            this.MaxLoad_Label.TabIndex = 27;
            this.MaxLoad_Label.Text = "Max Load:";
            // 
            // MOE_Label
            // 
            this.MOE_Label.AutoSize = true;
            this.MOE_Label.Location = new System.Drawing.Point(565, 322);
            this.MOE_Label.Name = "MOE_Label";
            this.MOE_Label.Size = new System.Drawing.Size(49, 20);
            this.MOE_Label.TabIndex = 28;
            this.MOE_Label.Text = "MOE:";
            // 
            // MOR_Label
            // 
            this.MOR_Label.AutoSize = true;
            this.MOR_Label.Location = new System.Drawing.Point(888, 322);
            this.MOR_Label.Name = "MOR_Label";
            this.MOR_Label.Size = new System.Drawing.Size(50, 20);
            this.MOR_Label.TabIndex = 29;
            this.MOR_Label.Text = "MOR:";
            // 
            // MaxCylindricalDeflection_Label
            // 
            this.MaxCylindricalDeflection_Label.AutoSize = true;
            this.MaxCylindricalDeflection_Label.Location = new System.Drawing.Point(1305, 322);
            this.MaxCylindricalDeflection_Label.Name = "MaxCylindricalDeflection_Label";
            this.MaxCylindricalDeflection_Label.Size = new System.Drawing.Size(192, 20);
            this.MaxCylindricalDeflection_Label.TabIndex = 30;
            this.MaxCylindricalDeflection_Label.Text = "Max Cylindrical Deflection:";
            // 
            // Range_Label
            // 
            this.Range_Label.AutoSize = true;
            this.Range_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Range_Label.Location = new System.Drawing.Point(200, 415);
            this.Range_Label.Name = "Range_Label";
            this.Range_Label.Size = new System.Drawing.Size(79, 29);
            this.Range_Label.TabIndex = 31;
            this.Range_Label.Text = "Graph";
            // 
            // LowerBound_Label
            // 
            this.LowerBound_Label.AutoSize = true;
            this.LowerBound_Label.Location = new System.Drawing.Point(983, 656);
            this.LowerBound_Label.Name = "LowerBound_Label";
            this.LowerBound_Label.Size = new System.Drawing.Size(107, 20);
            this.LowerBound_Label.TabIndex = 32;
            this.LowerBound_Label.Text = "Lower Bound:";
            // 
            // UpperBound_Label
            // 
            this.UpperBound_Label.AutoSize = true;
            this.UpperBound_Label.Location = new System.Drawing.Point(1232, 655);
            this.UpperBound_Label.Name = "UpperBound_Label";
            this.UpperBound_Label.Size = new System.Drawing.Size(108, 20);
            this.UpperBound_Label.TabIndex = 33;
            this.UpperBound_Label.Text = "Upper Bound:";
            // 
            // LowerBound_NumericUpDown
            // 
            this.LowerBound_NumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LowerBound_NumericUpDown.Location = new System.Drawing.Point(1096, 650);
            this.LowerBound_NumericUpDown.Name = "LowerBound_NumericUpDown";
            this.LowerBound_NumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.LowerBound_NumericUpDown.TabIndex = 34;
            this.LowerBound_NumericUpDown.ValueChanged += new System.EventHandler(this.LowerBound_NumericUpDown_ValueChanged);
            // 
            // UpperBound_NumericUpDown
            // 
            this.UpperBound_NumericUpDown.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.UpperBound_NumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpperBound_NumericUpDown.Location = new System.Drawing.Point(1346, 649);
            this.UpperBound_NumericUpDown.Name = "UpperBound_NumericUpDown";
            this.UpperBound_NumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.UpperBound_NumericUpDown.TabIndex = 35;
            this.UpperBound_NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpperBound_NumericUpDown.ValueChanged += new System.EventHandler(this.UpperBound_NumericUpDown_ValueChanged);
            // 
            // MaxLoadValue_Label
            // 
            this.MaxLoadValue_Label.AutoSize = true;
            this.MaxLoadValue_Label.Location = new System.Drawing.Point(308, 322);
            this.MaxLoadValue_Label.Name = "MaxLoadValue_Label";
            this.MaxLoadValue_Label.Size = new System.Drawing.Size(24, 20);
            this.MaxLoadValue_Label.TabIndex = 36;
            this.MaxLoadValue_Label.Text = "---";
            // 
            // MOEValue_Label
            // 
            this.MOEValue_Label.AutoSize = true;
            this.MOEValue_Label.Location = new System.Drawing.Point(620, 322);
            this.MOEValue_Label.Name = "MOEValue_Label";
            this.MOEValue_Label.Size = new System.Drawing.Size(24, 20);
            this.MOEValue_Label.TabIndex = 37;
            this.MOEValue_Label.Text = "---";
            // 
            // MORValue_Label
            // 
            this.MORValue_Label.AutoSize = true;
            this.MORValue_Label.Location = new System.Drawing.Point(944, 322);
            this.MORValue_Label.Name = "MORValue_Label";
            this.MORValue_Label.Size = new System.Drawing.Size(24, 20);
            this.MORValue_Label.TabIndex = 38;
            this.MORValue_Label.Text = "---";
            // 
            // MaxCylindricalDeflectionValue_Label
            // 
            this.MaxCylindricalDeflectionValue_Label.AutoSize = true;
            this.MaxCylindricalDeflectionValue_Label.Location = new System.Drawing.Point(1494, 322);
            this.MaxCylindricalDeflectionValue_Label.Name = "MaxCylindricalDeflectionValue_Label";
            this.MaxCylindricalDeflectionValue_Label.Size = new System.Drawing.Size(24, 20);
            this.MaxCylindricalDeflectionValue_Label.TabIndex = 39;
            this.MaxCylindricalDeflectionValue_Label.Text = "---";
            // 
            // GraphData_Button
            // 
            this.GraphData_Button.Location = new System.Drawing.Point(987, 737);
            this.GraphData_Button.Name = "GraphData_Button";
            this.GraphData_Button.Size = new System.Drawing.Size(137, 37);
            this.GraphData_Button.TabIndex = 40;
            this.GraphData_Button.Text = "Graph Data";
            this.GraphData_Button.UseVisualStyleBackColor = true;
            this.GraphData_Button.Click += new System.EventHandler(this.GraphData_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1660, 24);
            this.menuStrip1.TabIndex = 43;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // SpecimenInfomation_Label
            // 
            this.SpecimenInfomation_Label.AutoSize = true;
            this.SpecimenInfomation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecimenInfomation_Label.Location = new System.Drawing.Point(234, 41);
            this.SpecimenInfomation_Label.Name = "SpecimenInfomation_Label";
            this.SpecimenInfomation_Label.Size = new System.Drawing.Size(337, 37);
            this.SpecimenInfomation_Label.TabIndex = 9;
            this.SpecimenInfomation_Label.Text = "Specimen Information ";
            // 
            // Span_TaxtBox
            // 
            this.Span_TaxtBox.Location = new System.Drawing.Point(317, 153);
            this.Span_TaxtBox.Name = "Span_TaxtBox";
            this.Span_TaxtBox.Size = new System.Drawing.Size(90, 26);
            this.Span_TaxtBox.TabIndex = 44;
            // 
            // Depth_TextBox
            // 
            this.Depth_TextBox.Location = new System.Drawing.Point(541, 153);
            this.Depth_TextBox.Name = "Depth_TextBox";
            this.Depth_TextBox.Size = new System.Drawing.Size(90, 26);
            this.Depth_TextBox.TabIndex = 45;
            // 
            // Width_TextBox
            // 
            this.Width_TextBox.Location = new System.Drawing.Point(754, 156);
            this.Width_TextBox.Name = "Width_TextBox";
            this.Width_TextBox.Size = new System.Drawing.Size(90, 26);
            this.Width_TextBox.TabIndex = 46;
            // 
            // GraphRegression_Button
            // 
            this.GraphRegression_Button.Location = new System.Drawing.Point(1169, 737);
            this.GraphRegression_Button.Name = "GraphRegression_Button";
            this.GraphRegression_Button.Size = new System.Drawing.Size(171, 37);
            this.GraphRegression_Button.TabIndex = 48;
            this.GraphRegression_Button.Text = "Graph Regression";
            this.GraphRegression_Button.UseVisualStyleBackColor = true;
            this.GraphRegression_Button.Click += new System.EventHandler(this.GraphRegression_Button_Click);
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Location = new System.Drawing.Point(1350, 108);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(24, 20);
            this.FilePath_Label.TabIndex = 49;
            this.FilePath_Label.Text = "---";
            // 
            // CurrentSpecimen_Label
            // 
            this.CurrentSpecimen_Label.AutoSize = true;
            this.CurrentSpecimen_Label.Location = new System.Drawing.Point(1269, 139);
            this.CurrentSpecimen_Label.Name = "CurrentSpecimen_Label";
            this.CurrentSpecimen_Label.Size = new System.Drawing.Size(145, 20);
            this.CurrentSpecimen_Label.TabIndex = 50;
            this.CurrentSpecimen_Label.Text = "Current Specimen: ";
            // 
            // CurrentSpecimenValue_Label
            // 
            this.CurrentSpecimenValue_Label.AutoSize = true;
            this.CurrentSpecimenValue_Label.Location = new System.Drawing.Point(1410, 139);
            this.CurrentSpecimenValue_Label.Name = "CurrentSpecimenValue_Label";
            this.CurrentSpecimenValue_Label.Size = new System.Drawing.Size(24, 20);
            this.CurrentSpecimenValue_Label.TabIndex = 51;
            this.CurrentSpecimenValue_Label.Text = "---";
            // 
            // CalculateProperties_errorProvider
            // 
            this.CalculateProperties_errorProvider.ContainerControl = this;
            // 
            // LowerBoundNumericUpDown_errorProvider
            // 
            this.LowerBoundNumericUpDown_errorProvider.ContainerControl = this;
            // 
            // UpperBoundNumericUpDown_errorProvider
            // 
            this.UpperBoundNumericUpDown_errorProvider.ContainerControl = this;
            // 
            // Logo_pictureBox
            // 
            this.Logo_pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo_pictureBox.ErrorImage")));
            this.Logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_pictureBox.Image")));
            this.Logo_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo_pictureBox.InitialImage")));
            this.Logo_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.Logo_pictureBox.Name = "Logo_pictureBox";
            this.Logo_pictureBox.Size = new System.Drawing.Size(216, 173);
            this.Logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_pictureBox.TabIndex = 52;
            this.Logo_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 1050);
            this.Controls.Add(this.Logo_pictureBox);
            this.Controls.Add(this.CurrentSpecimenValue_Label);
            this.Controls.Add(this.CurrentSpecimen_Label);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.GraphRegression_Button);
            this.Controls.Add(this.Width_TextBox);
            this.Controls.Add(this.Depth_TextBox);
            this.Controls.Add(this.Span_TaxtBox);
            this.Controls.Add(this.GraphData_Button);
            this.Controls.Add(this.MaxCylindricalDeflectionValue_Label);
            this.Controls.Add(this.MORValue_Label);
            this.Controls.Add(this.MOEValue_Label);
            this.Controls.Add(this.MaxLoadValue_Label);
            this.Controls.Add(this.UpperBound_NumericUpDown);
            this.Controls.Add(this.LowerBound_NumericUpDown);
            this.Controls.Add(this.UpperBound_Label);
            this.Controls.Add(this.LowerBound_Label);
            this.Controls.Add(this.Range_Label);
            this.Controls.Add(this.MaxCylindricalDeflection_Label);
            this.Controls.Add(this.MOR_Label);
            this.Controls.Add(this.MOE_Label);
            this.Controls.Add(this.MaxLoad_Label);
            this.Controls.Add(this.CalculateProperties_Button);
            this.Controls.Add(this.Properties_Label);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Method_Label);
            this.Controls.Add(this.Width_Label);
            this.Controls.Add(this.Depth_Label);
            this.Controls.Add(this.Span_Label);
            this.Controls.Add(this.ImportData_Button);
            this.Controls.Add(this.SpecimenNumber_NumericUpDown);
            this.Controls.Add(this.SpecimenNumber_Label);
            this.Controls.Add(this.SeriesFolder_Label);
            this.Controls.Add(this.SpecimenInfomation_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecimenNumber_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBound_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBound_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateProperties_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundNumericUpDown_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundNumericUpDown_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SeriesFolder_Label;
        private System.Windows.Forms.Label SpecimenNumber_Label;
        private System.Windows.Forms.NumericUpDown SpecimenNumber_NumericUpDown;
        private System.Windows.Forms.Button ImportData_Button;
        private System.Windows.Forms.Label Span_Label;
        private System.Windows.Forms.Label Depth_Label;
        private System.Windows.Forms.Label Width_Label;
        private System.Windows.Forms.Label Method_Label;
        private System.Windows.Forms.FolderBrowserDialog DataFoldler_BrowserDiolog;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Properties_Label;
        private System.Windows.Forms.Button CalculateProperties_Button;
        private System.Windows.Forms.Label MaxLoad_Label;
        private System.Windows.Forms.Label MOE_Label;
        private System.Windows.Forms.Label MOR_Label;
        private System.Windows.Forms.Label MaxCylindricalDeflection_Label;
        private System.Windows.Forms.Label Range_Label;
        private System.Windows.Forms.Label LowerBound_Label;
        private System.Windows.Forms.Label UpperBound_Label;
        private System.Windows.Forms.NumericUpDown LowerBound_NumericUpDown;
        private System.Windows.Forms.NumericUpDown UpperBound_NumericUpDown;
        private System.Windows.Forms.Label MaxLoadValue_Label;
        private System.Windows.Forms.Label MOEValue_Label;
        private System.Windows.Forms.Label MORValue_Label;
        private System.Windows.Forms.Label MaxCylindricalDeflectionValue_Label;
        private System.Windows.Forms.Button GraphData_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label SpecimenInfomation_Label;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TextBox Span_TaxtBox;
        private System.Windows.Forms.TextBox Depth_TextBox;
        private System.Windows.Forms.TextBox Width_TextBox;
        private System.Windows.Forms.Button GraphRegression_Button;
        private System.Windows.Forms.Label FilePath_Label;
        private System.Windows.Forms.Label CurrentSpecimen_Label;
        private System.Windows.Forms.Label CurrentSpecimenValue_Label;
        private System.Windows.Forms.ErrorProvider CalculateProperties_errorProvider;
        private System.Windows.Forms.ErrorProvider LowerBoundNumericUpDown_errorProvider;
        private System.Windows.Forms.ErrorProvider UpperBoundNumericUpDown_errorProvider;
        private System.Windows.Forms.PictureBox Logo_pictureBox;
    }
}

