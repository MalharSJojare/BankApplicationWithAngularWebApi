using BankWebAPI.AngularBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWebAPI.Repository
{
    public partial class Repository : IRepository
    {
        public void AddBank(TblBank tblBank)
        {
            using (var db = new AngularBankContext()) 
            {
                db.TblBanks.Add(tblBank);
                db.SaveChanges();
            }
        }

        public void DeleteBank(int id)
        {
            using (var db = new AngularBankContext())
            {
                TblBank tblBank = db.TblBanks.Find(id);
                db.TblBanks.Remove(tblBank);
                db.SaveChanges();
            }
        }

        public List<TblBank> GetAllBank()
        {
            using (var db = new AngularBankContext())
            {
                List<TblBank> tblBanks = new();
                tblBanks = db.TblBanks.ToList<TblBank>();
                return tblBanks;
            }
        }

        public TblBank GetBankByCity(string city)
        {
            using (var db = new AngularBankContext())
            {
                List<TblBank> tblBanks = new();
                tblBanks = db.TblBanks.ToList<TblBank>();
                TblBank bank = (TblBank)(from TblBank in tblBanks
                           where TblBank.City == city
                           select tblBanks);
                return bank;
            }
        }

        public TblBank GetBankById(int id)
        {
            using (var db = new AngularBankContext())
            {
                TblBank tblBank = db.TblBanks.Find(id);
                db.SaveChanges();
                return tblBank;
            }
        }

        public TblBank GetBankByState(string state)
        {
            using (var db = new AngularBankContext())
            {
                List<TblBank> tblBanks = new();
                tblBanks = db.TblBanks.ToList<TblBank>();
                TblBank bank = (TblBank)(from TblBank in tblBanks
                                         where TblBank.State == state
                                         select tblBanks);
                return bank;
            }
        }

        public void UpdateBank(int id, TblBank tblBank)
        {
            throw new NotImplementedException();
        }
    }
}
