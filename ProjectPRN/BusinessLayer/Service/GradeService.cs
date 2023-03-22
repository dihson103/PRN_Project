using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class GradeService
    {
        private GradeService() { }

        private static GradeService instance = null;

        public static GradeService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new GradeService();
                }
                return instance;
            }
        }
    }
}
