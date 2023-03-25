using BusinessLayer.Service;
using BusinessLayer.Ultils;
using DataAcessLayer.Models;
using PresentationLayer.Student;
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
    public struct lichhoc
    { 
        public String IdClass;
        public int Index;
        public Schedule Sche;
    }
    public partial class UcTeacherSchedule : UserControl
    {
        private static UcTeacherSchedule _instance = null;
        public static UcTeacherSchedule Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance= new UcTeacherSchedule();
                }
                return _instance;
            }
        }
        private UcTeacherSchedule()
        {
            InitializeComponent();
            date = DateTime.Now;
            LoadDate();
            CreatSchedule();
        }

        private DateTime date;
        private void LoadDate()
        {
            btnTime.Text = Ultil.FirstDayOfWeek(date).ToString("dd/MM/yyyy") + "    to    " + Ultil.LastDayOfWeek(date).ToString("dd/MM/yyyy");
        }

        private int GetSlot(String sl)
        {
            switch (sl)
            {
                case "slot1":
                    return 1;
                case "slot2":
                    return 2;
                case "slot3":
                    return 3;
                case "slot4":
                    return 4;
            }
            return -1;
        }

        private int GetDayValue(DateTime dTime)
        {
            DateTime d = Ultil.FirstDayOfWeek(date);
            TimeSpan time = dTime - d;
            return time.Days + 2;
        }


        private void CreatSchedule()
        {
            flpSchedule.Controls.Clear();
            List<Class> classes = ClassService.Instance.GetClassesByAccount();
            List<Schedule> schedules = ScheduleService.Instance.GetSchedulesByTeacher(Ultil.FirstDayOfWeek(date), Ultil.LastDayOfWeek(date), classes);
            //List<Schedule> schedules = ScheduleService.Instance.GetSchedules(Ultil.FirstDayOfWeek(date), Ultil.LastDayOfWeek(date));
            List<lichhoc > listB = new List<lichhoc>();
            int a = 0;
            int slot = 0;
            foreach (Schedule schedule in schedules)
            {
                a = GetDayValue(schedule.Date);
                slot = GetSlot(schedule.Slot);
                listB.Add(new lichhoc
                {
                    Index = 7 * (slot - 1) + a,
                    IdClass = schedule.IdClass,
                    Sche = schedule
                });
            }

            for (int i = 1; i <= 28; i++)
            {
                Button b = new Button();
                b.Width = 75;
                b.Height = 50;
                b.Name = $"{i}";
                b.Enabled = false;
                flpSchedule.Controls.Add(b);
                foreach (lichhoc j in listB)
                {
                    if (i == j.Index)
                    {
                        b.Enabled = true;
                        b.Text = j.IdClass;
                        b.Click += new EventHandler(b_Click);
                    }
                }

            }


        }

        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thanh cong");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-7);
            LoadDate();
            CreatSchedule();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            date = date.AddDays(7);
            LoadDate();
            CreatSchedule();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
