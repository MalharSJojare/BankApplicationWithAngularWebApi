using System;
using System.Collections.Generic;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class TblAdmin
    {
        public int AdminId { get; set; }
        public int BankId { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblBank Bank { get; set; }
    }
}
