using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonInterpolationPolynomial
{
    public partial class Form1 : Form
    {
        //differential sums
        Dictionary<int, double> difSums = new Dictionary<int, double>();
        Dictionary<string, Func<double, double>> functions = new Dictionary<string, Func<double, double>>();

        public Form1()
        {
            InitializeComponent();
            functions.Add("sin(x) [rad]", (x) => Math.Sin(x));
            functions.Add("-x^3 - 3x^2 + 4x + 12", (x) => -x * x *x - 3 * x * x + 4 * x + 12);
            functions.Add("0.05(x+4)(x+2)(x+1)(x-1)(x-3) + 2", (x) => 0.05 *(x + 4) *(x + 2) *(x + 1) *(x - 1) * (x - 3) + 2);
            CBPolynomial.DataSource = new BindingSource(functions, null);
            CBPolynomial.DisplayMember = "Key";
            CBPolynomial.ValueMember = "Value";
        }
        private void DGVPoints_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            else if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void AddRowToDGVAndInterpolate()
        {
            //After inserting a row
            int i = Int32.Parse(DGVPoints.Rows[DGVPoints.Rows.Count - 1].Cells[0].Value.ToString());
            double counter = 0.0;
            double denominator = 1.0;
            double sum = 0.0;
            int j = -1;

            counter = Double.Parse(DGVPoints.Rows[i].Cells[2].Value.ToString());
            if (i==0)
            {
                sum = counter;
            }
            else
            {
                for (j = 0; j < difSums.Count; j++)
                {
                    if (j!=i)
                    {
                        denominator *= Double.Parse(DGVPoints.Rows[i].Cells[1].Value.ToString())
                            - Double.Parse(DGVPoints.Rows[j].Cells[1].Value.ToString());
                    }
                }
                sum = difSums[difSums.Count-1] + counter / denominator;
            }
            difSums.Add(difSums.Count, sum);
        }
        private void DeleteRowAndAndIterpolate()
        {
            //Remove from dict
        }

        private void BAddNode_Click(object sender, EventArgs e)
        {
            decimal x_i = N_x_i.Value;
            bool can_or_not = true;
            for (int i = 0; i < DGVPoints.RowCount; i++)
            {
                if ((decimal)DGVPoints[1, i].Value == x_i)
                {
                    can_or_not = false;
                    break;
                }
            }
            if (can_or_not == true)
            {
                this.DGVPoints.Rows.Add(DGVPoints.RowCount, x_i, ((Func<double, double>)(CBPolynomial.SelectedValue)).DynamicInvoke(Convert.ToDouble(x_i)));
            }
            else
            {
                MessageBox.Show("You can't add node with existing argument: " + x_i, "Error");
            }
        }

        private void DGVPoints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                int rowIndex = -1;
                rowIndex = e.RowIndex; //in what row cell has been clicked

                if (e.ColumnIndex == 3) //delete
                {
                    //remove row
                    DGVPoints.Rows.RemoveAt(rowIndex);
                    //correct iterative order
                    for (int i = rowIndex; i < DGVPoints.Rows.Count; i++)
                    {
                        DGVPoints[0, i].Value = i;
                    }
                  //calculate diff sums from rowIndex
                }
                else if (e.ColumnIndex == 4) //edit
                {

                }
            }
        }

        private void CBPolynomial_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGVPoints.Rows.Count; i++)
            {
                DGVPoints[2, i].Value = ((Func<double, double>)(CBPolynomial.SelectedValue)).DynamicInvoke(Convert.ToDouble(DGVPoints[1, i].Value));
            }
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            plotView1.Model = new PlotModel();
            string title = ((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Key;
            plotView1.Model.Series.Add(new OxyPlot.Series.FunctionSeries((Func<double, double>)CBPolynomial.SelectedValue,-3,3, 0.1, title));
        }
    }
}
