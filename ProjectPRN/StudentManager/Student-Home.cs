using PresentationLayer;
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
            if (!palStHome.Controls.Contains(UcScheduleStudent.Instance))
            {
                palStHome.Controls.Add(UcScheduleStudent.Instance);
                UcScheduleStudent.Instance.Dock = DockStyle.Fill;
                UcScheduleStudent.Instance.BringToFront();
            }
            else
            {
                UcScheduleStudent.Instance.BringToFront();
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

        private void palStHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            palStHome.Controls.Add(UcStudentHome.Instance);
            UcStudentHome.Instance.Dock = DockStyle.Fill;
            UcStudentHome.Instance.BringToFront();
            Login.Instance.Show();
            UcProfile.setInstanceNull();
        }

        private void Student_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Instance.Close();
            
        }
    }
}
