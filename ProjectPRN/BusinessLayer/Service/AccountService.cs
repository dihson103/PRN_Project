using DataAcessLayer.Dao;
using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class AccountService
    {
        private AccountDao accountDao;
        private AccountService() 
        {
            accountDao = new AccountDao();
        }

        private static AccountService instance = null;
        public static AccountService Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new AccountService();
                }
                return instance; 
            }
        }
        public Account GetAccountByEmailAndPassWord(String email, String pass) 
            => accountDao.GetAccountByEmailAndPassword(email, pass);

        public void UpdateAccount(Account account)
        {
            accountDao.UpdateAccount(account);
        }
    }
}
