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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChoseAll_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dgvAttendace.RowCount;i++)
            {
                dgvAttendace.Rows[i].Cells[2].Value = true;
            }
        }

        private void btnUnChoseAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAttendace.RowCount; i++)
            {
                dgvAttendace.Rows[i].Cells[2].Value = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
