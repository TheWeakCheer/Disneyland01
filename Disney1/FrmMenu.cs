﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Disney1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        DisneyDataDataContext db;
        int errorTimes = 0;
        int lockTime = 10;
        int changePwdDay = 30;

        public void DataRefresh()
        {
            Global.User = null;
            gpbLogin.Enabled = true;
            gpbLogin.Visible = true;
            txtAccount.Text = "";
            txtPwd.Text = "";
            panelMenu.Visible = false;
            panelMenu.Enabled = false;
            btnResort_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Search account
            db = new DisneyDataDataContext();
            if (txtAccount.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Account or password can not be empty.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var user = db.Account.ToList().FirstOrDefault(x => x.AccountId == txtAccount.Text && x.Password == txtPwd.Text);

            //Account or password incorrcet
            if (user == null)
            {
                errorTimes += 1;
                MessageBox.Show("Account or password incorrect.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (errorTimes >= 3)
                {
                    MessageBox.Show("You entered the account incorrcetly more than 3 times,\n" +
                        "you should wait for 10 second.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.Enabled = false;
                    timerLock.Start();
                }
                return;
            }

            //Login successfully
            try
            {
                Global.User = user;
                db.LogRecord.InsertOnSubmit(new LogRecord()
                {
                    AccountId = user.AccountId,
                    LoginTime = DateTime.Now
                });
                db.SubmitChanges();
                lblUserInfo.Text = $"Welcome {user.Name}\nYou are {user.Group.GroupName}";
                gpbLogin.Enabled = false;
                gpbLogin.Visible = false;
                panelMenu.Visible = true;
                panelMenu.Enabled = true;
                MessageBox.Show("Login successfully.", "Disneyland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimeSpan ts = DateTime.Now - user.LastTimeChangePwd;
                if (ts.TotalDays > changePwdDay)
                {
                    new FrmChangePwd().ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void timerLock_Tick(object sender, EventArgs e)
        {
            //Countdown lock
            lockTime -= 1;
            btnLogin.Text = lockTime.ToString();
            if (lockTime == 0)
            {
                lockTime = 10;
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
                timerLock.Stop();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout
            this.DataRefresh();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Sign up account
            signUp1.DataRefresh();
            signUp1.BringToFront();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.DataRefresh();
            this.btnResort_Click(null, null);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Show user profile
            profile1.DataRefresh();
            profile1.BringToFront();
        }

        private void btnResort_Click(object sender, EventArgs e)
        {
            //Show resort information
            if (Properties.Settings.Default.ShowMode == 1)
            {
                carouselResort1.DataRefresh();
                carouselResort1.BringToFront();
            }
            else
            {
                generalResort1.DataRefresh();
                generalResort1.BringToFront();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            switch (Global.User.GroupNo)
            {
                case 1:
                    
                    break;
                case 2:
                    resortManager1.DataRefresh();
                    resortManager1.BringToFront();
                    break;
                case 3:
                    resortMember1.BringToFront();
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
    }
}
