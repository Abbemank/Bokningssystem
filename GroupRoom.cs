using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
   public class GroupRoom
    {
        private string groupnr;
        GroupRoom rum1 = new GroupRoom("101");
        GroupRoom rum2 = new GroupRoom("102");
        
        public GroupRoom() { }
        public GroupRoom(string groupnr)
        {
            Groupnr = groupnr;
            
        }
        public string Groupnr
        {
            get
            {
                return groupnr;
            }

            set
            {
                groupnr = value;
            }
        }

       
    }
}
