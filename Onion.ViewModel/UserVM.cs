using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.ViewModel
{
   public class UserVM
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }


        public string FullName
        {
            get { return FirstName + " " +MiddleName+" "+ LastName ;  }
        }

    }
}
