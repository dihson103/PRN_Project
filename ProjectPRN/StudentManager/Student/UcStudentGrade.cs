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

            txtCode.DataBindings.Add("Text", source, "IdStudent");
            txtMark1.DataBindings.Add("Text", source, "Mark1");
            txtMark2.DataBindings.Add("Text", source, "Mark2");
            txtMark3.DataBindings.Add("Text", source, "Mark3");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
