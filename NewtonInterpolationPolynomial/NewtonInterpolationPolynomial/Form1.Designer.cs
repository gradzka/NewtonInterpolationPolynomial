﻿namespace NewtonInterpolationPolynomial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.N_step_equi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.N_n_equi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BAddNodeEquidistant = new System.Windows.Forms.Button();
            this.N_x_0_equi = new System.Windows.Forms.NumericUpDown();
            this.GBManual = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.N_x_i = new System.Windows.Forms.NumericUpDown();
            this.BAddNodeManual = new System.Windows.Forms.Button();
            this.GBChebyshev = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BAddNodeChebyshev = new System.Windows.Forms.Button();
            this.N_n_Cheb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.N_a_Cheb = new System.Windows.Forms.NumericUpDown();
            this.N_b_Cheb = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.LAError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.NMIN = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NMAX = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.TBInterpolationPolynomial = new System.Windows.Forms.TextBox();
            this.BClipboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LPolynomial = new System.Windows.Forms.Label();
            this.CBPolynomial = new System.Windows.Forms.ComboBox();
            this.BInterpolate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.GBEquidistant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_step_equi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_n_equi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_0_equi)).BeginInit();
            this.GBManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).BeginInit();
            this.GBChebyshev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_n_Cheb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_a_Cheb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_b_Cheb)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMAX)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.03797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.962025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1114, 581);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DGVPoints, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(314, 575);
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
            this.DGVPoints.Location = new System.Drawing.Point(3, 337);
            this.DGVPoints.Name = "DGVPoints";
            this.DGVPoints.RowHeadersVisible = false;
            this.DGVPoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPoints.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPoints.Size = new System.Drawing.Size(308, 189);
            this.DGVPoints.TabIndex = 5;
            this.DGVPoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPoints_CellClick);
            this.DGVPoints.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVPoints_CellPainting);
            this.DGVPoints.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGVPoints_CellValidating);
            // 
            // ID
            // 
            this.ID.HeaderText = "i";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 50;
            // 
            // x_i
            // 
            this.x_i.HeaderText = "x_i";
            this.x_i.Name = "x_i";
            this.x_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.x_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.x_i.Width = 90;
            // 
            // y_i
            // 
            this.y_i.HeaderText = "y_i";
            this.y_i.Name = "y_i";
            this.y_i.ReadOnly = true;
            this.y_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.y_i.Width = 90;
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
            this.Edit.Visible = false;
            this.Edit.Width = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBChebyshev);
            this.groupBox2.Controls.Add(this.RBEquidistant);
            this.groupBox2.Controls.Add(this.RBManual);
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
            this.RBChebyshev.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
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
            this.RBEquidistant.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // RBManual
            // 
            this.RBManual.AutoSize = true;
            this.RBManual.Checked = true;
            this.RBManual.Location = new System.Drawing.Point(6, 23);
            this.RBManual.Name = "RBManual";
            this.RBManual.Size = new System.Drawing.Size(135, 17);
            this.RBManual.TabIndex = 0;
            this.RBManual.TabStop = true;
            this.RBManual.Text = "(1) Add nodes manually";
            this.RBManual.UseVisualStyleBackColor = true;
            this.RBManual.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
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
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.26846F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.73154F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(308, 233);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // GBEquidistant
            // 
            this.GBEquidistant.Controls.Add(this.label4);
            this.GBEquidistant.Controls.Add(this.N_step_equi);
            this.GBEquidistant.Controls.Add(this.label3);
            this.GBEquidistant.Controls.Add(this.N_n_equi);
            this.GBEquidistant.Controls.Add(this.label2);
            this.GBEquidistant.Controls.Add(this.BAddNodeEquidistant);
            this.GBEquidistant.Controls.Add(this.N_x_0_equi);
            this.GBEquidistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBEquidistant.Enabled = false;
            this.GBEquidistant.Location = new System.Drawing.Point(3, 62);
            this.GBEquidistant.Name = "GBEquidistant";
            this.GBEquidistant.Size = new System.Drawing.Size(302, 82);
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
            // N_step_equi
            // 
            this.N_step_equi.DecimalPlaces = 2;
            this.N_step_equi.Location = new System.Drawing.Point(232, 19);
            this.N_step_equi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.N_step_equi.Name = "N_step_equi";
            this.N_step_equi.Size = new System.Drawing.Size(65, 20);
            this.N_step_equi.TabIndex = 9;
            this.toolTip1.SetToolTip(this.N_step_equi, "min = 0,01\r\nmax = 10\r\ninc = 0,01");
            this.N_step_equi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // N_n_equi
            // 
            this.N_n_equi.Location = new System.Drawing.Point(124, 19);
            this.N_n_equi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_n_equi.Name = "N_n_equi";
            this.N_n_equi.Size = new System.Drawing.Size(65, 20);
            this.N_n_equi.TabIndex = 7;
            this.toolTip1.SetToolTip(this.N_n_equi, "min = 0\r\nmax = 100\r\ninc = 1");
            this.N_n_equi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.BAddNodeEquidistant.Location = new System.Drawing.Point(154, 45);
            this.BAddNodeEquidistant.Name = "BAddNodeEquidistant";
            this.BAddNodeEquidistant.Size = new System.Drawing.Size(143, 21);
            this.BAddNodeEquidistant.TabIndex = 4;
            this.BAddNodeEquidistant.Text = "Clear DGV and Add nodes";
            this.BAddNodeEquidistant.UseVisualStyleBackColor = false;
            this.BAddNodeEquidistant.Click += new System.EventHandler(this.BAddNodeEquidistant_Click);
            // 
            // N_x_0_equi
            // 
            this.N_x_0_equi.DecimalPlaces = 2;
            this.N_x_0_equi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.N_x_0_equi.Location = new System.Drawing.Point(35, 19);
            this.N_x_0_equi.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N_x_0_equi.Name = "N_x_0_equi";
            this.N_x_0_equi.Size = new System.Drawing.Size(65, 20);
            this.N_x_0_equi.TabIndex = 5;
            this.toolTip1.SetToolTip(this.N_x_0_equi, "min = -100\r\nmax = 100\r\ninc = 0,01");
            // 
            // GBManual
            // 
            this.GBManual.Controls.Add(this.label1);
            this.GBManual.Controls.Add(this.N_x_i);
            this.GBManual.Controls.Add(this.BAddNodeManual);
            this.GBManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBManual.Location = new System.Drawing.Point(3, 3);
            this.GBManual.Name = "GBManual";
            this.GBManual.Size = new System.Drawing.Size(302, 53);
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
            this.BAddNodeManual.Text = "Add node";
            this.BAddNodeManual.UseVisualStyleBackColor = false;
            this.BAddNodeManual.Click += new System.EventHandler(this.BAddNode_Click);
            // 
            // GBChebyshev
            // 
            this.GBChebyshev.Controls.Add(this.label5);
            this.GBChebyshev.Controls.Add(this.BAddNodeChebyshev);
            this.GBChebyshev.Controls.Add(this.N_n_Cheb);
            this.GBChebyshev.Controls.Add(this.label6);
            this.GBChebyshev.Controls.Add(this.N_a_Cheb);
            this.GBChebyshev.Controls.Add(this.N_b_Cheb);
            this.GBChebyshev.Controls.Add(this.label7);
            this.GBChebyshev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBChebyshev.Enabled = false;
            this.GBChebyshev.Location = new System.Drawing.Point(3, 150);
            this.GBChebyshev.Name = "GBChebyshev";
            this.GBChebyshev.Size = new System.Drawing.Size(302, 80);
            this.GBChebyshev.TabIndex = 2;
            this.GBChebyshev.TabStop = false;
            this.GBChebyshev.Text = "(3) Use Chebyshew nodes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 23);
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
            this.BAddNodeChebyshev.Location = new System.Drawing.Point(153, 45);
            this.BAddNodeChebyshev.Name = "BAddNodeChebyshev";
            this.BAddNodeChebyshev.Size = new System.Drawing.Size(143, 21);
            this.BAddNodeChebyshev.TabIndex = 5;
            this.BAddNodeChebyshev.Text = "Clear DGV and Add nodes";
            this.BAddNodeChebyshev.UseVisualStyleBackColor = false;
            this.BAddNodeChebyshev.Click += new System.EventHandler(this.BAddNodeChebyshev_Click);
            // 
            // N_n_Cheb
            // 
            this.N_n_Cheb.Location = new System.Drawing.Point(231, 19);
            this.N_n_Cheb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_n_Cheb.Name = "N_n_Cheb";
            this.N_n_Cheb.Size = new System.Drawing.Size(65, 20);
            this.N_n_Cheb.TabIndex = 15;
            this.toolTip1.SetToolTip(this.N_n_Cheb, "min = 1");
            this.N_n_Cheb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "b =";
            // 
            // N_a_Cheb
            // 
            this.N_a_Cheb.DecimalPlaces = 2;
            this.N_a_Cheb.Location = new System.Drawing.Point(31, 19);
            this.N_a_Cheb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N_a_Cheb.Name = "N_a_Cheb";
            this.N_a_Cheb.Size = new System.Drawing.Size(65, 20);
            this.N_a_Cheb.TabIndex = 11;
            this.toolTip1.SetToolTip(this.N_a_Cheb, "min = -100\r\nmax = 100\r\ninc = 0,01");
            this.N_a_Cheb.Validating += new System.ComponentModel.CancelEventHandler(this.N_a_Cheb_Validating);
            // 
            // N_b_Cheb
            // 
            this.N_b_Cheb.DecimalPlaces = 2;
            this.N_b_Cheb.Location = new System.Drawing.Point(124, 19);
            this.N_b_Cheb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N_b_Cheb.Name = "N_b_Cheb";
            this.N_b_Cheb.Size = new System.Drawing.Size(65, 20);
            this.N_b_Cheb.TabIndex = 13;
            this.toolTip1.SetToolTip(this.N_b_Cheb, "min = -100\r\nmax = 100\r\ninc = 0,01\r\n");
            this.N_b_Cheb.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.N_b_Cheb.Validating += new System.ComponentModel.CancelEventHandler(this.N_b_Cheb_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "a =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 46);
            this.label8.TabIndex = 8;
            this.label8.Text = "Click Interpolate after deleting node to calculate the\r\n interpolation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.plotView1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.LAError, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(788, 575);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(3, 3);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(782, 466);
            this.plotView1.TabIndex = 1;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // LAError
            // 
            this.LAError.AutoSize = true;
            this.LAError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAError.Location = new System.Drawing.Point(3, 500);
            this.LAError.Name = "LAError";
            this.LAError.Size = new System.Drawing.Size(782, 28);
            this.LAError.TabIndex = 2;
            this.LAError.Text = "Max absolute error: ? on the interval <-3; 3> with step: 0.1";
            this.LAError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.NMIN);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NMAX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 22);
            this.panel1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(675, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "x MAX:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NMIN
            // 
            this.NMIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.NMIN.Enabled = false;
            this.NMIN.Location = new System.Drawing.Point(40, 0);
            this.NMIN.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NMIN.Name = "NMIN";
            this.NMIN.Size = new System.Drawing.Size(65, 20);
            this.NMIN.TabIndex = 20;
            this.toolTip1.SetToolTip(this.NMIN, "min = -100\r\nmax = 100\r\ninc = 0,01");
            this.NMIN.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.NMIN.ValueChanged += new System.EventHandler(this.NMIN_MAX_ValueChanged);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label9.Size = new System.Drawing.Size(40, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "x MIN:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NMAX
            // 
            this.NMAX.Dock = System.Windows.Forms.DockStyle.Right;
            this.NMAX.Enabled = false;
            this.NMAX.Location = new System.Drawing.Point(717, 0);
            this.NMAX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NMAX.Name = "NMAX";
            this.NMAX.Size = new System.Drawing.Size(65, 20);
            this.NMAX.TabIndex = 17;
            this.toolTip1.SetToolTip(this.NMAX, "min = -100\r\nmax = 100\r\ninc = 0,01");
            this.NMAX.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NMAX.ValueChanged += new System.EventHandler(this.NMIN_MAX_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel8.Controls.Add(this.TBInterpolationPolynomial, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.BClipboard, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 531);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(782, 41);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // TBInterpolationPolynomial
            // 
            this.TBInterpolationPolynomial.BackColor = System.Drawing.Color.LightSalmon;
            this.TBInterpolationPolynomial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBInterpolationPolynomial.Location = new System.Drawing.Point(3, 3);
            this.TBInterpolationPolynomial.MaxLength = 10000000;
            this.TBInterpolationPolynomial.Multiline = true;
            this.TBInterpolationPolynomial.Name = "TBInterpolationPolynomial";
            this.TBInterpolationPolynomial.ReadOnly = true;
            this.TBInterpolationPolynomial.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBInterpolationPolynomial.Size = new System.Drawing.Size(696, 35);
            this.TBInterpolationPolynomial.TabIndex = 4;
            this.TBInterpolationPolynomial.Text = "? Interpolation polynomial ?";
            this.TBInterpolationPolynomial.WordWrap = false;
            // 
            // BClipboard
            // 
            this.BClipboard.BackColor = System.Drawing.Color.LightSalmon;
            this.BClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BClipboard.FlatAppearance.BorderSize = 0;
            this.BClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClipboard.Location = new System.Drawing.Point(705, 3);
            this.BClipboard.Name = "BClipboard";
            this.BClipboard.Size = new System.Drawing.Size(74, 35);
            this.BClipboard.TabIndex = 5;
            this.BClipboard.Text = "Copy to clipboard";
            this.BClipboard.UseVisualStyleBackColor = false;
            this.BClipboard.Click += new System.EventHandler(this.BClipboard_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BInterpolate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 590);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1114, 39);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.LPolynomial, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.CBPolynomial, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(788, 33);
            this.tableLayoutPanel6.TabIndex = 18;
            // 
            // LPolynomial
            // 
            this.LPolynomial.BackColor = System.Drawing.Color.LimeGreen;
            this.LPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LPolynomial.Location = new System.Drawing.Point(2, 11);
            this.LPolynomial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.LPolynomial.Name = "LPolynomial";
            this.LPolynomial.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LPolynomial.Size = new System.Drawing.Size(36, 21);
            this.LPolynomial.TabIndex = 2;
            this.LPolynomial.Text = "f(x) = ";
            this.LPolynomial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBPolynomial
            // 
            this.CBPolynomial.BackColor = System.Drawing.SystemColors.Window;
            this.CBPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBPolynomial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPolynomial.FormattingEnabled = true;
            this.CBPolynomial.Location = new System.Drawing.Point(43, 11);
            this.CBPolynomial.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.CBPolynomial.Name = "CBPolynomial";
            this.CBPolynomial.Size = new System.Drawing.Size(742, 21);
            this.CBPolynomial.TabIndex = 2;
            this.CBPolynomial.SelectedIndexChanged += new System.EventHandler(this.CBPolynomial_SelectedIndexChanged);
            // 
            // BInterpolate
            // 
            this.BInterpolate.BackColor = System.Drawing.Color.Turquoise;
            this.BInterpolate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BInterpolate.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.BInterpolate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInterpolate.Location = new System.Drawing.Point(3, 13);
            this.BInterpolate.Name = "BInterpolate";
            this.BInterpolate.Size = new System.Drawing.Size(314, 23);
            this.BInterpolate.TabIndex = 19;
            this.BInterpolate.Text = "Interpolate";
            this.BInterpolate.UseVisualStyleBackColor = false;
            this.BInterpolate.Click += new System.EventHandler(this.BInterpolate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newton Interpolation Polynomial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.GBEquidistant.ResumeLayout(false);
            this.GBEquidistant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_step_equi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_n_equi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_0_equi)).EndInit();
            this.GBManual.ResumeLayout(false);
            this.GBManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).EndInit();
            this.GBChebyshev.ResumeLayout(false);
            this.GBChebyshev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_n_Cheb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_a_Cheb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_b_Cheb)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMAX)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGVPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBChebyshev;
        private System.Windows.Forms.RadioButton RBEquidistant;
        private System.Windows.Forms.RadioButton RBManual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox GBEquidistant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown N_step_equi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown N_n_equi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAddNodeEquidistant;
        private System.Windows.Forms.NumericUpDown N_x_0_equi;
        private System.Windows.Forms.GroupBox GBManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown N_x_i;
        private System.Windows.Forms.Button BAddNodeManual;
        private System.Windows.Forms.GroupBox GBChebyshev;
        private System.Windows.Forms.Button BAddNodeChebyshev;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown N_n_Cheb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown N_a_Cheb;
        private System.Windows.Forms.NumericUpDown N_b_Cheb;
        private System.Windows.Forms.Label label7;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label LPolynomial;
        private System.Windows.Forms.ComboBox CBPolynomial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label LAError;
        private System.Windows.Forms.Button BInterpolate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NMAX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NMIN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_i;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TextBox TBInterpolationPolynomial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button BClipboard;
        private System.Windows.Forms.Label label8;
    }
}

