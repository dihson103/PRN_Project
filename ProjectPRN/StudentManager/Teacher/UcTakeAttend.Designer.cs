namespace PresentationLayer.Teacher
{
    partial class UcTakeAttend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.rbtnAttend = new System.Windows.Forms.RadioButton();
            this.rbtnNotAttend = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(53, 53);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 82;
            this.dgvData.RowTemplate.Height = 41;
            this.dgvData.Size = new System.Drawing.Size(733, 720);
            this.dgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1151, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(990, 208);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(288, 39);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(990, 304);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 39);
            this.txtName.TabIndex = 6;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(990, 405);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(288, 39);
            this.txtClass.TabIndex = 7;
            // 
            // rbtnAttend
            // 
            this.rbtnAttend.AutoSize = true;
            this.rbtnAttend.Location = new System.Drawing.Point(876, 511);
            this.rbtnAttend.Name = "rbtnAttend";
            this.rbtnAttend.Size = new System.Drawing.Size(117, 36);
            this.rbtnAttend.TabIndex = 8;
            this.rbtnAttend.TabStop = true;
            this.rbtnAttend.Text = "Attend";
            this.rbtnAttend.UseVisualStyleBackColor = true;
            this.rbtnAttend.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnNotAttend
            // 
            this.rbtnNotAttend.AutoSize = true;
            this.rbtnNotAttend.Location = new System.Drawing.Point(1118, 511);
            this.rbtnNotAttend.Name = "rbtnNotAttend";
            this.rbtnNotAttend.Size = new System.Drawing.Size(161, 36);
            this.rbtnNotAttend.TabIndex = 9;
            this.rbtnNotAttend.TabStop = true;
            this.rbtnNotAttend.Text = "Not attend";
            this.rbtnNotAttend.UseVisualStyleBackColor = true;
            this.rbtnNotAttend.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(990, 610);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 46);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(848, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(292, 39);
            this.textBox5.TabIndex = 12;
            // 
            // UcTakeAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnNotAttend);
            this.Controls.Add(this.rbtnAttend);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "UcTakeAttend";
            this.Size = new System.Drawing.Size(1331, 818);
            this.Load += new System.EventHandler(this.UcTakeAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtClass;
        private RadioButton rbtnAttend;
        private RadioButton rbtnNotAttend;
        private Button btnSubmit;
        private TextBox textBox5;
    }
}
