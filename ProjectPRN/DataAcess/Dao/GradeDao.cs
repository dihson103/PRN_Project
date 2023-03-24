using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Dao
{
    public class GradeDao
    {
        public GradeDao() { }

        public List<Grade> GetGrades(String stCode)
            => MyStock.Instance.Grades.Where(x => x.IdStudent== stCode).ToList();
        
    }
}
