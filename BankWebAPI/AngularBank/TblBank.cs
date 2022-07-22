using System;
using System.Collections.Generic;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class TblBank
    {
        public TblBank()
        {
            TblAccounts = new HashSet<TblAccount>();
            TblAdmins = new HashSet<TblAdmin>();
            TblTransactions = new HashSet<TblTransaction>();
        }

        public int BankId { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<TblAccount> TblAccounts { get; set; }
        public virtual ICollection<TblAdmin> TblAdmins { get; set; }
        public virtual ICollection<TblTransaction> TblTransactions { get; set; }
    }
}
