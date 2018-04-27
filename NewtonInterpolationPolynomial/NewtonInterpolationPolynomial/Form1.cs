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
        Dictionary<int, KeyValuePair<double, double>> DGVPointsDict = new Dictionary<int, KeyValuePair<double, double>>();
        List<double> difDiv = new List<double>();
        Dictionary<string, Func<double, double>> functions = new Dictionary<string, Func<double, double>>();
        ScatterSeries scatterSeries = new ScatterSeries() { MarkerType = MarkerType.Circle, MarkerStrokeThickness = 3 };
        public Form1()
        {
            InitializeComponent();
            functions.Add("sin(x) [rad]", (x) => Math.Sin(x));
            functions.Add("-x^3 - 3x^2 + 4x + 12", (x) => -x * x * x - 3 * x * x + 4 * x + 12);
            functions.Add("(x+4)(x+2)(x+1)(x-1)(x-3) + 2", (x) => (x + 4) * (x + 2) * (x + 1) * (x - 1) * (x - 3) + 2);
            CBPolynomial.DataSource = new BindingSource(functions, null);
            CBPolynomial.DisplayMember = "Key";
            CBPolynomial.ValueMember = "Value";
            CBPolynomial_SelectedIndexChanged(null, null);
        }
        // *** Menu ***
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
        private void BAddNode_Click(object sender, EventArgs e)
        {
            double x_i = Convert.ToDouble(N_x_i.Value);
            bool can_or_not = true;
            for (int i = 0; i < DGVPoints.RowCount; i++)
            {
                if (Convert.ToDouble(DGVPoints[1, i].Value) == x_i)
                {
                    can_or_not = false;
                    break;
                }
            }
            if (can_or_not == true)
            {
                double y_i = (double)((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Value.DynamicInvoke(Convert.ToDouble(x_i));
                this.DGVPoints.Rows.Add(DGVPoints.RowCount, x_i, y_i);

                plotView1.Model.Series.Remove(scatterSeries);
                scatterSeries.Points.Add(new ScatterPoint(x_i, y_i, 5, 1));
                plotView1.Model.Series.Add(scatterSeries);
                plotView1.Model.InvalidatePlot(true);

                this.N_x_i.Value++;
                this.DGVPointsDict.Add(DGVPoints.RowCount - 1, new KeyValuePair<double, double>(Convert.ToDouble(x_i), y_i));
                GenerateDifDiv(0, DGVPoints.RowCount-1);
            }
            else
            {
                MessageBox.Show("You can't add node with existing argument: " + x_i, "Error");
            }
        }
        // *** DataGridView ***
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
        //Delete row
        private void DGVPoints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                int rowIndex = -1;
                rowIndex = e.RowIndex; //In what row cell has been clicked

                if (e.ColumnIndex == 3) //delete
                {
                    //remove row
                    plotView1.Model.Series.Remove(scatterSeries);
                    scatterSeries.Points.RemoveAt(rowIndex);
                    plotView1.Model.Series.Add(scatterSeries);
                    DGVPoints.Rows.RemoveAt(rowIndex);
                    plotView1.Model.InvalidatePlot(true);

                    //correct iterative order
                    for (int i = rowIndex; i < DGVPoints.Rows.Count; i++)
                    {
                        DGVPoints[0, i].Value = i;
                    }
                    //Change DGVPointsDict
                    int j = rowIndex;
                    for (int i = rowIndex; i < DGVPoints.RowCount; i++)
                    {
                        j = i + 1; //next index
                        DGVPointsDict.Remove(i);
                        this.DGVPointsDict[i] = new KeyValuePair<double, double>(DGVPointsDict[j].Key, DGVPointsDict[j].Value);
                    }
                    DGVPointsDict.Remove(j); //Remove last element in dict
                    for (int i = 0; i < DGVPoints.RowCount-rowIndex+1; i++)
                    {
                        difDiv.RemoveAt(difDiv.Count - 1);
                    }
                    if (rowIndex != DGVPoints.RowCount)
                    {
                        GenerateDifDiv(0, DGVPoints.RowCount - 1);
                    }

                }
            }
        }
        //Edit cell
        private void DGVPoints_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                double oldx_i = Convert.ToDouble(DGVPoints[e.ColumnIndex, e.RowIndex].Value);
                double newx_i = Convert.ToDouble(e.FormattedValue);
                bool can_or_not = true;
                if (oldx_i != newx_i)
                {
                    for (int i = 0; i < DGVPoints.RowCount; i++)
                    {
                        if (Convert.ToDouble(DGVPoints[1, i].Value) == newx_i)
                        {
                            MessageBox.Show("You can't change node to existing argument: " + newx_i, "Error");
                            e.Cancel = true;                    
                            can_or_not = false;
                            break;

                        }
                    }
                    if (can_or_not == true)
                    {
                        double y_iNew = (double)((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Value.DynamicInvoke(newx_i);
                        this.DGVPoints[2, e.RowIndex].Value = y_iNew;
                        this.DGVPointsDict[e.RowIndex] = new KeyValuePair<double, double>(newx_i, y_iNew);
                        //edit plot
                        plotView1.Model.Series.Remove(scatterSeries);
                        scatterSeries.Points.RemoveAt(e.RowIndex);
                        scatterSeries.Points.Insert(e.RowIndex, new ScatterPoint(newx_i, y_iNew, 5, 1));
                        plotView1.Model.Series.Add(scatterSeries);                     
                        plotView1.Model.InvalidatePlot(true);

                        for (int i = 0; i < DGVPoints.RowCount - e.RowIndex + 1; i++)
                        {
                            difDiv.RemoveAt(difDiv.Count - 1);
                        }
                        GenerateDifDiv(0, DGVPoints.RowCount-1);
                    }
                    DGVPoints.InvalidateRow(e.RowIndex);
                }
            }

        }
        private void CBPolynomial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear DifDiv
            difDiv.Clear();
            //calculate f(x_i) <=> y_i and change values in DGVPoints and in Dictionary
            double result = 0.0;
            for (int i = 0; i < DGVPoints.RowCount; i++)
            {
                result = (double)((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Value.DynamicInvoke(Convert.ToDouble(this.DGVPoints[1, i].Value));
                this.DGVPoints[2, i].Value = result;
                if (DGVPointsDict.Count == DGVPoints.RowCount)
                {
                    this.DGVPointsDict[i] = new KeyValuePair<double, double>(DGVPointsDict[i].Key, Convert.ToDouble(this.DGVPoints[2, i].Value));
                }
            }
            difDiv.Clear();
            GenerateDifDiv(0, DGVPoints.RowCount - 1);

            DGVPoints.InvalidateColumn(2);

            if (true)
            {
                plotView1.Model = null;
                plotView1.Model = new PlotModel();
            }
            //Plot
            for (int i = plotView1.Model.Series.Count - 1; i >= 0; i--)
            {
                plotView1.Model.Series.RemoveAt(i);
            }
            string title = ((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Key;
            plotView1.Model.Series.Add(new OxyPlot.Series.FunctionSeries(((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Value, -100, 100, 0.1, title));
            plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, ExtraGridlines = new double[] { 0 }, ExtraGridlineThickness = 1, ExtraGridlineColor = OxyColors.Black, });
            plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Top, ExtraGridlines = new double[] { 0 }, ExtraGridlineThickness = 1, ExtraGridlineColor = OxyColors.Black, });
            if (scatterSeries.Points.Count != 0)
            {
                scatterSeries.Points.Clear();
                foreach (KeyValuePair<double,double> item in DGVPointsDict.Values)
                {
                    scatterSeries.Points.Add(new ScatterPoint(item.Key, item.Value, 5, 1));
                }
                plotView1.Model.Series.Remove(scatterSeries);
                plotView1.Model.Series.Add(scatterSeries);
            }
            plotView1.Model.InvalidatePlot(true);
          

            NMIN_MAX_ValueChanged(null, null);
            NMIN.Enabled = true;
            NMAX.Enabled = true;
        }

        // *** Plot ***
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

                for (double i = minimum; i <= maximum; i += 0.01)
                {
                    functValue = (double)((KeyValuePair<string, Func<double, double>>)CBPolynomial.SelectedItem).Value.DynamicInvoke(i);
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

           public double GenerateDifDiv(int down, int up)
        {
            if (DGVPointsDict.Count > 0)
            {
                if (down.Equals(up))
                {
                    if (down.Equals(0))
                    {
                        difDiv.Add(DGVPointsDict[down].Value);
                    }
                    return DGVPointsDict[down].Value;
                }
                //else if (down.Equals(0) && difDiv.Count == (up + 1))
                //{
                //    return difDiv[up];
                //}
                else
                {
                    double var = 0;
                    double numerator = 0.0;
                    double denominator = 0.0;
                    if (down == 0 && difDiv.Count == up)
                    {
                        numerator = GenerateDifDiv(down + 1, up) - difDiv[up - 1];
                    }
                    else
                    {
                        numerator = GenerateDifDiv(down + 1, up) - GenerateDifDiv(down, up - 1);
                    }
                    denominator = DGVPointsDict[up].Key - DGVPointsDict[down].Key;
                    var = numerator / denominator;
                    if (down == 0)
                    {
                        difDiv.Add(var);
                    }
                    return var;
                }
            }
            else { return -1; }
        }
        public double Interpolate(double x)
        {
            if (DGVPointsDict.Count > 0)
            {
                double result = 0.0;
                double brackets = 1;
                for (int i = 0; i < difDiv.Count(); i++)
                {
                    brackets = difDiv[i];
                    for (int j = 0; j < i; j++)
                    {
                        brackets *= (x - DGVPointsDict[j].Key);
                    }
                    result += brackets;
                }
                return result;
            }
            else
            {
                return -1;
            }
        }
        private void BInterpolate_Click(object sender, EventArgs e)
        {
            if (DGVPointsDict.Count > 0)
            {
               for (int i = plotView1.Model.Series.Count-1; i >=1 ; i--)
               {
                    plotView1.Model.Series.RemoveAt(i);
               }
                plotView1.Model.Series.Add(scatterSeries);
                plotView1.Model.Series.Add(new OxyPlot.Series.FunctionSeries(new Func<double, double>(x => Interpolate(x)), -100, 100, 0.1, "Interpolation"));
                plotView1.Model.InvalidatePlot(true);     
            }
            else
            {
                MessageBox.Show("You can't interopolate, add at least one node", "Error");
            }
        }
    }
}
