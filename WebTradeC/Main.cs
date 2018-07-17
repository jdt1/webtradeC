using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WebTradeC
{
    public partial class Main : Form
    {
        internal static TickList valuedata = new TickList();
        internal static TickList webdata = new TickList();

        static TickListHolder ticklistholder = new TickListHolder();
        String def_datapath = "data.txt";

                        
        public Main()
        {
            InitializeComponent();

            dgridStreams.AutoGenerateColumns = false;
            dgridBTLeft.AutoGenerateColumns  = false;
            dgridBTRight.AutoGenerateColumns = false;   
            dgridStreams.DataSource = ticklistholder.ticklists;
            dgridBTLeft.DataSource  = ticklistholder.ticklists.ToList();
            dgridBTRight.DataSource = ticklistholder.ticklists.ToList();
            Testing.RunTests();
        }

        ///// <summary>
        ///// Browse for a CSV file containing value data and display
        ///// the result.
        ///// </summary>
        //private void btnReadValues_Click(object sender, EventArgs e)
        //{
        //    if (openValueDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        valuedata = new TickList(openValueDialog.FileName);
        //        Series valuepoints = new Series
        //        {
        //            Name = "Value data",                    
        //            ChartType = SeriesChartType.Line,
        //            XValueType = ChartValueType.DateTime
        //        };
        //        chart1.Series.Add(valuepoints);
        //        foreach (Tick t in valuedata.getList())
        //        {
        //            lstValueData.Items.Add(t);
        //            valuepoints.Points.AddXY(t.getDate(), t.getValue());
        //        }
        //    }            
        //}

        /// <summary>
        /// This button is only here for testing purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {       

        }

        /// <summary>
        /// Test the selected pre-made strategy
        /// </summary>
        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //    switch (lstStrategy.SelectedIndex)
        //    {
        //        case 0:
        //            Tuple<decimal, TickList> result = BackTest.SimpleHoldStrategy(
        //                    valuedata, webdata,true,(decimal)0.05,168);
        //            addToChart(result.Item2, "Simple Hold", true, chtBackTest);
        //            MessageBox.Show("Remaining value: " + result.Item1, "Finished",
        //                    MessageBoxButtons.OK,MessageBoxIcon.Information);
        //            break;
        //        default:
        //            MessageBox.Show("Select a strategy");
        //            break;
        //    }
        //}

        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clear all strategies from the chart
        /// </summary>
        private void btnClearStrategy_Click(object sender, EventArgs e)
        {
            while(chtBackTest.Series.Count > 2)
            {
                chtBackTest.Series.RemoveAt(2);
            }
        }

        /// <summary>
        /// Clear all loaded data
        /// </summary>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            valuedata = new TickList();
            webdata = new TickList();
            chtBackTest.Series.Clear();
            //lstValueData.Items.Clear();
        }

        ///// <summary>
        ///// Test a custom simple hold strategy.
        ///// </summary>
        //private void btnTestCustomSimpleHold_Click(object sender, EventArgs e)
        //{
        //    Tuple<decimal, TickList> result;
        //    decimal change;
        //    int holdtime;
        //    bool changeerror = !decimal.TryParse(txtChange.Text, out change);
        //    bool holderror = !int.TryParse(txtHoldFor.Text, out holdtime);
        //    bool relative = chkRelative.Checked;
        //    String name = "SimpleH(" + txtChange.Text + ",";
        //    if (relative) 
        //    { 
        //        name += "rel,";
        //        change *= (decimal)0.01;
        //    }
        //    else { name += "abs,"; }
        //    name += txtHoldFor.Text + "," + cmbDayYearMonth.Text + ")";
            
        //    switch (cmbDayYearMonth.Text)
        //    {
        //        case "Days": holdtime *= 24; break;
        //        case "Weeks": holdtime *= 24 * 7; break;
        //            // this is not completely correct, not all months are 30 days
        //        case "Months": holdtime *= 24 * 7 * 30; break;
        //    }
        //    if (!changeerror && !holderror) 
        //    {             
        //        result = BackTest.SimpleHoldStrategy(valuedata, webdata,
        //        relative, change, holdtime);
        //        MessageBox.Show("Remaining value: " + result.Item1, "Finished",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        addToChart(result.Item2, name, true, chart1);
        //        lstResults.Items.Add(name + ", " + result.Item1);
        //    }
        //    if (changeerror)
        //    {
        //        MessageBox.Show("Enter a valid change value");
        //    }
        //    if (holderror)
        //    {
        //        MessageBox.Show("Enter a valid hold time value");
        //    }
            
        //}

        /// <summary>
        /// Add some data to the chart.
        /// </summary>
        /// <param name="ticklist">A TickList containing the values to be added.</param>
        /// <param name="legend">The string to be displayed in the legend.</param>
        /// <param name="piecewise">If true, every two other points will be connected, the 
        /// points in between will be left unconnected: 0---1   2---3  etc.</param>
        private void addToChart(TickList ticklist, String name, bool piecewise,Chart c){
            if(c.Series.Contains(c.Series.FindByName(name)))
            {
                name += "1";
            }

            if (piecewise)
            {
                Series points = new Series
                {
                    Name = name,
                    ChartType = SeriesChartType.Point,
                    XValueType = ChartValueType.DateTime
                };
                Series line = new Series
                {
                    Name = name + "_line",
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime,
                    IsVisibleInLegend = false
                };
                c.Series.Add(points);
                c.Series.Add(line);

                foreach (Tick t in ticklist.getList())
                {
                    points.Points.AddXY(t.getDate(), t.getValue());
                }
                for (int i = 0; i < ticklist.getList().Count; i += 2)
                {
                    int p0 = line.Points.AddXY(ticklist.getList()[i].getDate(),
                                        ticklist.getList()[i].getValue());
                    int p1 = line.Points.AddXY(ticklist.getList()[i + 1].getDate(),
                                        ticklist.getList()[i + 1].getValue());                    
                    line.Points[p0].Color = Color.Transparent;
                }
            }
            else
            {
                Series line = new Series
                {
                    Name = name,
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime,
                    IsVisibleInLegend = true
                };
                c.Series.Add(line);

                foreach (Tick t in ticklist.getList())
                {
                    line.Points.AddXY(t.getDate(), t.getValue());
                }
                
            }
        }

        /// <summary>
        /// Remove the series with the specified name from the specified chart.
        /// </summary>
        private void removeFromChart(String name, Chart c)
        {
            c.Series.Remove(c.Series.FindByName(name));
        }


        //nieuwe comment


        /// <summary>
        /// Open the Optimize form.
        /// </summary>
        private void btnOptimize_Click(object sender, EventArgs e)
        {
            Optimize optimizescreen = new Optimize(
                (TickList)dgridBTLeft.SelectedRows[0].DataBoundItem,
                (TickList)dgridBTRight.SelectedRows[0].DataBoundItem);
            optimizescreen.Show();
        }

        /// <summary>
        /// Load all the datastreams from the JSON formatted file.
        /// </summary>       
        private void btnLoadTickLists_Click(object sender, EventArgs e)
        {
            if (File.Exists(def_datapath))
            {
                ticklistholder = TickListHolder.ReadJSON(def_datapath);
                foreach (TickList t in ticklistholder.ticklists)
                {
                    addToChart(t, t.name, false, chtBackTest);
                }
                refreshGridView();               
            }
            else
            {
                MessageBox.Show("No data file found");
            }
        }

        /// <summary>
        /// Save the TickListHolder to a JSON formatted textfile
        /// </summary>
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            ticklistholder.WriteToFile(def_datapath);
        }

        /// <summary>
        /// Load a data stream from a CSV formatted text file
        /// </summary>
        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            if (openValueDialog.ShowDialog() == DialogResult.OK)
            {
                addStreamFromFile(openValueDialog.FileName);                      
            }
        }

        private void dgridStreams_CellContentClick(object sender,
            DataGridViewCellEventArgs e)
        {
            //Logger.Log("Clicked column: " + e.ColumnIndex);
            if (e.ColumnIndex == 3)
            {
                bool display = 
                    (bool)dgridStreams.Rows[e.RowIndex].
                    Cells[e.ColumnIndex].EditedFormattedValue;
                TickList selectedlist = (TickList)dgridStreams.
                    Rows[e.RowIndex].DataBoundItem;
                if (display)
                {                    
                    addToChart(selectedlist, selectedlist.name, false, chtStreams);
                }
                else
                {
                    removeFromChart(selectedlist.name, chtStreams);
                }
            }
        }

        /// <summary>
        /// Loads a stream from a CSV-formatted textfile
        /// </summary>
        /// <param name="path">The path to the file that should be loaded</param>
        public void addStreamFromFile(string path)
        {
            TickList newdata = new TickList(path);
            ticklistholder.Add(newdata);
            addToChart(newdata, newdata.name, false, chtBackTest);          
        }

        /// <summary>
        /// Call to update the datagridview
        /// </summary>
        private void refreshGridView()
        {
            dgridStreams.DataSource = null;
            dgridStreams.DataSource = ticklistholder.ticklists;
            dgridBTLeft.DataSource  = null;
            dgridBTLeft.DataSource  = ticklistholder.ticklists.ToList();
            dgridBTRight.DataSource = null;
            dgridBTRight.DataSource = ticklistholder.ticklists.ToList();
        }

        /// <summary>
        /// Opens a LoadStreamDialog. After the dialog is closed, if a new TickList
        /// has been created by the LoadStreamDialog, it will be added to
        /// the TickListHolder. After that, the datagridview will be refreshed.
        /// </summary>        
        private void btnAddStream_Click(object sender, EventArgs e)
        {
            LoadStreamDialog l = new LoadStreamDialog();
            l.ShowDialog();
            
            if(l.DialogResult == DialogResult.OK){
                ticklistholder.Add(l.toAdd);
                refreshGridView();
            }
        }

        /// <summary>
        /// Deletes the selected row(s) from the ticklistholder
        /// </summary>       
        private void btnDeleteStream_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgridStreams.SelectedRows)
            {
                TickList t = (TickList)row.DataBoundItem;
                ticklistholder.ticklists.Remove(t);
                removeFromChart(t.name, chtStreams);
            }
            refreshGridView();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgridStreams.Rows)
            {
                LiveTickList t = row.DataBoundItem as LiveTickList;
                if(t != null)
                {
                    t.update();
                }                
            }
            refreshGridView();
        }

        private void btnUpdateStream_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgridStreams.SelectedRows)
            {
                LiveTickList t = row.DataBoundItem as LiveTickList;
                if (t != null)
                {
                    t.update();
                }    
            }
            refreshGridView();
        }

       

              
    }
}
