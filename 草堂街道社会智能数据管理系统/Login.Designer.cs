namespace 草堂街道社会智能数据管理系统
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.laUser = new System.Windows.Forms.Label();
            this.laPassword = new System.Windows.Forms.Label();
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(577, 471);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(731, 471);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(577, 417);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(236, 21);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(577, 359);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(236, 21);
            this.tbUser.TabIndex = 0;
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Location = new System.Drawing.Point(509, 362);
            this.laUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(41, 12);
            this.laUser.TabIndex = 4;
            this.laUser.Text = "用户名";
            // 
            // laPassword
            // 
            this.laPassword.AutoSize = true;
            this.laPassword.Location = new System.Drawing.Point(509, 419);
            this.laPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(29, 12);
            this.laPassword.TabIndex = 5;
            this.laPassword.Text = "密码";
            // 
            // errInfo
            // 
            this.errInfo.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 565);
            this.Controls.Add(this.laPassword);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登陆";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.ErrorProvider errInfo;
    }
}