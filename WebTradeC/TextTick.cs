using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTradeC
{
    /// <summary>
    /// A tick containing not a DateTime object, but
    /// instead a string representing the date and time.
    /// </summary>
    class TextTick
    {
        string text;
        decimal value;
    }
}
