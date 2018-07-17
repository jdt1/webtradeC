using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WebTradeC
{
    /// <summary>
    /// This class represents a list of ticks.
    /// It contains methods to read from CSV files and
    /// calculate absolute and relative differences.
    /// </summary>
    public class TickList
    {
        public List<Tick> list = new List<Tick>();        
        public String name { get; set; }
        public DateTime lastupdated 
        { get { return list.Last().getDate(); }}
        public Boolean display { get; set; }
        public int count
        {
            get         { return list.Count; }
            private set { count = value; }
        }
        private Boolean islive = false;
        public Boolean isLive { get; set; }
        
        /// <summary>
        /// Empty constructor of the class
        /// </summary>
        public TickList()
        {
            name = DateTime.Now.ToShortTimeString();
        }
        
        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="filename">Path to a CSV-file to be parsed</param>
        public TickList(String filename)
        {
            this.readCSV(filename);
            this.name = filename;            
        }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="filename">Path to a CSV-file to be parsed</param>
        /// <param name="name">Name of the new TickList</param>
        public TickList(String filename, String name)
        {
            this.readCSV(filename);
            this.name = name;
        }

        /// <summary>
        /// Returns the List<Tick> containing all the Ticks
        /// </summary>
        /// <returns>A List<Tick> containing all the Ticks/returns>
        public List<Tick> getList()
        {
            return list;
        }
        /// <summary>
        /// Read tick information from a ;-seperated CSV file with no header.
        /// Date information should be formatted as dd-mm-yyyy, tick
        /// information a number with decimal point.
        /// </summary>
        /// <param name="filename">path and filename of the CSV file to be read</param>
        public void readCSV(String filename)
        {
            NumberFormatInfo nti = new NumberFormatInfo();
            nti.NumberDecimalSeparator = ".";
            TextFieldParser parser =
                new TextFieldParser(new System.IO.StreamReader(filename));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(";");
            while (!parser.EndOfData)
            {
                String[] line = parser.ReadFields();
                DateTime time = DateTime.Parse(line[0]);
                decimal value = Decimal.Parse(line[1], nti);
                list.Add(new Tick(time, value));
            }
            //MessageBox.Show(count.ToString());
        }
        /// <summary>
        /// Finds the value at the specified DateTime, if it exists.
        /// </summary>
        /// <param name="time"></param>
        /// <returns>The value corresponding to the given time.</returns>
        public decimal valueAt(DateTime time)
        {
            foreach (Tick t in list)
            {
                if (t.getDate().Equals(time)){
                    return t.getValue();
                }
            }
            return -1;
        }
        /// <summary>
        /// Add a Tick to the list
        /// </summary>
        /// <param name="t">Tick to be added</param>
        public void Add(Tick t)
        {
            list.Add(t);            
        }
        /// <summary>
        /// Calculate the absolute differences between each successive tick.
        /// Each date is the date at which the difference has been observed,
        /// so the b in "a - b".
        /// </summary>
        /// <returns>A TickList containing the dates at which the differences
        /// have been observed, and the differences.</returns>
        public TickList AbsoluteDifferences()
        {
            TickList returnlist = new TickList();
            for (int i = 1; i < list.Count; i++)
            {
                DateTime observeddate = list[i].getDate();
                decimal difference = list[i].getValue() - list[i-1].getValue();
                returnlist.Add(new Tick(observeddate, difference));
            }
            return returnlist;
        }
        /// <summary>
        /// Calculate the relative differences between each successive tick.
        /// This means each absolute difference is scaled by the original value.
        /// For example from 10 to 8 the absolute difference is -2, the relative
        /// difference is -2/10 = 0.2.
        /// </summary>
        /// <returns>A TickList containing the dates at which the differences
        /// have been observed, and the differences.</returns>
        public TickList RelativeDifferences()
        {
            TickList returnlist = new TickList();
            List<Tick> absolutelist = this.AbsoluteDifferences().getList();
            for (int i = 0; i < absolutelist.Count; i++)
            {
                DateTime observeddate = list[i].getDate();
                decimal relativedifference = absolutelist[i].getValue() / list[i].getValue();
                returnlist.Add(new Tick(observeddate, relativedifference));
            }
            return returnlist;
        }
        /// <summary>
        /// A string representation of the complete list.
        /// </summary>
        /// <returns>A string representation of the TickList, 
        /// each line seperated by a newline.</returns>
        public String toString()
        {
            String output = "";
            foreach (Tick t in list)
            {
                output += "Time: " + t.getDate().ToString() + ", value: "
                    + t.getValue() + "\n";
            }
            return output;
        }

        /// <summary>
        /// Performs a binary search to find a Tick with the specified 
        /// date and returns the zero-based index of the first found Tick
        /// in the TickList.
        /// </summary>
        /// <param name="tofind">A DateTime object specifying
        /// the Date to search for.</param>
        /// <returns>The zero-based index of the position of the
        /// first Tick with the same date.</returns>
        public int findDate(DateTime tofind)
        {  
            int test = list.BinarySearch(new Tick(tofind, 0));
            if (test < 0) 
                test = -1;
            return test;   
        }

        /// <summary>
        /// Returns the DateTime object of the last Tick in the 
        /// TickList
        /// </summary>
        public DateTime lastDate()
        {
            return list[list.Count - 1].getDate();
        }

        //public static bool writeToJSON(TickList t)
        //{
        //    bool result = false;
        //    String output = JsonConvert.SerializeObject(t);
        //    //Logger.Log(output);
        //    return true;
        //}
    }
}
