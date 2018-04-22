namespace NewtonInterpolationPolynomial
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVPoints = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBChebyshev = new System.Windows.Forms.RadioButton();
            this.RBEquidistant = new System.Windows.Forms.RadioButton();
            this.RBManual = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.GBEquidistant = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BAddNodeEquidistant = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GBManual = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.N_x_i = new System.Windows.Forms.NumericUpDown();
            this.BAddNodeManual = new System.Windows.Forms.Button();
            this.GBChebyshev = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BAddNodeChebyshev = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LPolynomial = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.CBPolynomial = new System.Windows.Forms.ComboBox();
            this.BDraw = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.GBEquidistant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GBManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).BeginInit();
            this.GBChebyshev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.00411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.995885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.plotView1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1114, 544);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DGVPoints, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(314, 538);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DGVPoints
            // 
            this.DGVPoints.AllowUserToAddRows = false;
            this.DGVPoints.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.x_i,
            this.y_i,
            this.Del,
            this.Edit});
            this.DGVPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPoints.Location = new System.Drawing.Point(3, 338);
            this.DGVPoints.Name = "DGVPoints";
            this.DGVPoints.RowHeadersVisible = false;
            this.DGVPoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPoints.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPoints.Size = new System.Drawing.Size(308, 197);
            this.DGVPoints.TabIndex = 5;
            this.DGVPoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPoints_CellClick);
            this.DGVPoints.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVPoints_CellPainting);
            // 
            // ID
            // 
            this.ID.HeaderText = "i";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 46;
            // 
            // x_i
            // 
            this.x_i.HeaderText = "x_i";
            this.x_i.Name = "x_i";
            this.x_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.x_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.x_i.Width = 65;
            // 
            // y_i
            // 
            this.y_i.HeaderText = "y_i";
            this.y_i.Name = "y_i";
            this.y_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.y_i.Width = 65;
            // 
            // Del
            // 
            this.Del.HeaderText = "Delete";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Text = "Delete";
            this.Del.Width = 56;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBChebyshev);
            this.groupBox2.Controls.Add(this.RBEquidistant);
            this.groupBox2.Controls.Add(this.RBManual);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose option";
            // 
            // RBChebyshev
            // 
            this.RBChebyshev.AutoSize = true;
            this.RBChebyshev.Location = new System.Drawing.Point(6, 69);
            this.RBChebyshev.Name = "RBChebyshev";
            this.RBChebyshev.Size = new System.Drawing.Size(147, 17);
            this.RBChebyshev.TabIndex = 2;
            this.RBChebyshev.TabStop = true;
            this.RBChebyshev.Text = "(3) Use Chebyshev nodes";
            this.RBChebyshev.UseVisualStyleBackColor = true;
            // 
            // RBEquidistant
            // 
            this.RBEquidistant.AutoSize = true;
            this.RBEquidistant.Location = new System.Drawing.Point(6, 46);
            this.RBEquidistant.Name = "RBEquidistant";
            this.RBEquidistant.Size = new System.Drawing.Size(145, 17);
            this.RBEquidistant.TabIndex = 1;
            this.RBEquidistant.TabStop = true;
            this.RBEquidistant.Text = "(2) Use equidistant nodes";
            this.RBEquidistant.UseVisualStyleBackColor = true;
            // 
            // RBManual
            // 
            this.RBManual.AutoSize = true;
            this.RBManual.Location = new System.Drawing.Point(6, 23);
            this.RBManual.Name = "RBManual";
            this.RBManual.Size = new System.Drawing.Size(135, 17);
            this.RBManual.TabIndex = 0;
            this.RBManual.TabStop = true;
            this.RBManual.Text = "(1) Add nodes manually";
            this.RBManual.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.GBEquidistant, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.GBManual, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.GBChebyshev, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(308, 234);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // GBEquidistant
            // 
            this.GBEquidistant.Controls.Add(this.label4);
            this.GBEquidistant.Controls.Add(this.numericUpDown3);
            this.GBEquidistant.Controls.Add(this.label3);
            this.GBEquidistant.Controls.Add(this.numericUpDown2);
            this.GBEquidistant.Controls.Add(this.label2);
            this.GBEquidistant.Controls.Add(this.BAddNodeEquidistant);
            this.GBEquidistant.Controls.Add(this.numericUpDown1);
            this.GBEquidistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBEquidistant.Location = new System.Drawing.Point(3, 81);
            this.GBEquidistant.Name = "GBEquidistant";
            this.GBEquidistant.Size = new System.Drawing.Size(302, 72);
            this.GBEquidistant.TabIndex = 1;
            this.GBEquidistant.TabStop = false;
            this.GBEquidistant.Text = "(2) Use equidistant nodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "step =";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(232, 19);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown3.TabIndex = 9;
            this.toolTip1.SetToolTip(this.numericUpDown3, "min = 0\r\nmax = 10\r\ninc = 0,01");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "n =";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(125, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numericUpDown2, "min = 0\r\nmax = 100\r\ninc = 1");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x_0 =";
            // 
            // BAddNodeEquidistant
            // 
            this.BAddNodeEquidistant.BackColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeEquidistant.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeEquidistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddNodeEquidistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BAddNodeEquidistant.Location = new System.Drawing.Point(231, 45);
            this.BAddNodeEquidistant.Name = "BAddNodeEquidistant";
            this.BAddNodeEquidistant.Size = new System.Drawing.Size(65, 21);
            this.BAddNodeEquidistant.TabIndex = 4;
            this.BAddNodeEquidistant.Text = "Add";
            this.BAddNodeEquidistant.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(35, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numericUpDown1, "min = -100\r\nmax = 100\r\ninc = 0,01");
            // 
            // GBManual
            // 
            this.GBManual.Controls.Add(this.label1);
            this.GBManual.Controls.Add(this.N_x_i);
            this.GBManual.Controls.Add(this.BAddNodeManual);
            this.GBManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBManual.Location = new System.Drawing.Point(3, 3);
            this.GBManual.Name = "GBManual";
            this.GBManual.Size = new System.Drawing.Size(302, 72);
            this.GBManual.TabIndex = 1;
            this.GBManual.TabStop = false;
            this.GBManual.Text = "(1) Add nodes manually";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x_i =";
            // 
            // N_x_i
            // 
            this.N_x_i.DecimalPlaces = 2;
            this.N_x_i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.N_x_i.Location = new System.Drawing.Point(35, 19);
            this.N_x_i.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N_x_i.Name = "N_x_i";
            this.N_x_i.Size = new System.Drawing.Size(65, 20);
            this.N_x_i.TabIndex = 3;
            this.toolTip1.SetToolTip(this.N_x_i, "min = -100\r\nmax = 100\r\ninc = 0,01\r\n");
            // 
            // BAddNodeManual
            // 
            this.BAddNodeManual.BackColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeManual.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddNodeManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BAddNodeManual.Location = new System.Drawing.Point(106, 18);
            this.BAddNodeManual.Name = "BAddNodeManual";
            this.BAddNodeManual.Size = new System.Drawing.Size(65, 21);
            this.BAddNodeManual.TabIndex = 2;
            this.BAddNodeManual.Text = "Add";
            this.BAddNodeManual.UseVisualStyleBackColor = false;
            this.BAddNodeManual.Click += new System.EventHandler(this.BAddNode_Click);
            // 
            // GBChebyshev
            // 
            this.GBChebyshev.Controls.Add(this.label5);
            this.GBChebyshev.Controls.Add(this.BAddNodeChebyshev);
            this.GBChebyshev.Controls.Add(this.numericUpDown4);
            this.GBChebyshev.Controls.Add(this.label6);
            this.GBChebyshev.Controls.Add(this.numericUpDown6);
            this.GBChebyshev.Controls.Add(this.numericUpDown5);
            this.GBChebyshev.Controls.Add(this.label7);
            this.GBChebyshev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBChebyshev.Location = new System.Drawing.Point(3, 159);
            this.GBChebyshev.Name = "GBChebyshev";
            this.GBChebyshev.Size = new System.Drawing.Size(302, 72);
            this.GBChebyshev.TabIndex = 2;
            this.GBChebyshev.TabStop = false;
            this.GBChebyshev.Text = "(3) Use Chebyshew nodes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "n =";
            // 
            // BAddNodeChebyshev
            // 
            this.BAddNodeChebyshev.BackColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeChebyshev.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BAddNodeChebyshev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddNodeChebyshev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BAddNodeChebyshev.Location = new System.Drawing.Point(231, 45);
            this.BAddNodeChebyshev.Name = "BAddNodeChebyshev";
            this.BAddNodeChebyshev.Size = new System.Drawing.Size(65, 21);
            this.BAddNodeChebyshev.TabIndex = 5;
            this.BAddNodeChebyshev.Text = "Add";
            this.BAddNodeChebyshev.UseVisualStyleBackColor = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(123, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown4.TabIndex = 15;
            this.toolTip1.SetToolTip(this.numericUpDown4, "min = 0");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "x_n-1 =";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown6.Location = new System.Drawing.Point(35, 19);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown6.TabIndex = 11;
            this.toolTip1.SetToolTip(this.numericUpDown6, "min = -100\r\nmax = 100\r\ninc = 0,01");
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown5.Location = new System.Drawing.Point(231, 19);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown5.TabIndex = 13;
            this.toolTip1.SetToolTip(this.numericUpDown5, "min = -100\r\nmax = 100\r\ninc = 0,01\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "x_0 =";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.LPolynomial, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 553);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1114, 36);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LPolynomial
            // 
            this.LPolynomial.AutoSize = true;
            this.LPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LPolynomial.Location = new System.Drawing.Point(3, 12);
            this.LPolynomial.Margin = new System.Windows.Forms.Padding(3, 0, 0, 8);
            this.LPolynomial.Name = "LPolynomial";
            this.LPolynomial.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LPolynomial.Size = new System.Drawing.Size(269, 16);
            this.LPolynomial.TabIndex = 2;
            this.LPolynomial.Text = "f(x) = ";
            this.LPolynomial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel6.Controls.Add(this.CBPolynomial, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BDraw, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(275, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(836, 30);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // CBPolynomial
            // 
            this.CBPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBPolynomial.FormattingEnabled = true;
            this.CBPolynomial.Location = new System.Drawing.Point(3, 6);
            this.CBPolynomial.Name = "CBPolynomial";
            this.CBPolynomial.Size = new System.Drawing.Size(765, 21);
            this.CBPolynomial.TabIndex = 2;
            // 
            // BDraw
            // 
            this.BDraw.BackColor = System.Drawing.Color.LightBlue;
            this.BDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BDraw.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.BDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BDraw.Location = new System.Drawing.Point(774, 6);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(59, 21);
            this.BDraw.TabIndex = 16;
            this.BDraw.Text = "Draw";
            this.toolTip1.SetToolTip(this.BDraw, "Draw f(x) and its interpolation");
            this.BDraw.UseVisualStyleBackColor = false;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(323, 3);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(788, 538);
            this.plotView1.TabIndex = 1;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newton Interpolation Polynomial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.GBEquidistant.ResumeLayout(false);
            this.GBEquidistant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GBManual.ResumeLayout(false);
            this.GBManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).EndInit();
            this.GBChebyshev.ResumeLayout(false);
            this.GBChebyshev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGVPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LPolynomial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBChebyshev;
        private System.Windows.Forms.RadioButton RBEquidistant;
        private System.Windows.Forms.RadioButton RBManual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox GBEquidistant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAddNodeEquidistant;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox GBManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown N_x_i;
        private System.Windows.Forms.Button BAddNodeManual;
        private System.Windows.Forms.GroupBox GBChebyshev;
        private System.Windows.Forms.Button BAddNodeChebyshev;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_i;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox CBPolynomial;
        private System.Windows.Forms.Button BDraw;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}

