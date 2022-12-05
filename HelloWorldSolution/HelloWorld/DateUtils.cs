using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DateUtils
    {
        public DateTime TakeABreak(int minutes)
        {
            return DateTime.Now.AddMinutes(minutes);
        }
    }
}
