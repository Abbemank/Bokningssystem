using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class Ec1 : Building
    {
        List<GroupRoom> Ec1Room = new List<GroupRoom>();
        GroupRoom rum101 = new GroupRoom();
        
        public override void AddGroupRoom(GroupRoom g) 
        {
            Ec1Room.Add(g);
            Ec1Room.Add(rum101);

        }


    }
}
