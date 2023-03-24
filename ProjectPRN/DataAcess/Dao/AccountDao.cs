using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Dao
{
    public class AccountDao
    {
        public AccountDao() { }
        public Account GetAccountByEmailAndPassword(String email, String pass) 
            => MyStock.Instance.Accounts.SingleOrDefault(x => x.Email == email && x.Password == pass);

        public void UpdateAccount(Account account)
        {
            Account a = MyStock.Instance.Accounts.Find(account.Id);
            if (a != null)
            {
                a.Sex = account.Sex;
                a.Address = account.Address;
                a.Password = account.Password;
                a.Email = account.Email;
                MyStock.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Sai update");
            }
            
        }
    }
}
