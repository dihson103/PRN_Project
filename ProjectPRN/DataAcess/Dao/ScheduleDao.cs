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
    }
}
