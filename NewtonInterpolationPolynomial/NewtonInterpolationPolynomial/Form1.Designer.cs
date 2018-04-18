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
            this.DGVPoints = new System.Windows.Forms.DataGridView();
            this.LFormula = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LFormula, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.68313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.31687F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.DGVPoints, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 425);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DGVPoints
            // 
            this.DGVPoints.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.x_i,
            this.y_i,
            this.Del});
            this.DGVPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPoints.Location = new System.Drawing.Point(3, 3);
            this.DGVPoints.Name = "DGVPoints";
            this.DGVPoints.Size = new System.Drawing.Size(259, 419);
            this.DGVPoints.TabIndex = 0;
            this.DGVPoints.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVPoints_CellPainting);
            // 
            // LFormula
            // 
            this.LFormula.AutoSize = true;
            this.LFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFormula.Location = new System.Drawing.Point(3, 431);
            this.LFormula.Name = "LFormula";
            this.LFormula.Size = new System.Drawing.Size(792, 55);
            this.LFormula.TabIndex = 1;
            this.LFormula.Text = "Formula:";
            this.LFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.HeaderText = "i";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // x_i
            // 
            this.x_i.HeaderText = "x_i";
            this.x_i.Name = "x_i";
            this.x_i.Width = 60;
            // 
            // y_i
            // 
            this.y_i.HeaderText = "y_i";
            this.y_i.Name = "y_i";
            this.y_i.Width = 60;
            // 
            // Del
            // 
            this.Del.HeaderText = "";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Del.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Newton Interpolation Polynomial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DGVPoints;
        private System.Windows.Forms.Label LFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_i;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
    }
}

