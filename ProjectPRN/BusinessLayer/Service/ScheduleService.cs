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
    public class ScheduleService
    {
        private ScheduleDao scheduleDao;
        private ScheduleService() 
        {
            scheduleDao= new ScheduleDao();
        }

        private static ScheduleService instance = null;
        public static ScheduleService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ScheduleService();
                }
                return instance;
            }
        }

        public List<Schedule> GetSchedules(DateTime from, DateTime to)
        {
            Account a = Ultil.AccountLg;
            return scheduleDao.GetSchedules(from, to, a);
        }
    }
}
