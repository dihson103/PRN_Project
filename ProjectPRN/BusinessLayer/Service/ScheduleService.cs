using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ScheduleService
    {
        private ScheduleService() { }

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
    }
}
