using OxyPlot;
using OxyPlot.Series;
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
        OxyPlot.Series.LineSeries punktySerii;
        public Form1()
        {
            InitializeComponent();
            functions.Add("sin(x) [rad]", (x) => Math.Sin(x));
            functions.Add("-x^3 - 3x^2 + 4x + 12", (x) => -x * x * x - 3 * x * x + 4 * x + 12);
            functions.Add("(x+4)(x+2)(x+1)(x-1)(x-3) + 2", (x) => (x + 4) * (x + 2) * (x + 1) * (x - 1) * (x - 3) + 2);
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
            if (i == 0)
            {
                sum = counter;
            }
            else
            {
                for (j = 0; j < difSums.Count; j++)
                {
                    if (j != i)
                    {
                        denominator *= Double.Parse(DGVPoints.Rows[i].Cells[1].Value.ToString())
                            - Double.Parse(DGVPoints.Rows[j].Cells[1].Value.ToString());
                    }
                }
                sum = difSums[difSums.Count - 1] + counter / denominator;
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
            plotView1.Model.Series.Add(new OxyPlot.Series.FunctionSeries((Func<double, double>)CBPolynomial.SelectedValue, -100, 100, 0.1, title));

            var scatterSeries = new ScatterSeries() { MarkerType = MarkerType.Circle, MarkerStrokeThickness = 3 };
            scatterSeries.Points.Add(new ScatterPoint(0, 0, 5, 1));

            plotView1.Model.Series.Add(scatterSeries);
            plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, ExtraGridlines = new double[] { 0 }, ExtraGridlineThickness = 1, ExtraGridlineColor = OxyColors.Black, });
            plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Top, ExtraGridlines = new double[] { 0 }, ExtraGridlineThickness = 1, ExtraGridlineColor = OxyColors.Black, });

            NMIN_MAX_ValueChanged(null, null);
            NMIN.Enabled = true;
            NMAX.Enabled = true;
        }

        private void NMIN_MAX_ValueChanged(object sender, EventArgs e)
        {
            int minimum;
            int maximum;

            int.TryParse(NMIN.Value.ToString(), out minimum);
            int.TryParse(NMAX.Value.ToString(), out maximum);

            if (minimum >= maximum)
            {
                minimum = maximum - 6;
                NMIN.Value = minimum;
            }
            if (minimum != 0 && maximum != 0)
            {
                plotView1.Model.Axes[1].Minimum = minimum;
                plotView1.Model.Axes[1].Maximum = maximum;

                //set y
                double max = Double.MinValue;
                double min = Double.MaxValue;

                double functValue = 0.0;
                
                for (double i = minimum; i <= maximum; i+=0.01)
                {
                    functValue = (double)((Func<double, double>)(CBPolynomial.SelectedValue)).DynamicInvoke(i);
                    max = max > functValue ? max : functValue;
                    min = min < functValue ? min : functValue;
                }

                plotView1.Model.Axes[0].Maximum = max;
                plotView1.Model.Axes[0].Minimum = min;

                plotView1.Model.Axes[0].Reset();
                plotView1.Model.Axes[1].Reset();

                plotView1.Model.InvalidatePlot(true);
            }
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBManual.Checked == true)
            {
                GBManual.Enabled = true;
                GBEquidistant.Enabled = false;
                GBChebyshev.Enabled = false;
            }
            else if (RBEquidistant.Checked == true)
            {
                GBManual.Enabled = false;
                GBEquidistant.Enabled = true;
                GBChebyshev.Enabled = false;
            }
            else if (RBChebyshev.Checked == true)
            {
                GBManual.Enabled = false;
                GBEquidistant.Enabled = false;
                GBChebyshev.Enabled = true;
            }
        }
    }
}
