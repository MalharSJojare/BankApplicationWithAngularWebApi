using System;
using System.Collections.Generic;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class TblAccount
    {
        public TblAccount()
        {
            TblTransactions = new HashSet<TblTransaction>();
        }

        public int AccountId { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }
        public int Balance { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblBank Bank { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<TblTransaction> TblTransactions { get; set; }
    }
}
