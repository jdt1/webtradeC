using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace WebTradeC
{
    class Testing
    {
        public static void Main()
        {            
        }

        public static void RunTests()
        {
            bool enabled = false;
            if (enabled)
            {
                //WebProvider w = new WebProvider("", "http://query.yahooapis.com/v1/public/" +
                //"yql?q=select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%2" +
                //"0%3D%20%22AAPL%22%20and%20startDate%20%3D%20%222012-09-11%22%20and%20endD" +
                //"ate%20%3D%20%222014-02-11%22&format=json&diagnostics=true&env=store%3A%2F" +
                //"%2Fdatatables.org%2Falltableswithkeys",0);
                //w.Download();         

                String def_datapath = "data.txt";
                TickListHolder t    = TickListHolder.ReadJSON(def_datapath);
                LiveTickList l = new LiveTickList(new GoogleTrends(), "bitcoin", t.ticklists[1]);
                l.update();
            }
        }
    }
}
