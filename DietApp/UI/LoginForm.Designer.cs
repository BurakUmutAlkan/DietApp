namespace DietApp
{
    partial class LoginForm
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGoToMainForm = new System.Windows.Forms.Button();
            this.btnGoToRegisterForm = new System.Windows.Forms.Label();
            this.btnGoToPasswordResetForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Image = global::DietApp.Properties.Resources.Lorem_Fitsum;
            this.pbLogo.Location = new System.Drawing.Point(58, 59);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(250, 250);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(58, 340);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 365);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 416);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(62, 441);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 29);
            this.txtPassword.TabIndex = 2;
            // 
            // btnGoToMainForm
            // 
            this.btnGoToMainForm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGoToMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToMainForm.Location = new System.Drawing.Point(62, 511);
            this.btnGoToMainForm.Name = "btnGoToMainForm";
            this.btnGoToMainForm.Size = new System.Drawing.Size(246, 44);
            this.btnGoToMainForm.TabIndex = 3;
            this.btnGoToMainForm.Text = "Login";
            this.btnGoToMainForm.UseVisualStyleBackColor = false;
            this.btnGoToMainForm.Click += new System.EventHandler(this.btnGoToMainForm_Click);
            // 
            // btnGoToRegisterForm
            // 
            this.btnGoToRegisterForm.AutoSize = true;
            this.btnGoToRegisterForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGoToRegisterForm.Location = new System.Drawing.Point(12, 646);
            this.btnGoToRegisterForm.Name = "btnGoToRegisterForm";
            this.btnGoToRegisterForm.Size = new System.Drawing.Size(115, 21);
            this.btnGoToRegisterForm.TabIndex = 1;
            this.btnGoToRegisterForm.Text = "Create Account";
            this.btnGoToRegisterForm.Click += new System.EventHandler(this.btnGoToRegisterForm_Click);
            // 
            // btnGoToPasswordResetForm
            // 
            this.btnGoToPasswordResetForm.AutoSize = true;
            this.btnGoToPasswordResetForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGoToPasswordResetForm.Location = new System.Drawing.Point(243, 646);
            this.btnGoToPasswordResetForm.Name = "btnGoToPasswordResetForm";
            this.btnGoToPasswordResetForm.Size = new System.Drawing.Size(119, 21);
            this.btnGoToPasswordResetForm.TabIndex = 1;
            this.btnGoToPasswordResetForm.Text = "Reset Password";
            this.btnGoToPasswordResetForm.Click += new System.EventHandler(this.btnGoToPasswordResetForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 676);
            this.Controls.Add(this.btnGoToMainForm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGoToPasswordResetForm);
            this.Controls.Add(this.btnGoToRegisterForm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGoToMainForm;
        private System.Windows.Forms.Label btnGoToRegisterForm;
        private System.Windows.Forms.Label btnGoToPasswordResetForm;
    }
}

