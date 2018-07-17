using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTradeC
{
    /// <summary>
    /// Represents a simple strategy in which a relative change in the 
    /// cause stream triggers a buy or sell in the effect stream. 
    /// </summary>
    struct SimpleStrategy
    {
        long holdtime;
        TickList cause;
        TickList effect;
        decimal difference;
    }
}
