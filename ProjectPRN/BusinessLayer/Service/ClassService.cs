using BusinessLayer.Ultils;
using DataAcessLayer.Dao;
using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ClassService
    {
        private readonly ClassDao dao;
        private ClassService() 
        {
            dao = new ClassDao();  
        }

        private static ClassService instance = null;
        public static ClassService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ClassService();
                }
                return instance;
            }
        }

        public List<Class> GetClassesByAccount()
        {
            Account a = Ultil.AccountLg;
            return dao.GetClassesByAccount(a);
        }
    }
}
