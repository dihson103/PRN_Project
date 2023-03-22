using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ClassService
    {
        private ClassService() { }

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
    }
}
