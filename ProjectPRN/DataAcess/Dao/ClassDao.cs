using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Dao
{
    public class ClassDao
    {
        public ClassDao() { }
        public List<Class> GetClassesByAccount(Account a)
            => MyStock.Instance.Classes.Where(x => x.IdTeacher == a.Id).ToList();


    }
}
