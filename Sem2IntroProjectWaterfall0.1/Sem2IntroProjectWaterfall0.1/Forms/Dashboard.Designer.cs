﻿namespace Sem2IntroProjectWaterfall0._1
{
    partial class Dashboard
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
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnWorkshifts = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.btnRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(129, 123);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(107, 98);
            this.btnStocks.TabIndex = 0;
            this.btnStocks.Text = "Stock";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(129, 229);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(107, 98);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Management";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(244, 123);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(107, 98);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnWorkshifts
            // 
            this.btnWorkshifts.Location = new System.Drawing.Point(244, 229);
            this.btnWorkshifts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorkshifts.Name = "btnWorkshifts";
            this.btnWorkshifts.Size = new System.Drawing.Size(107, 98);
            this.btnWorkshifts.TabIndex = 3;
            this.btnWorkshifts.Text = "Work Shifts";
            this.btnWorkshifts.UseVisualStyleBackColor = true;
            this.btnWorkshifts.Click += new System.EventHandler(this.btnWorkshifts_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 58);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(423, 432);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(207, 28);
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.BtnCheckin_Click);
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 16;
            this.lbWorkers.Location = new System.Drawing.Point(423, 62);
            this.lbWorkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(205, 356);
            this.lbWorkers.TabIndex = 6;
            // 
            // btnRequests
            // 
            this.btnRequests.Location = new System.Drawing.Point(423, 26);
            this.btnRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(207, 28);
            this.btnRequests.TabIndex = 7;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 470);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWorkshifts);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnStocks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnWorkshifts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Button btnRequests;
    }
}