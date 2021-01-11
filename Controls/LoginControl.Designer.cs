
namespace BookStock
{
    partial class LoginControl
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.llblLoginRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txbLoginEmail = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.llblLoginRegister);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.txbLoginPassword);
            this.gbxLogin.Controls.Add(this.lblLoginPassword);
            this.gbxLogin.Controls.Add(this.txbLoginEmail);
            this.gbxLogin.Controls.Add(this.lblLoginEmail);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogin.Location = new System.Drawing.Point(29, 25);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(291, 343);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login";
            // 
            // llblLoginRegister
            // 
            this.llblLoginRegister.AutoSize = true;
            this.llblLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLoginRegister.Location = new System.Drawing.Point(6, 296);
            this.llblLoginRegister.Name = "llblLoginRegister";
            this.llblLoginRegister.Size = new System.Drawing.Size(266, 18);
            this.llblLoginRegister.TabIndex = 9;
            this.llblLoginRegister.TabStop = true;
            this.llblLoginRegister.Text = "If you don\'t have account, Register now";
            this.llblLoginRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLoginRegister_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(26, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(226, 41);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.Location = new System.Drawing.Point(28, 172);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.Size = new System.Drawing.Size(229, 29);
            this.txbLoginPassword.TabIndex = 7;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(24, 139);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(78, 20);
            this.lblLoginPassword.TabIndex = 6;
            this.lblLoginPassword.Text = "Password\n";
            // 
            // txbLoginEmail
            // 
            this.txbLoginEmail.Location = new System.Drawing.Point(26, 91);
            this.txbLoginEmail.Name = "txbLoginEmail";
            this.txbLoginEmail.Size = new System.Drawing.Size(229, 29);
            this.txbLoginEmail.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.Location = new System.Drawing.Point(22, 58);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(48, 20);
            this.lblLoginEmail.TabIndex = 0;
            this.lblLoginEmail.Text = "Email\r\n";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 406);
            this.Controls.Add(this.gbxLogin);
            this.Name = "LoginControl";
            this.Text = "Login Now";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txbLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        public System.Windows.Forms.TextBox txbLoginEmail;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.LinkLabel llblLoginRegister;
    }
}