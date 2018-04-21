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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVPoints = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.N_x_i = new System.Windows.Forms.NumericUpDown();
            this.BAddNode = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CBPolynomial = new System.Windows.Forms.ComboBox();
            this.LPolynomial = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBManual = new System.Windows.Forms.RadioButton();
            this.RBEquidistant = new System.Windows.Forms.RadioButton();
            this.RBChebyshev = new System.Windows.Forms.RadioButton();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.y_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(965, 459);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DGVPoints, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(266, 453);
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
            this.DGVPoints.Location = new System.Drawing.Point(3, 219);
            this.DGVPoints.Name = "DGVPoints";
            this.DGVPoints.RowHeadersVisible = false;
            this.DGVPoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPoints.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPoints.Size = new System.Drawing.Size(260, 177);
            this.DGVPoints.TabIndex = 5;
            this.DGVPoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPoints_CellClick);
            this.DGVPoints.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVPoints_CellPainting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.N_x_i);
            this.groupBox1.Controls.Add(this.BAddNode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add node";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 21);
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
            this.N_x_i.Location = new System.Drawing.Point(123, 19);
            this.N_x_i.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.N_x_i.Name = "N_x_i";
            this.N_x_i.Size = new System.Drawing.Size(65, 20);
            this.N_x_i.TabIndex = 3;
            // 
            // BAddNode
            // 
            this.BAddNode.BackColor = System.Drawing.Color.YellowGreen;
            this.BAddNode.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BAddNode.Location = new System.Drawing.Point(194, 19);
            this.BAddNode.Name = "BAddNode";
            this.BAddNode.Size = new System.Drawing.Size(60, 21);
            this.BAddNode.TabIndex = 2;
            this.BAddNode.Text = "Add";
            this.BAddNode.UseVisualStyleBackColor = false;
            this.BAddNode.Click += new System.EventHandler(this.BAddNode_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.CBPolynomial, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.LPolynomial, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 468);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(965, 30);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // CBPolynomial
            // 
            this.CBPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBPolynomial.FormattingEnabled = true;
            this.CBPolynomial.Location = new System.Drawing.Point(275, 6);
            this.CBPolynomial.Name = "CBPolynomial";
            this.CBPolynomial.Size = new System.Drawing.Size(687, 21);
            this.CBPolynomial.TabIndex = 1;
            this.CBPolynomial.SelectedIndexChanged += new System.EventHandler(this.CBPolynomial_SelectedIndexChanged);
            // 
            // LPolynomial
            // 
            this.LPolynomial.AutoSize = true;
            this.LPolynomial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LPolynomial.Location = new System.Drawing.Point(3, 9);
            this.LPolynomial.Margin = new System.Windows.Forms.Padding(3, 0, 0, 8);
            this.LPolynomial.Name = "LPolynomial";
            this.LPolynomial.Size = new System.Drawing.Size(269, 13);
            this.LPolynomial.TabIndex = 2;
            this.LPolynomial.Text = "Polynomial:\r\n";
            this.LPolynomial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBChebyshev);
            this.groupBox2.Controls.Add(this.RBEquidistant);
            this.groupBox2.Controls.Add(this.RBManual);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 102);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose option";
            // 
            // RBManual
            // 
            this.RBManual.AutoSize = true;
            this.RBManual.Location = new System.Drawing.Point(6, 23);
            this.RBManual.Name = "RBManual";
            this.RBManual.Size = new System.Drawing.Size(120, 17);
            this.RBManual.TabIndex = 0;
            this.RBManual.TabStop = true;
            this.RBManual.Text = "Add nodes manually";
            this.RBManual.UseVisualStyleBackColor = true;
            // 
            // RBEquidistant
            // 
            this.RBEquidistant.AutoSize = true;
            this.RBEquidistant.Location = new System.Drawing.Point(6, 46);
            this.RBEquidistant.Name = "RBEquidistant";
            this.RBEquidistant.Size = new System.Drawing.Size(130, 17);
            this.RBEquidistant.TabIndex = 1;
            this.RBEquidistant.TabStop = true;
            this.RBEquidistant.Text = "Use equidistant nodes";
            this.RBEquidistant.UseVisualStyleBackColor = true;
            // 
            // RBChebyshev
            // 
            this.RBChebyshev.AutoSize = true;
            this.RBChebyshev.Location = new System.Drawing.Point(6, 69);
            this.RBChebyshev.Name = "RBChebyshev";
            this.RBChebyshev.Size = new System.Drawing.Size(132, 17);
            this.RBChebyshev.TabIndex = 2;
            this.RBChebyshev.TabStop = true;
            this.RBChebyshev.Text = "Use Chebyshev nodes";
            this.RBChebyshev.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 40;
            // 
            // Del
            // 
            this.Del.HeaderText = "Delete";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Text = "Delete";
            this.Del.Width = 40;
            // 
            // y_i
            // 
            this.y_i.HeaderText = "y_i";
            this.y_i.Name = "y_i";
            this.y_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.y_i.Width = 60;
            // 
            // x_i
            // 
            this.x_i.HeaderText = "x_i";
            this.x_i.Name = "x_i";
            this.x_i.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.x_i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.x_i.Width = 60;
            // 
            // ID
            // 
            this.ID.HeaderText = "i";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Newton Interpolation Polynomial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_x_i)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGVPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox CBPolynomial;
        private System.Windows.Forms.Label LPolynomial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAddNode;
        private System.Windows.Forms.NumericUpDown N_x_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBChebyshev;
        private System.Windows.Forms.RadioButton RBEquidistant;
        private System.Windows.Forms.RadioButton RBManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_i;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}

