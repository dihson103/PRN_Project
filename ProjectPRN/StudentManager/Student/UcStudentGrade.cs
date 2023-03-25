using BusinessLayer.Service;
using BusinessLayer.Ultils;
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

namespace PresentationLayer.Student
{
    public partial class UcStudentGrade : UserControl
    {
        private static UcStudentGrade instance = null;

        public static UcStudentGrade Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcStudentGrade();
                }
                return instance;
            }
        }

        BindingSource source;
        private UcStudentGrade()
        {
            InitializeComponent();
            
            LoadData();
        }

        private void LoadData()
        {
            source = new BindingSource();
            Account a = Ultil.AccountLg;
            source.DataSource = GradeService.Instance.GetGrades(a.Id);
            dgvData.DataSource = source;

            txtCode.DataBindings.Clear();
            txtMark1.DataBindings.Clear();
            txtMark2.DataBindings.Clear();
            txtMark3.DataBindings.Clear();

            txtCode.DataBindings.Add("Text", source, "IdClass");
            txtMark1.DataBindings.Add("Text", source, "Mark1");
            txtMark2.DataBindings.Add("Text", source, "Mark2");
            txtMark3.DataBindings.Add("Text", source, "Mark3");
            txtNameTeacher.Text = Ultil.AccountLg.Name;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            source = new BindingSource();
            Account a = Ultil.AccountLg;
            source.DataSource = MyStock.Instance.Grades.Where(x => x.IdClass.Contains(txtSearch.Text) && x.IdStudent == Ultil.AccountLg.Id).ToList();
            dgvData.DataSource = source;

            txtCode.DataBindings.Clear();
            txtMark1.DataBindings.Clear();
            txtMark2.DataBindings.Clear();
            txtMark3.DataBindings.Clear();

            txtCode.DataBindings.Add("Text", source, "IdClass");
            txtMark1.DataBindings.Add("Text", source, "Mark1");
            txtMark2.DataBindings.Add("Text", source, "Mark2");
            txtMark3.DataBindings.Add("Text", source, "Mark3");
            txtNameTeacher.Text = Ultil.AccountLg.Name;

        }
    }
}
