using BankWebAPI.AngularBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWebAPI.Repository
{
    public interface IRepository
    {
        public void AddBank(TblBank tblBank);
        public void UpdateBank(int id, TblBank tblBank);
        public void DeleteBank(int id);
        public List<TblBank> GetAllBank();
        public TblBank GetBankById (int id);
        public TblBank GetBankByCity(string city);
        public TblBank GetBankByState(string state);


    }
}
