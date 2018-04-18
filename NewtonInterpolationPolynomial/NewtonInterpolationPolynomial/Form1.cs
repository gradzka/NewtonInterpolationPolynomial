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
        public Form1()
        {
            InitializeComponent();
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

    }
}
