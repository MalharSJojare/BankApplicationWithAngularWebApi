﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblAccounts = new HashSet<TblAccount>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<TblAccount> TblAccounts { get; set; }
    }
}
