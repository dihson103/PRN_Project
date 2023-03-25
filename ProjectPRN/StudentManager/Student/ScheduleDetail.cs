using DataAcessLayer.Models;
using PresentationLayer.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Student
{
    public partial class ScheduleDetail : Form
    {
        public ScheduleDetail(lichhoc idCl)
        {
            InitializeComponent();
            txtIdClass.Text = idCl.IdClass;
            txtSlot.Text = idCl.Sche.Slot;
            txtDate.Text = idCl.Sche.Date.ToString("dd/MM/yyyy");
            Class c = MyStock.Instance.Classes.SingleOrDefault(x => x.Id == idCl.IdClass);
            txtTitle.Text = c.Name;
            txtTeacher.Text = idCl.Sche.IdStudentNavigation.Name;

        }
    }
}
