using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Dao
{
    public class ScheduleDao
    {
        public ScheduleDao() { }
        public List<Schedule> GetSchedules(DateTime from, DateTime to, Account a)
            => MyStock.Instance.Schedules.Where(x => x.IdStudent == a.Id && from <= x.Date && x.Date <= to).ToList();

        public List<Schedule> GetSchedulesByIdClass(DateTime from, DateTime to, String idClass)
        {
            String idSt = getIdSTinClass(idClass);
            return MyStock.Instance.Schedules.Where(x => x.IdClass == idClass && x.IdStudent == idSt && from <= x.Date && x.Date <= to).ToList();
        }
             

        private String getIdSTinClass(String idClass)
        {
            List<Schedule> s = MyStock.Instance.Schedules.Where(x => x.IdClass == idClass).ToList();
            foreach (Schedule s2 in s)
            {
                return s2.IdStudent;
            }
            return null;
        }
    }
}
