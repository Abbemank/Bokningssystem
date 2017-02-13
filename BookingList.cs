using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class BookingList
    {
        private string persNr { get; set; }
        private string date { get; set; }
        private string studyTime { get; set; }

        public virtual Person Person { get; set; }

    }
}
