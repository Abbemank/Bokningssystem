using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
   public abstract class Building
    {
        private static string buildingName = "Ekonomihögskolan";
        List<GroupRoom> GroupRoomList = new List<GroupRoom>();
      
        public virtual void AddGroupRoom(GroupRoom g)
        {
            GroupRoomList.Add(g);

        }
        

        public static string BName()
        {
            return buildingName;
        }
       
    }
}
