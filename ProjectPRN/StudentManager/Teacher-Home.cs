using PresentationLayer;
using PresentationLayer.Student;
using PresentationLayer.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Teacher_Home : Form
    {
        private static Teacher_Home instance;
        public static Teacher_Home Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Teacher_Home();
                }
                return instance;
            }
        }
        private Teacher_Home()
        {
            InitializeComponent();
            palHome.Controls.Add(UcTeacherHome.Instance);
            UcTeacherHome.Instance.Dock = DockStyle.Fill;
            UcTeacherHome.Instance.BringToFront();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palHome.Controls.Contains(UcTeacherHome.Instance))
            {
                palHome.Controls.Add(UcTeacherHome.Instance);
                UcTeacherHome.Instance.Dock = DockStyle.Fill;
                UcTeacherHome.Instance.BringToFront();
            }
            else
            {
                UcTeacherHome.Instance.BringToFront();
            }
        }

        private void Teacher_Home_Load(object sender, EventArgs e)
        {

        }

        private void manageGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palHome.Controls.Contains(UcTeacherManageClass.Instance))
            {
                palHome.Controls.Add(UcTeacherManageClass.Instance);
                UcTeacherManageClass.Instance.Dock = DockStyle.Fill;
                UcTeacherManageClass.Instance.BringToFront();
            }
            else
            {
                UcTeacherManageClass.Instance.BringToFront();
            }
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palHome.Controls.Contains(UcTeacherSchedule.Instance))
            {
                palHome.Controls.Add(UcTeacherSchedule.Instance);
                UcTeacherSchedule.Instance.Dock = DockStyle.Fill;
                UcTeacherSchedule.Instance.BringToFront();
            }
            else
            {
                UcTeacherSchedule.Instance.BringToFront();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palHome.Controls.Contains(UcProfile.Instance))
            {
                palHome.Controls.Add(UcProfile.Instance);
                UcProfile.Instance.Dock = DockStyle.Fill;
                UcProfile.Instance.BringToFront();
            }
            else
            {
                UcProfile.Instance.BringToFront();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            palHome.Controls.Add(UcTeacherHome.Instance);
            UcTeacherHome.Instance.Dock = DockStyle.Fill;
            UcTeacherHome.Instance.BringToFront();
            Login.Instance.Show();
            UcProfile.setInstanceNull();
        }

        private void Teacher_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Instance.Close();
            
        }

        private void takeAttendentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!palHome.Controls.Contains(UcTakeAttend.Instance))
            {
                palHome.Controls.Add(UcTakeAttend.Instance);
                UcTakeAttend.Instance.Dock = DockStyle.Fill;
                UcTakeAttend.Instance.BringToFront();
            }
            else
            {
                UcTakeAttend.Instance.BringToFront();
            }
        }
    }
}
