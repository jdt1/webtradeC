using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace WebTradeC
{
    /// <summary>
    /// This class represents a Web Stream provider that can
    /// be queried for Stream data.
    /// It searches the downloaded JSON file for a date and 
    /// a property following that date.
    /// </summary>
    abstract class WebProvider
    {
        abstract public TickList Download(String query);
             
    }
}
