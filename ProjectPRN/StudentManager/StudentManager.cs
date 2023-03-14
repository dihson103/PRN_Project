namespace StudentManager
{
    public partial class StudentManager : Form
    {
        public StudentManager()
        {
            InitializeComponent();
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            setEnabledLabelAndTxt(false);

            lbAddress.Enabled = false;
            blBirth.Enabled = false;
            lbEmail.Enabled = false;  
            lbGender.Enabled = false;
            lbName.Enabled = false;

            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEnabledLabelAndTxt(true);
            btnSubmit.Enabled=true;
            btnCancel.Enabled=true;
        }
        private void setEnabledLabelAndTxt(Boolean a)
        {
            lbAddress.Enabled = a;
            blBirth.Enabled = a;
            lbName.Enabled = a;
            lbGender.Enabled = a;
            lbEmail.Enabled = a;

            txtName.Enabled = a;
            txtEmail.Enabled = a;
            txtBirth.Enabled = a;
            txtAddress.Enabled = a;
            txtGender.Enabled = a;
        }
        
        private void ClearTextInTextBox()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtBirth.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {   
            ClearTextInTextBox();
            StudentManager_Load(sender, e); 
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled= true;
            btnDelete.Enabled= true;
            btnAdd.Enabled= false;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled= true;
            setEnabledLabelAndTxt(true);
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}