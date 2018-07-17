using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FileHelpers;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Diagnostics;

namespace WebTradeC
{
    /// <summary>
    /// This class contains methods to downloads data from Google Trends 
    /// and create a TickList from it. 
    /// </summary>
    class GoogleTrends : WebProvider
    {
        TickList parsed = new TickList();
        string py_response = "";

        /// <summary>
        /// Constructor of the class. Instantiates a Google Trends downloading-
        /// and parsing class.
        /// </summary>
        public GoogleTrends()
        {
        }

        public override TickList Download(String query)
        {
            py_response = "";
            // Call Python script to scrape the data
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = @"C:\Python35\python3.exe";
            pythonInfo.Arguments = @"-i E:\Cloud\Engineering\Software\WebTradeC\pytrends-master\examples\example.py " + query;
            pythonInfo.CreateNoWindow = true;
            pythonInfo.UseShellExecute = false;
            pythonInfo.RedirectStandardOutput = true;
            Logger.Log("Python Starting");
            python = Process.Start(pythonInfo);
            python.BeginOutputReadLine();
            python.OutputDataReceived += datareceived;
            Logger.Log("Waiting 5 seconds for Python to finish");
            System.Threading.Thread.Sleep(5000);
            Logger.Log("Killing Python thread, attempting to parse data");
            try
            {
                python.Kill();
            }
            catch (Exception e)
            {
                Logger.Log("Killing Python thread failed");
                Logger.Log(e.Message);
            }
            TrendResponse pyres = JsonConvert.DeserializeObject<TrendResponse>(py_response);

            if (pyres != null)
            {
                foreach (Row r in pyres.table.rows)
                {
                    List<C> c = r.c;
                    if (c[1].f != null && c[1].v != null)
                    {
                        String datestring = c[0].f;
                        datestring = datestring.Substring(datestring.IndexOf("–") + 1);
                        DateTime date = DateTime.Parse(datestring);
                        decimal value = Decimal.Parse(c[1].f);
                        parsed.Add(new Tick(date, value));
                    }
                }
            }
            else
            {
                Logger.Log("Parsing failed: empty response received");
            }
            return parsed;
        }
        
        private void datareceived(object sender, DataReceivedEventArgs e)
        {
            py_response += e.Data;
        }

        [DelimitedRecord(",")]
        public class googletick
        {
            public string  dates;
            public decimal value;
        }

        // Class definitions for the Google Trends JSON format
        public class Col
        {
            public string type { get; set; }
            public string pattern { get; set; }
            public string label { get; set; }
            public string id { get; set; }
        }

        public class C
        {
            public object v { get; set; }
            public string f { get; set; }
        }

        public class Row
        {
            public List<C> c { get; set; }
        }

        public class Table
        {
            public List<Col> cols { get; set; }
            public List<Row> rows { get; set; }
        }

        public class TrendResponse
        {
            public string version { get; set; }
            public string status { get; set; }
            public Table table { get; set; }
            public string sig { get; set; }
        }

    }
}
