using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTradeC
{
    /// <summary>
    /// This class is used for backtesting different strategies.
    /// It contains different methods for different strategies.
    /// Each strategy returns the remaining value after starting with
    /// a initial capital of 1 and a TickList containing the trade
    /// dates and trade values.
    /// </summary>
    class BackTest
    {
        /// <summary>
        /// A simple hold strategy.
        /// When the value of the web data has (absolutely or relatively), increased
        /// by a certain number or percentage, the asset is held for the specified holdtime.
        /// </summary>
        /// <param name="valuedata">A TickList containing the value data.</param>
        /// <param name="webdata">A TickList containing the Google search data.</param>
        /// <param name="relative">If true, the change is interpreted as relative change. 
        /// Otherwise, the change is absolute.</param>
        /// <param name="change">A number representing the change treshold.</param>
        /// <param name="holdtime">The time for which to hold the asset in hours. 
        /// (this might change into the future when testing high-frequency strategies).</param>
        /// <returns>A touple containing: a decimal representing the remaing value
        /// after using this strategy. A TickList containing the buy- and -sell 
        /// values and prices.</returns>
        public static Tuple<decimal, TickList > SimpleHoldStrategy(TickList valuedata, 
            TickList webdata, bool relative, decimal change, int holdtime)
        {
            decimal value = 1;
            TickList portfolio = new TickList();

            TickList absticklist = webdata.AbsoluteDifferences();
            List<Tick> absdif = absticklist.getList();

            TickList relticklist = webdata.RelativeDifferences();
            List<Tick> reldif = relticklist.getList();

            for (int i = 0; i < reldif.Count && i!= -1; )
            {
                if ( (relative && reldif[i].getValue() > change) ||
                    (!relative && absdif[i].getValue() > change) )
                {
                    DateTime buydate  = reldif[i].getDate();
                    DateTime selldate = buydate.AddHours(holdtime);
                    try
                    {
                        decimal buyprice  = valuedata.valueAt(buydate);
                        decimal sellprice = valuedata.valueAt(selldate);
                        value *= sellprice / buyprice;
                        portfolio.Add(new Tick(buydate, buyprice));
                        portfolio.Add(new Tick(selldate, sellprice));
                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    i = relticklist.findDate(selldate);
                }
                else
                {
                    i++;
                }
            }            
            return Tuple.Create(value, portfolio);
        }

        /// <summary>
        /// Same as Tuple<decimal, TickList > SimpleHoldStrategy(..) but this
        /// method only outputs the end result.
        /// </summary>
        /// <returns><Remaining value after using the specified strategy/returns>
        public static decimal SimpleHoldStrategyResult(TickList valuedata,
            TickList webdata, bool relative, decimal change, int holdtime)
        {
            decimal value = 1;

            TickList absticklist = webdata.AbsoluteDifferences();
            List<Tick> absdif    = absticklist.getList();

            TickList relticklist = webdata.RelativeDifferences();
            List<Tick> reldif    = relticklist.getList();

            for (int i = 0; i < reldif.Count && i != -1; )
            {
                if ((relative && reldif[i].getValue() > change) ||
                   (!relative && absdif[i].getValue() > change))
                {
                    DateTime buydate  = reldif[i].getDate();
                    DateTime selldate = buydate.AddHours(holdtime);
                    decimal buytimevalue  = valuedata.valueAt(buydate);
                    decimal selltimevalue = valuedata.valueAt(selldate);
                    if((buytimevalue != -1) && (selltimevalue != -1))
                    {
                        value *= selltimevalue / buytimevalue;
                    }                   
                    i = relticklist.findDate(selldate);
                }
                else
                {
                    i++;
                }
            }
            return value;
        }
    }
}
