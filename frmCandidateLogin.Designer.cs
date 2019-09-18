namespace Candidate
{
    partial class frmCandidateLogin
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
            this.txtCandidatePassword = new System.Windows.Forms.TextBox();
            this.btnCandidateLogin = new System.Windows.Forms.Button();
            this.lblCandidatePassword = new System.Windows.Forms.Label();
            this.lblCandidateNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCandidatePassword
            // 
            this.txtCandidatePassword.Location = new System.Drawing.Point(159, 107);
            this.txtCandidatePassword.Name = "txtCandidatePassword";
            this.txtCandidatePassword.Size = new System.Drawing.Size(209, 22);
            this.txtCandidatePassword.TabIndex = 0;
            this.txtCandidatePassword.Text = "5022570001";
            // 
            // btnCandidateLogin
            // 
            this.btnCandidateLogin.Location = new System.Drawing.Point(159, 156);
            this.btnCandidateLogin.Name = "btnCandidateLogin";
            this.btnCandidateLogin.Size = new System.Drawing.Size(110, 35);
            this.btnCandidateLogin.TabIndex = 1;
            this.btnCandidateLogin.Text = "Daxil ol";
            this.btnCandidateLogin.UseVisualStyleBackColor = true;
            this.btnCandidateLogin.Click += new System.EventHandler(this.BtnCandidateLogin_Click);
            // 
            // lblCandidatePassword
            // 
            this.lblCandidatePassword.AutoSize = true;
            this.lblCandidatePassword.Location = new System.Drawing.Point(101, 110);
            this.lblCandidatePassword.Name = "lblCandidatePassword";
            this.lblCandidatePassword.Size = new System.Drawing.Size(40, 16);
            this.lblCandidatePassword.TabIndex = 2;
            this.lblCandidatePassword.Text = "Şifrə";
            // 
            // lblCandidateNote
            // 
            this.lblCandidateNote.AutoSize = true;
            this.lblCandidateNote.Location = new System.Drawing.Point(156, 132);
            this.lblCandidateNote.Name = "lblCandidateNote";
            this.lblCandidateNote.Size = new System.Drawing.Size(0, 16);
            this.lblCandidateNote.TabIndex = 3;
            // 
            // frmCandidateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 287);
            this.Controls.Add(this.lblCandidateNote);
            this.Controls.Add(this.lblCandidatePassword);
            this.Controls.Add(this.btnCandidateLogin);
            this.Controls.Add(this.txtCandidatePassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCandidateLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Namizəd Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCandidateLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCandidatePassword;
        private System.Windows.Forms.Button btnCandidateLogin;
        private System.Windows.Forms.Label lblCandidatePassword;
        private System.Windows.Forms.Label lblCandidateNote;
    }
}

