using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
    public class DAL
    {
        List<GroupRoom> GroupRoomList = new List<GroupRoom>();
        List<Person> PersonList = new List<Person>();
        public void AddPerson(Object c, string firstName, string lastName, string pnr)
        {
            try
            {
                Person p = new Person("951023", "Jakob", "Ekwall");
                Person l = new Person();
                l.FirstName = firstName;
                l.LastName = lastName;
                l.Pnr = pnr;
                PersonList.Add(l);
                PersonList.Add(p);
            }
            catch(Exception e) {
               
                Console.WriteLine("Kan inte registrera person" + e);
            }
           
           
        }
        
       // public Person GetPerson(string pnr)
       // {
        //    return PersonList.Find(pnr);
        //}

    }
}
