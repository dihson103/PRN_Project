using BusinessLayer.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Teacher
{
    public partial class UcTeacherHome : UserControl
    {
        private static UcTeacherHome instance;
        public static UcTeacherHome Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcTeacherHome();
                }
                return instance;
            }
        }
        private UcTeacherHome()
        {
            InitializeComponent();
            lblHome.Text = "Wellcome " + Ultil.AccountLg.Name + "\nto teacher form";
        }
    }
}
