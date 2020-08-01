﻿namespace Disney1
{
    partial class FrmMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnResort = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerLock = new System.Windows.Forms.Timer(this.components);
            this.resortManager1 = new Disney1.Manage.ResortManager();
            this.generalResort1 = new Disney1.GeneralResort();
            this.carouselResort1 = new Disney1.CarouselResort();
            this.profile1 = new Disney1.Profile();
            this.signUp1 = new Disney1.SignUp();
            this.resortMember1 = new Disney1.Manage.ResortMember();
            this.btnLog = new System.Windows.Forms.Button();
            this.administrator1 = new Disney1.Manage.Administrator();
            this.panel1.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.gpbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 681);
            this.panel1.TabIndex = 0;
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnSignUp);
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.txtPwd);
            this.gpbLogin.Controls.Add(this.label2);
            this.gpbLogin.Controls.Add(this.txtAccount);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Location = new System.Drawing.Point(12, 36);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(208, 163);
            this.gpbLogin.TabIndex = 0;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(9, 121);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(193, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "2.Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(9, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "1.Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(79, 59);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(123, 27);
            this.txtPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(79, 26);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(123, 27);
            this.txtAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnLog);
            this.panelMenu.Controls.Add(this.btnManage);
            this.panelMenu.Controls.Add(this.btnResort);
            this.panelMenu.Location = new System.Drawing.Point(12, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(208, 129);
            this.panelMenu.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(9, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(193, 23);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "3.Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(9, 71);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(193, 23);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "5.Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnResort
            // 
            this.btnResort.Location = new System.Drawing.Point(9, 42);
            this.btnResort.Name = "btnResort";
            this.btnResort.Size = new System.Drawing.Size(193, 23);
            this.btnResort.TabIndex = 0;
            this.btnResort.Text = "4.Resort";
            this.btnResort.UseVisualStyleBackColor = true;
            this.btnResort.Click += new System.EventHandler(this.btnResort_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(21, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "7.Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timerLock
            // 
            this.timerLock.Interval = 1000;
            this.timerLock.Tick += new System.EventHandler(this.timerLock_Tick);
            // 
            // resortManager1
            // 
            this.resortManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resortManager1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resortManager1.Location = new System.Drawing.Point(233, 0);
            this.resortManager1.Margin = new System.Windows.Forms.Padding(4);
            this.resortManager1.Name = "resortManager1";
            this.resortManager1.Size = new System.Drawing.Size(1031, 681);
            this.resortManager1.TabIndex = 5;
            // 
            // generalResort1
            // 
            this.generalResort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalResort1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.generalResort1.Location = new System.Drawing.Point(233, 0);
            this.generalResort1.Margin = new System.Windows.Forms.Padding(4);
            this.generalResort1.Name = "generalResort1";
            this.generalResort1.Size = new System.Drawing.Size(1031, 681);
            this.generalResort1.TabIndex = 4;
            // 
            // carouselResort1
            // 
            this.carouselResort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carouselResort1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carouselResort1.Location = new System.Drawing.Point(233, 0);
            this.carouselResort1.Margin = new System.Windows.Forms.Padding(4);
            this.carouselResort1.Name = "carouselResort1";
            this.carouselResort1.Size = new System.Drawing.Size(1031, 681);
            this.carouselResort1.TabIndex = 3;
            // 
            // profile1
            // 
            this.profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.profile1.Location = new System.Drawing.Point(233, 0);
            this.profile1.Margin = new System.Windows.Forms.Padding(4);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1031, 681);
            this.profile1.TabIndex = 2;
            // 
            // signUp1
            // 
            this.signUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUp1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signUp1.Location = new System.Drawing.Point(233, 0);
            this.signUp1.Margin = new System.Windows.Forms.Padding(4);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(1031, 681);
            this.signUp1.TabIndex = 1;
            // 
            // resortMember1
            // 
            this.resortMember1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resortMember1.Location = new System.Drawing.Point(233, 0);
            this.resortMember1.Margin = new System.Windows.Forms.Padding(4);
            this.resortMember1.Name = "resortMember1";
            this.resortMember1.Size = new System.Drawing.Size(1031, 681);
            this.resortMember1.TabIndex = 6;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(9, 100);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(193, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "6.Log Record";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // administrator1
            // 
            this.administrator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administrator1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.administrator1.Location = new System.Drawing.Point(233, 0);
            this.administrator1.Margin = new System.Windows.Forms.Padding(4);
            this.administrator1.Name = "administrator1";
            this.administrator1.Size = new System.Drawing.Size(1031, 681);
            this.administrator1.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.administrator1);
            this.Controls.Add(this.resortMember1);
            this.Controls.Add(this.resortManager1);
            this.Controls.Add(this.generalResort1);
            this.Controls.Add(this.carouselResort1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.signUp1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disneyland";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerLock;
        private SignUp signUp1;
        private Profile profile1;
        private CarouselResort carouselResort1;
        private GeneralResort generalResort1;
        private Manage.ResortManager resortManager1;
        private Manage.ResortMember resortMember1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnResort;
        private System.Windows.Forms.Button btnLog;
        private Manage.Administrator administrator1;
    }
}

