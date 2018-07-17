using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTradeC
{
    /// <summary>
    /// This class represents a TickList that can be updated regularly.
    /// </summary>
    class LiveTickList : TickList
    {
        WebProvider provider;
        String query = "";

        public LiveTickList(WebProvider p, String q)
        {
            this.provider = p;
            this.query    = q;
            isLive = true;
        }

        public LiveTickList(WebProvider p, String q, TickList l)
        {
            this.provider   = p;
            this.query      = q;
            this.list       = l.list;
            isLive = true;
        }

        public void update()
        {
            TickList fetched = provider.Download(query);
            list.Union<Tick>(fetched.list);
        }
    }
}
