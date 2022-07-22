using System;
using System.Collections.Generic;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class TblTransaction
    {
        public int TransactionId { get; set; }
        public int BankId { get; set; }
        public int AccountId { get; set; }
        public int DepositAmt { get; set; }
        public int WithdrawAmt { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAccount Account { get; set; }
        public virtual TblBank Bank { get; set; }
    }
}
