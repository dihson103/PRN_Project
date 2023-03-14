namespace StudentManager
{
    partial class Admin_Home
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
            this.btnManageClass = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageClass
            // 
            this.btnManageClass.Location = new System.Drawing.Point(76, 121);
            this.btnManageClass.Name = "btnManageClass";
            this.btnManageClass.Size = new System.Drawing.Size(161, 131);
            this.btnManageClass.TabIndex = 0;
            this.btnManageClass.Text = "Manage Class";
            this.btnManageClass.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Location = new System.Drawing.Point(318, 121);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(161, 131);
            this.btnManageAccount.TabIndex = 1;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(566, 121);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(161, 131);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnManageClass);
            this.Name = "Admin_Home";
            this.Text = "Admin_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnManageClass;
        private Button btnManageAccount;
        private Button btnEditProfile;
    }
}