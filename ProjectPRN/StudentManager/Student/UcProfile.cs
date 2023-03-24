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
    public partial class UcProfile : UserControl
    {
        private static UcProfile instance = null;

        public static UcProfile Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcProfile();
                }
                return instance;
            }
        }
        private UcProfile()
        {
            InitializeComponent();
            Account a = Ultil.AccountLg;
            txtCode.Text = a.Id.ToString();
            txtEmail.Text = a.Email.ToString();
            rbtnMale.Checked = a.Sex;
            txtPass.Text = a.Password;
            txtName.Text = a.Name.ToString();
            txtAddress.Text = a.Address;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account g = new Account
            {
                Id = txtCode.Text,
                Name = txtName.Text,
                Address = txtAddress.Text,
                Password = txtPass.Text,
                Email= txtEmail.Text,
                Sex = rbtnMale.Checked
            };
            AccountService.Instance.UpdateAccount(g);
        }
    }
}
