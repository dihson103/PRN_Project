﻿using BusinessLayer.Service;
using BusinessLayer.Ultils;
using DataAcessLayer.Models;
using StudentManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private static Login instance = null;
        public static Login Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }
        private Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account a = AccountService.Instance.GetAccountByEmailAndPassWord(txtEmail.Text, txtPassword.Text);
            if (a != null)
            {
                Ultil.AccountLg = a;
                if (a.Id.Contains("AD"))
                {
                    new Admin_Home().Show();
                }else if (a.Id.Contains("TC"))
                {
                    Teacher_Home.Instance.Show();
                }
                else
                {
                    Student_Home.Instance.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail! Please login again!");
            }
        }
    }
}
