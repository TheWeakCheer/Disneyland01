﻿namespace Disney1.Manage.Admin
{
    partial class ManageAuthority
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
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.lstAuthority = new System.Windows.Forms.ListBox();
            this.cbAllow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGroup
            // 
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.ItemHeight = 16;
            this.lstGroup.Location = new System.Drawing.Point(148, 52);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(228, 532);
            this.lstGroup.TabIndex = 0;
            this.lstGroup.SelectedIndexChanged += new System.EventHandler(this.lstGroup_SelectedIndexChanged);
            // 
            // lstAuthority
            // 
            this.lstAuthority.FormattingEnabled = true;
            this.lstAuthority.ItemHeight = 16;
            this.lstAuthority.Location = new System.Drawing.Point(415, 52);
            this.lstAuthority.Name = "lstAuthority";
            this.lstAuthority.Size = new System.Drawing.Size(299, 532);
            this.lstAuthority.TabIndex = 0;
            this.lstAuthority.SelectedIndexChanged += new System.EventHandler(this.lstAuthority_SelectedIndexChanged);
            // 
            // cbAllow
            // 
            this.cbAllow.AutoSize = true;
            this.cbAllow.Location = new System.Drawing.Point(747, 52);
            this.cbAllow.Name = "cbAllow";
            this.cbAllow.Size = new System.Drawing.Size(65, 20);
            this.cbAllow.TabIndex = 1;
            this.cbAllow.Text = "Allow";
            this.cbAllow.UseVisualStyleBackColor = true;
            this.cbAllow.CheckedChanged += new System.EventHandler(this.cbAllow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authority";
            // 
            // ManageAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllow);
            this.Controls.Add(this.lstAuthority);
            this.Controls.Add(this.lstGroup);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageAuthority";
            this.Size = new System.Drawing.Size(1031, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGroup;
        private System.Windows.Forms.ListBox lstAuthority;
        private System.Windows.Forms.CheckBox cbAllow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
