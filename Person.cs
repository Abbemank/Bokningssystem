using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssystem
{
   public class Person
    {
        private string pnr;
        private string firstName;
        private string lastName;
        
        public Person() { }
        public Person(string pnr, string firstName, string lastName)
        {
            Pnr = pnr;
            FirstName=firstName;
            LastName = lastName;
           

        }
        public string Pnr
        {
            get
            {
                return pnr;
            }
            set
            {
                pnr = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
    }
}
