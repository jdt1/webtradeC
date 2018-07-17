using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;

namespace WebTradeC
{
    /// <summary>
    /// This is a class to hold multiple TickLists. It should be opened at 
    /// the beginning of a session and closed at the end. It contains
    /// methods to write to and from a JSON formatted textfile.
    /// </summary>
    class TickListHolder
    {
        public BindingList<TickList> ticklists = new BindingList<TickList>();

        /// <summary>
        /// Writes the TickListHolder to a JSON formatted textfile.
        /// If a file the the specified filename already exists, it will
        /// be overwritten.
        /// </summary>
        /// <param name="path">Path and filename of the file
        /// that should be written to</param>
        public void WriteToFile(String path)
        {
            TextWriter writer = null;
            try
            {
                var toWrite = JsonConvert.SerializeObject(this);
                writer = new StreamWriter(path, false);
                writer.Write(toWrite);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Reads a TickListHolder from the specified file.
        /// </summary>
        /// <param name="path">Path and filename to the file
        /// that should be read</param>
        /// <returns></returns>
        public static TickListHolder ReadJSON(String path)
        {
            TextReader reader = null;
            Logger.Log("Attempting to read JSON file " + path);
            try
            {
                reader = new StreamReader(path);
                var fileContents = reader.ReadToEnd();
                TickListHolder readlist = JsonConvert.DeserializeObject<TickListHolder>(fileContents);
                Logger.Log("Found the following TickListHolder:");
                Logger.Log(readlist.ToString());
                return readlist;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public void Add(TickList l)
        {
            ticklists.Add(l);
        }

        public override string ToString()
        {
            String s = "Tick List Holder \n";
            foreach (TickList t in ticklists)
            {
                s += t.name + "\n";
            }
            return s;
        }
    }
}
