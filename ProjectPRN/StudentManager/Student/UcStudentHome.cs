﻿using BusinessLayer.Ultils;
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
    public partial class UcStudentHome : UserControl
    {
        private static UcStudentHome instance = null;
        public static UcStudentHome Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcStudentHome();
                }
                return instance;
            }
        }
        private UcStudentHome()
        {
            InitializeComponent();
            lblWellcome.Text = "Wellcome " + Ultil.AccountLg.Name;
        }
    }
}
