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

namespace StudentManager
{
    public partial class Student_Home : Form
    {

        private static Student_Home instance = null;
        public static Student_Home Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Student_Home();
                }
                return instance;
            }
        }
        private Student_Home()
        {
            InitializeComponent();
            palStHome.Controls.Add(UcStudentHome.Instance);
            UcStudentHome.Instance.Dock = DockStyle.Fill;
            UcStudentHome.Instance.BringToFront();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palStHome.Controls.Contains(UcStudentHome.Instance))
            {
                palStHome.Controls.Add(UcStudentHome.Instance);
                UcStudentHome.Instance.Dock = DockStyle.Fill;
                UcStudentHome.Instance.BringToFront();
            }
            else
            {
                UcStudentHome.Instance.BringToFront();
            }
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!palStHome.Controls.Contains(UcStudentSchedule.Instance))
            {
                palStHome.Controls.Add(UcStudentSchedule.Instance);
                UcStudentSchedule.Instance.Dock = DockStyle.Fill;
                UcStudentSchedule.Instance.BringToFront();
            }
            else
            {
                UcStudentSchedule.Instance.BringToFront();
            }
        }

        private void viewGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palStHome.Controls.Contains(UcStudentGrade.Instance))
            {
                palStHome.Controls.Add(UcStudentGrade.Instance);
                UcStudentGrade.Instance.Dock = DockStyle.Fill;
                UcStudentGrade.Instance.BringToFront();
            }
            else
            {
                UcStudentGrade.Instance.BringToFront();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palStHome.Controls.Contains(UcProfile.Instance))
            {
                palStHome.Controls.Add(UcProfile.Instance);
                UcProfile.Instance.Dock = DockStyle.Fill;
                UcProfile.Instance.BringToFront();
            }
            else
            {
                UcProfile.Instance.BringToFront();
            }
        }
    }
}
