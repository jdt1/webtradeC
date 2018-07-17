using ChartDirector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace WebTradeC
{
    public partial class Optimize : Form
    {
        TickList cause;
        TickList effect;

        public Optimize(TickList cause, TickList effect)
        {
            InitializeComponent();
            this.cause  = cause;
            this.effect = effect;
        }

        private void form_load(object sender, EventArgs e)
        {
            
        }

        private void btnCloseOptimize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRunBacktests_Click(object sender, EventArgs e)
        {
            SurfaceChart c = new SurfaceChart(1004, 626);
            c.addTitle("Optimization surface plot");
            c.setPlotRegion(350, 280, 360, 360, 270);
            c.xAxis().setTitle("Minimum change [%]", "Arial Bold", 10);
            c.yAxis().setTitle("Hold time [hr]", "Arial Bold", 10);
            c.setColorAxis(645, 270, Chart.Left, 200, Chart.Right).setColorGradient();


            int changemin = (int)numChangeMin.Value;
            int changemax = (int)numChangeMax.Value;
            bool relative = chkChangeRel.Checked;
            int timemin = (int)numTimeMin.Value;
            int timemax = (int)numTimeMax.Value;
            decimal changestep = 1;
            if (rad_1.Checked) { changestep = 1; }
            else if (rad_01.Checked) { changestep = (decimal)0.1; }
            else if (rad_001.Checked) { changestep = (decimal)0.01; }
            else if (rad_0001.Checked) { changestep = (decimal)0.001; }
            int timestep = 1;
            if (radDays.Checked) {
                timestep *= 24;
                timemin  *= 24;
                timemax  *= 24;
            }
            else if (radWeeks.Checked)
            {
                timestep *= 24 * 7;
                timemin  *= 24 * 7;
                timemax  *= 24 * 7;
            }
            else if (radMonths.Checked) 
            { 
                timestep *= 24 * 7 * 30;
                timemin  *= 24 * 7 * 30;
                timemax  *= 24 * 7 * 30;            
            }            

            decimal[] X = linearSpace(changemin, changestep, changemax);
            int[] Y = linearSpacedInts(timemin, timestep, timemax);
            decimal[] Z = new decimal[X.Length * Y.Length];

            for (int i = 0; i < Y.Length; i++)
            {
                for (int j = 0; j < X.Length; j++)
                {
                    Z[j + i*X.Length] = BackTest.SimpleHoldStrategyResult(effect, cause,
                        relative, (decimal)0.01*X[j], Y[i]);
                }
            }

            decimal[] Y_decimal = new decimal[Y.Length];
            for (int k = 0; k < Y.Length; k++)
            {
                Y_decimal[k] = (decimal)Y[k];
            }

            //convert to double
            double[] X_double = Array.ConvertAll(X, x => (double)x);
            double[] Y_double = Array.ConvertAll(Y, x => (double)x);
            double[] Z_double = Array.ConvertAll(Z, x => (double)x);

            c.setData(X_double, Y_double, Z_double);
            surface1.Chart = c;
        }

        private decimal[] linearSpace(int a, decimal stepsize, int b)
        {
            int size = (int)Math.Round((b-a)/stepsize) + 1;
            decimal[] result = new decimal[size];
            decimal x = a;
            for (int c = 0; x < b; c++ )
            {
                x = a + stepsize * c;
                result[c] = x;
            }
            return result;
        }

        private int[] linearSpacedInts(int a, int stepsize, int b)
        {
            int size = (int)Math.Round((decimal)(b - a) / stepsize) + 1;
            int[] result = new int[size];
            int x = 0;
            for (int c = a; c <= b; c += stepsize)
            {
                result[x++] = c;
            }
            return result;
        }

        private decimal[] linearSpace(int a, int n, int b)
        {
            decimal[] result = new decimal[n+1];
            decimal stepsize = (decimal)(b - a) / n;
            for (int c = 0; c <= n; c++)
            {
                result[c] = a + c * stepsize;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] test1 = linearSpace(-3, (decimal)0.1, 3);
            decimal[] test2 = linearSpace(-3, 30, 3);
            int[] test3 = linearSpacedInts(-10, 1, 10);
            //int i = 0;
        }

       
    }
}
