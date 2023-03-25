using BusinessLayer.Service;
using BusinessLayer.Ultils;
using DataAcessLayer.Models;
using Microsoft.Identity.Client;
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
    
    public partial class UcScheduleStudent : UserControl
    {
        private static UcScheduleStudent instance = null;
        public static UcScheduleStudent Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcScheduleStudent();
                }
                return instance;
            }
        }
        private DateTime date;
        private UcScheduleStudent()
        {
            InitializeComponent();
            date = DateTime.Now;
            LoadDate();
            CreatSchedule();
        }

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

        private lichhoc idCl;
        private void CreatSchedule()
        {
            flpSchedule.Controls.Clear();
            List<Schedule> schedules = ScheduleService.Instance.GetSchedules(Ultil.FirstDayOfWeek(date), Ultil.LastDayOfWeek(date));
            List<lichhoc> listB = new List<lichhoc>();
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
                b.Width = 72 + 5;
                b.Height = 110 / 2 - 6;
                b.Name = "btn" + $"{i}";
                b.Enabled = false;
                flpSchedule.Controls.Add(b);
                foreach (lichhoc j in listB)
                {
                    if (i == j.Index)
                    {
                        b.Enabled = true;
                        b.Text = j.IdClass;
                        idCl = j;
                        b.Click += new EventHandler(b_Click); 
                    }
                }

            }


        }

        private void b_Click(object sender, EventArgs e)
        {
            new ScheduleDetail(idCl).Show();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            date = date.AddDays(7);
            LoadDate();
            CreatSchedule();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-7);
            LoadDate();
            CreatSchedule();
        }
    }
}
