using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Buffteks
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
         public string Rank { get; set; }

        public Char Database { get; set; } //number indicates whether it is the first or second time taking the class
        public string PhoneNumber { get; set; }
    }
}