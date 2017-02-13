using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class Ec2: Building
    {
        List<GroupRoom> Ec2Room = new List<GroupRoom>();

        public override void AddGroupRoom(GroupRoom g)
        {
            Ec2Room.Add(g);

        }
    }
}
