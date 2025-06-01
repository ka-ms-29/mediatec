namespace mediatec.view
{
    partial class FrmAuthentification
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
            this.btnSeConnect = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSeConnect
            // 
            this.btnSeConnect.Location = new System.Drawing.Point(170, 152);
            this.btnSeConnect.Name = "btnSeConnect";
            this.btnSeConnect.Size = new System.Drawing.Size(134, 38);
            this.btnSeConnect.TabIndex = 0;
            this.btnSeConnect.Text = "se connecter";
            this.btnSeConnect.UseVisualStyleBackColor = true;
            this.btnSeConnect.Click += new System.EventHandler(this.btnSeConnect_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(21, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "login";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(21, 81);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(38, 20);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "pwd";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(86, 23);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 26);
            this.txtLogin.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(86, 81);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(218, 26);
            this.txtPwd.TabIndex = 4;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 209);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnSeConnect);
            this.Name = "FrmAuthentification";
            this.Text = "MediaTec_Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeConnect;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPwd;
    }
}