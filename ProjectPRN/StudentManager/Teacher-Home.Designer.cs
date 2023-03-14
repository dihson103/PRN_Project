namespace StudentManager
{
    partial class Teacher_Home
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnManageGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(565, 160);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(161, 131);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(317, 160);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(161, 131);
            this.btnViewSchedule.TabIndex = 4;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // btnManageGrade
            // 
            this.btnManageGrade.Location = new System.Drawing.Point(75, 160);
            this.btnManageGrade.Name = "btnManageGrade";
            this.btnManageGrade.Size = new System.Drawing.Size(161, 131);
            this.btnManageGrade.TabIndex = 3;
            this.btnManageGrade.Text = "Manage Grade";
            this.btnManageGrade.UseVisualStyleBackColor = true;
            // 
            // Teacher_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.btnManageGrade);
            this.Name = "Teacher_Home";
            this.Text = "Teacher_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEditProfile;
        private Button btnViewSchedule;
        private Button btnManageGrade;
    }
}