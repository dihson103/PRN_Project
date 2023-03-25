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
    public partial class UcTakeAttend : UserControl
    {
        private static UcTakeAttend instance = null;
        public static UcTakeAttend Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UcTakeAttend();
                }
                return instance;
            }
        }
        BindingSource source;
        private UcTakeAttend()
        {
            InitializeComponent();

            source= new BindingSource();
            source.DataSource = MyStock.Instance.Schedules.Where(x => x.Date == DateTime.Now).ToList();
            dgvData.DataSource = source;
            txtClass.DataBindings.Clear();
            txtId.DataBindings.Clear();
            txtClass.DataBindings.Add("Text", source, "IdClass");
            txtId.DataBindings.Add("Text", source, "IdStudent");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UcTakeAttend_Load(object sender, EventArgs e)
        {

        }
    }
}
