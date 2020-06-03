﻿namespace Sem2IntroProjectWaterfall0._1
{
    partial class Workshifts
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.flpWorkshifts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToggleView = new System.Windows.Forms.Button();
            this.btnChangePreferences = new System.Windows.Forms.Button();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.checkWorkers = new System.Windows.Forms.CheckBox();
            this.checkAdmins = new System.Windows.Forms.CheckBox();
            this.checkManagers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 24);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(385, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(260, 20);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "<Placeholder> - <Placeholder>";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(651, 30);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(26, 23);
            this.btnPreviousDay.TabIndex = 23;
            this.btnPreviousDay.Text = "<";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(683, 30);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(26, 23);
            this.btnNextDay.TabIndex = 24;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // flpWorkshifts
            // 
            this.flpWorkshifts.AutoSize = true;
            this.flpWorkshifts.Location = new System.Drawing.Point(12, 56);
            this.flpWorkshifts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpWorkshifts.MaximumSize = new System.Drawing.Size(712, 374);
            this.flpWorkshifts.Name = "flpWorkshifts";
            this.flpWorkshifts.Size = new System.Drawing.Size(712, 374);
            this.flpWorkshifts.TabIndex = 25;
            // 
            // btnToggleView
            // 
            this.btnToggleView.Location = new System.Drawing.Point(12, 435);
            this.btnToggleView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToggleView.Name = "btnToggleView";
            this.btnToggleView.Size = new System.Drawing.Size(114, 21);
            this.btnToggleView.TabIndex = 26;
            this.btnToggleView.Text = "Toggle Daily view";
            this.btnToggleView.UseVisualStyleBackColor = true;
            this.btnToggleView.Click += new System.EventHandler(this.btnToggleView_Click);
            // 
            // btnChangePreferences
            // 
            this.btnChangePreferences.Location = new System.Drawing.Point(131, 435);
            this.btnChangePreferences.Name = "btnChangePreferences";
            this.btnChangePreferences.Size = new System.Drawing.Size(125, 23);
            this.btnChangePreferences.TabIndex = 28;
            this.btnChangePreferences.Text = "Change Preferences";
            this.btnChangePreferences.UseVisualStyleBackColor = true;
            this.btnChangePreferences.Click += new System.EventHandler(this.btnChangePreferences_Click);
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(564, 435);
            this.cmbDepartmentSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(161, 21);
            this.cmbDepartmentSelect.TabIndex = 29;
            this.cmbDepartmentSelect.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentSelect_SelectedIndexChanged);
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(498, 437);
            this.lblDepartmentSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(62, 13);
            this.lblDepartmentSelect.TabIndex = 30;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // checkWorkers
            // 
            this.checkWorkers.AutoSize = true;
            this.checkWorkers.Checked = true;
            this.checkWorkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWorkers.Location = new System.Drawing.Point(500, 459);
            this.checkWorkers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkWorkers.Name = "checkWorkers";
            this.checkWorkers.Size = new System.Drawing.Size(66, 17);
            this.checkWorkers.TabIndex = 31;
            this.checkWorkers.Text = "Workers";
            this.checkWorkers.UseVisualStyleBackColor = true;
            this.checkWorkers.CheckedChanged += new System.EventHandler(this.checkWorkers_CheckedChanged);
            // 
            // checkAdmins
            // 
            this.checkAdmins.AutoSize = true;
            this.checkAdmins.Checked = true;
            this.checkAdmins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAdmins.Location = new System.Drawing.Point(564, 459);
            this.checkAdmins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkAdmins.Name = "checkAdmins";
            this.checkAdmins.Size = new System.Drawing.Size(91, 17);
            this.checkAdmins.TabIndex = 32;
            this.checkAdmins.Text = "Administrators";
            this.checkAdmins.UseVisualStyleBackColor = true;
            this.checkAdmins.CheckedChanged += new System.EventHandler(this.checkAdmins_CheckedChanged);
            // 
            // checkManagers
            // 
            this.checkManagers.AutoSize = true;
            this.checkManagers.Checked = true;
            this.checkManagers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkManagers.Location = new System.Drawing.Point(654, 459);
            this.checkManagers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkManagers.Name = "checkManagers";
            this.checkManagers.Size = new System.Drawing.Size(73, 17);
            this.checkManagers.TabIndex = 33;
            this.checkManagers.Text = "Managers";
            this.checkManagers.UseVisualStyleBackColor = true;
            this.checkManagers.CheckedChanged += new System.EventHandler(this.checkManagers_CheckedChanged);
            // 
            // Workshifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 486);
            this.Controls.Add(this.checkManagers);
            this.Controls.Add(this.checkAdmins);
            this.Controls.Add(this.checkWorkers);
            this.Controls.Add(this.lblDepartmentSelect);
            this.Controls.Add(this.cmbDepartmentSelect);
            this.Controls.Add(this.btnChangePreferences);
            this.Controls.Add(this.btnToggleView);
            this.Controls.Add(this.flpWorkshifts);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBack);
            this.Name = "Workshifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workshifts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.FlowLayoutPanel flpWorkshifts;
        private System.Windows.Forms.Button btnToggleView;
        private System.Windows.Forms.Button btnChangePreferences;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.CheckBox checkWorkers;
        private System.Windows.Forms.CheckBox checkAdmins;
        private System.Windows.Forms.CheckBox checkManagers;
    }
}