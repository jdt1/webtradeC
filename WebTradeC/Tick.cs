using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTradeC
{
    public class Tick : IComparable<Tick>
    {
        public DateTime date;
        public decimal value;

        /// <summary>
        /// constructor of the class
        /// </summary>
        /// <param name="date">The date for the Tick.</param>
        /// <param name="value">The value of the Tick.</param>
        public Tick(DateTime date, decimal value)
        {
            this.date = date;
            this.value = value;
        }

        /// <summary>
        /// Returns the Date of the Tick
        /// </summary>
        /// <returns>A DateTime object specifying the Date of the Tick</returns>
        public DateTime getDate()
        {
            return this.date;
        }

        /// <summary>
        /// Returns the value of the Tick.
        /// </summary>
        /// <returns>the value of the Tick</returns>
        public decimal getValue()
        {
            return this.value;
        }

        /// <summary>
        /// Returns a String representation of the Tick in the following form:
        /// "Date: 23-11-1973, value: 100"
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Date: " + date.ToString() + ", value: " + value;
        }

        /// <summary>
        /// Compare the Tick to another Tick by Date
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Tick other)
        {
            return DateTime.Compare(this.date, other.date);
        }
    }
}
