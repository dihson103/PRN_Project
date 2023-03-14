namespace StudentManager
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAttendace = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChoseAll = new System.Windows.Forms.Button();
            this.btnUnChoseAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendace)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendace
            // 
            this.dgvAttendace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dataGridViewCheckBoxColumn1});
            this.dgvAttendace.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAttendace.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendace.Name = "dgvAttendace";
            this.dgvAttendace.RowHeadersWidth = 51;
            this.dgvAttendace.RowTemplate.Height = 29;
            this.dgvAttendace.Size = new System.Drawing.Size(502, 450);
            this.dgvAttendace.TabIndex = 0;
            this.dgvAttendace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Attendance";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(531, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(531, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChoseAll
            // 
            this.btnChoseAll.Location = new System.Drawing.Point(531, 39);
            this.btnChoseAll.Name = "btnChoseAll";
            this.btnChoseAll.Size = new System.Drawing.Size(114, 48);
            this.btnChoseAll.TabIndex = 3;
            this.btnChoseAll.Text = "Chose All";
            this.btnChoseAll.UseVisualStyleBackColor = true;
            this.btnChoseAll.Click += new System.EventHandler(this.btnChoseAll_Click);
            // 
            // btnUnChoseAll
            // 
            this.btnUnChoseAll.Location = new System.Drawing.Point(531, 129);
            this.btnUnChoseAll.Name = "btnUnChoseAll";
            this.btnUnChoseAll.Size = new System.Drawing.Size(114, 48);
            this.btnUnChoseAll.TabIndex = 4;
            this.btnUnChoseAll.Text = "Unchose All";
            this.btnUnChoseAll.UseVisualStyleBackColor = true;
            this.btnUnChoseAll.Click += new System.EventHandler(this.btnUnChoseAll_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnUnChoseAll);
            this.Controls.Add(this.btnChoseAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAttendace);
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAttendace;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Button btnSave;
        private Button btnClose;
        private Button btnChoseAll;
        private Button btnUnChoseAll;
    }
}