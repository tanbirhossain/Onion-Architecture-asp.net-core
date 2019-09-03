using System;
using System.Collections.Generic;

namespace Onion.Repository.DB
{
    public partial class TblUser
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
