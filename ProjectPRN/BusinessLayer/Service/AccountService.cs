using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class AccountService
    {
        private AccountService() { }

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


    }
}
