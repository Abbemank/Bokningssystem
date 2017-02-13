using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class BookingTime
    {
    
        public BookingTime()
        {
            this.BookingList = new HashSet<BookingList>();
        }
        public virtual ICollection<BookingList> BookingList { get; set; }
        
    }
}
