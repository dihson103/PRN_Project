using BusinessLayer.Service;
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
    public partial class UcTeacherManageClass : UserControl
    {
        private static UcTeacherManageClass instance = null;
        public static UcTeacherManageClass Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcTeacherManageClass();
                }
                return instance;
            }
        }
        public UcTeacherManageClass()
        {
            InitializeComponent();
            LoadDB();
        }

        BindingSource source;
        private void LoadDB()
        {
            source= new BindingSource();
            source.DataSource = ClassService.Instance.GetClassesByAccount();
            dgvData.DataSource = source;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", source, "Id");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", source, "Name");
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new TeacherUpdateGrade(txtID.Text, txtName.Text).Show();
        }
    }
}
