using BusinessLayer.Service;
using DataAcessLayer.Models;
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
    public partial class TeacherUpdateGrade : Form
    {
        public TeacherUpdateGrade(String classCode, String nameClass)
        {
            InitializeComponent();
            code = classCode;
            txtName.Text = nameClass;
            Load();
        }
        private String code;

        BindingSource source;
        private void Load()
        {
            source= new BindingSource();
            source.DataSource = GradeService.Instance.GetGradesByClass(code);
            dgvData.DataSource = source;

            txtCode.DataBindings.Clear();
            txtMark1.DataBindings.Clear();
            txtMark2.DataBindings.Clear();
            txtMark3.DataBindings.Clear();

            txtCode.DataBindings.Add("Text", source, "IdStudent");
            txtMark1.DataBindings.Add("Text", source, "Mark1");
            txtMark2.DataBindings.Add("Text", source, "Mark2");
            txtMark3.DataBindings.Add("Text", source, "Mark3");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Grade a = MyStock.Instance.Grades.SingleOrDefault(x => x.IdClass == code && x.IdStudent == txtCode.Text);
            if (a != null)
            {
                a.Mark1 = Int32.Parse(txtMark1.Text);
                a.Mark2 = Int32.Parse(txtMark2.Text);
                a.Mark3 = Int32.Parse("9");
                MyStock.Instance.SaveChanges();
                Load();
            }
            else
            {
                MessageBox.Show("Loi");
            }

        }
    }
}
