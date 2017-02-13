using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class Ec3: Building
    {
        List<GroupRoom> Ec3Room = new List<GroupRoom>();
        GroupRoom rum103 = new GroupRoom("103");
        public override void AddGroupRoom(GroupRoom g)
        {
            Ec3Room.Add(g);
            Ec3Room.Add(rum103);

        }
    }
}
