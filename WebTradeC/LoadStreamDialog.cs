using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WebTradeC
{
    partial class LoadStreamDialog : Form
    {
        public TickList toAdd;
        
        public LoadStreamDialog()
        {
            InitializeComponent();
            checkRadioButtons();
            cmbProviders.SelectedIndex = 0;
        }

        /// <summary>
        /// When the Add button is pressed, the input is processed.
        /// After that, the screen is closed so the Main class can
        /// process the input.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                toAdd.name = cmbProviders.Text + ": " +
                    txtSearchString.Text;
            }
            else
            {
                toAdd.name = txtName.Text;
            }
            this.Close();
        }       

        /// <summary>
        /// Used to enable/disable the file select controls
        /// </summary>        
        private void radFile_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }

        /// <summary>
        /// Used to enable/disable the webdata select controls
        /// </summary>    
        private void radWeb_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtons();
        }

        /// <summary>
        /// Call this to update the enabling/disabling of the file-
        /// and webdata select controls
        /// </summary>
        private void checkRadioButtons()
        {
            txtFilePath.Enabled         = radFile.Checked;
            btnBrowseFile.Enabled       = radFile.Checked;
            cmbProviders.Enabled        = radWeb.Checked;
            txtSearchString.Enabled     = radWeb.Checked;
            cmbUpdateInterval.Enabled   = radWeb.Checked;
        }

        /// <summary>
        /// Close the dialog without loading any new stream
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Browse for a file containing tick information. After a file is
        /// selected, a new TickList will be created and the data will be
        /// visible in the preview chart.
        /// </summary>
        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                toAdd = new TickList(loadFileDialog.FileName);
                showInPreviewChart(toAdd, toAdd.name, previewChart);
                txtName.Text     = toAdd.name;
                txtFilePath.Text = loadFileDialog.FileName;
            }            
        }

        /// <summary>
        /// Add some data to the chart for previewing.
        /// </summary>
        /// <param name="ticklist">A TickList containing the values to be added.
        /// </param>
        private void showInPreviewChart(TickList ticklist, String name, Chart c)
        {
            c.Series.Clear();

            Series line = new Series
            {
                Name              = name,
                ChartType         = SeriesChartType.Line,
                XValueType        = ChartValueType.DateTime,
                IsVisibleInLegend = true
            };
            c.Series.Add(line);

            foreach (Tick t in ticklist.getList())
            {
                line.Points.AddXY(t.getDate(), t.getValue());
            }
        }

        /// <summary>
        /// Add some data to the chart for previewing.
        /// </summary>
        /// <param name="ticklist">A TickList containing the values to be added.
        /// </param>
        private void showInPreviewChart(TickList ticklist, String name)
        {
            Chart c = previewChart;
            c.Series.Clear();

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
        private void btnSearchWeb_Click(object sender, EventArgs e)
        {
            //ProgressForm progress = new ProgressForm();
            prgbarLoadStream.Style = ProgressBarStyle.Marquee;
            String query = txtSearchString.Text;
            switch(cmbProviders.SelectedIndex){
                case 0:                    
                    GoogleTrends g = new GoogleTrends();
                    toAdd = g.Download(query);
                    toAdd = new LiveTickList(g, query, toAdd);
                    break;
                default:
                    break;
            }
            showInPreviewChart(toAdd, "Google: " + query);
        }


    }
}
