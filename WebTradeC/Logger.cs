using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTradeC
{
    static class Logger
    {        
        /// <summary>
        /// Writes an event to the console and the log file.
        /// </summary>
        /// <param name="text">Text explaining the event.</param>
        public static void Log(String text)
        {
            String output = DateTime.Now.ToString() + ": " + text;
            StreamWriter sr = new StreamWriter("log.txt", true);            
            Console.WriteLine(output);
            sr.WriteLine(output);
            
            sr.Close();
        }
    } 
}
