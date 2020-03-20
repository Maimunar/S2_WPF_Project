﻿namespace Sem2IntroProjectWaterfall0._1
{
    partial class EmployeeManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnClearPersonalInfo = new System.Windows.Forms.Button();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbPersonalInfoList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAssignUser = new System.Windows.Forms.GroupBox();
            this.btnMoveEmployee = new System.Windows.Forms.Button();
            this.cbDepartmentList = new System.Windows.Forms.ComboBox();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHouseUnit2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRemoveList = new System.Windows.Forms.ComboBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.tbHourlySalary = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblHourlySalary = new System.Windows.Forms.Label();
            this.lblHouseUnit = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDepartmentEditAddress = new System.Windows.Forms.TextBox();
            this.tbDepartmentEditName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDepartmentEdit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDepartmentRemove = new System.Windows.Forms.Button();
            this.cbDepartmentRemove = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDepartmentAssign = new System.Windows.Forms.ComboBox();
            this.cbEmployeeAssign = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateNewDepartment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepartmentCreateAddress = new System.Windows.Forms.TextBox();
            this.tbDepartmentCreateName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.gbAssignUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(58, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 424);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbPersonalInfo);
            this.tabPage1.Controls.Add(this.gbAssignUser);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(698, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.btnClearPersonalInfo);
            this.gbPersonalInfo.Controls.Add(this.lblBirthday);
            this.gbPersonalInfo.Controls.Add(this.dtpBirthday);
            this.gbPersonalInfo.Controls.Add(this.btnUpdateEmployee);
            this.gbPersonalInfo.Controls.Add(this.tbEmail);
            this.gbPersonalInfo.Controls.Add(this.lblEmail);
            this.gbPersonalInfo.Controls.Add(this.tbAddress);
            this.gbPersonalInfo.Controls.Add(this.lblAddress);
            this.gbPersonalInfo.Controls.Add(this.lblPhoneNumber);
            this.gbPersonalInfo.Controls.Add(this.tbPhoneNumber);
            this.gbPersonalInfo.Controls.Add(this.tbNationality);
            this.gbPersonalInfo.Controls.Add(this.lblNationality);
            this.gbPersonalInfo.Controls.Add(this.tbLastName);
            this.gbPersonalInfo.Controls.Add(this.lblLastName);
            this.gbPersonalInfo.Controls.Add(this.tbFirstName);
            this.gbPersonalInfo.Controls.Add(this.lblFirstName);
            this.gbPersonalInfo.Controls.Add(this.cbPersonalInfoList);
            this.gbPersonalInfo.Controls.Add(this.label3);
            this.gbPersonalInfo.Location = new System.Drawing.Point(331, 78);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPersonalInfo.Size = new System.Drawing.Size(361, 317);
            this.gbPersonalInfo.TabIndex = 25;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Set/Change Personal Information";
            // 
            // btnClearPersonalInfo
            // 
            this.btnClearPersonalInfo.Location = new System.Drawing.Point(312, 30);
            this.btnClearPersonalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearPersonalInfo.Name = "btnClearPersonalInfo";
            this.btnClearPersonalInfo.Size = new System.Drawing.Size(43, 20);
            this.btnClearPersonalInfo.TabIndex = 45;
            this.btnClearPersonalInfo.Text = "Clear";
            this.btnClearPersonalInfo.UseVisualStyleBackColor = true;
            this.btnClearPersonalInfo.Click += new System.EventHandler(this.btnClearPersonalInfo_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(54, 263);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(57, 13);
            this.lblBirthday.TabIndex = 44;
            this.lblBirthday.Text = "Birth Date:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(111, 259);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(198, 20);
            this.dtpBirthday.TabIndex = 43;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(57, 292);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(250, 20);
            this.btnUpdateEmployee.TabIndex = 29;
            this.btnUpdateEmployee.Text = "Update employee info";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(57, 228);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(252, 20);
            this.tbEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 212);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "E-mail";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(57, 185);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(252, 20);
            this.tbAddress.TabIndex = 40;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(55, 169);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(196, 120);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 38;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(197, 136);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.tbPhoneNumber.TabIndex = 37;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(57, 136);
            this.tbNationality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(111, 20);
            this.tbNationality.TabIndex = 36;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(55, 120);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 35;
            this.lblNationality.Text = "Nationality";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(197, 86);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(111, 20);
            this.tbLastName.TabIndex = 34;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(195, 70);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(57, 88);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(111, 20);
            this.tbFirstName.TabIndex = 32;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(55, 72);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 31;
            this.lblFirstName.Text = "First Name";
            // 
            // cbPersonalInfoList
            // 
            this.cbPersonalInfoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonalInfoList.FormattingEnabled = true;
            this.cbPersonalInfoList.Location = new System.Drawing.Point(115, 30);
            this.cbPersonalInfoList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPersonalInfoList.Name = "cbPersonalInfoList";
            this.cbPersonalInfoList.Size = new System.Drawing.Size(194, 21);
            this.cbPersonalInfoList.TabIndex = 30;
            this.cbPersonalInfoList.DropDown += new System.EventHandler(this.cbPersonalInfoList_DropDown);
            this.cbPersonalInfoList.SelectedIndexChanged += new System.EventHandler(this.cbPersonalInfoList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Employee:";
            // 
            // gbAssignUser
            // 
            this.gbAssignUser.Controls.Add(this.btnMoveEmployee);
            this.gbAssignUser.Controls.Add(this.cbDepartmentList);
            this.gbAssignUser.Controls.Add(this.cbEmployeeList);
            this.gbAssignUser.Controls.Add(this.lblUser);
            this.gbAssignUser.Controls.Add(this.lblHouseUnit2);
            this.gbAssignUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAssignUser.Location = new System.Drawing.Point(18, 244);
            this.gbAssignUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAssignUser.Name = "gbAssignUser";
            this.gbAssignUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAssignUser.Size = new System.Drawing.Size(307, 152);
            this.gbAssignUser.TabIndex = 24;
            this.gbAssignUser.TabStop = false;
            this.gbAssignUser.Text = "Move employee to different department";
            // 
            // btnMoveEmployee
            // 
            this.btnMoveEmployee.Location = new System.Drawing.Point(115, 107);
            this.btnMoveEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveEmployee.Name = "btnMoveEmployee";
            this.btnMoveEmployee.Size = new System.Drawing.Size(175, 28);
            this.btnMoveEmployee.TabIndex = 26;
            this.btnMoveEmployee.Text = "Move employee";
            this.btnMoveEmployee.UseVisualStyleBackColor = true;
            this.btnMoveEmployee.Click += new System.EventHandler(this.btnMoveEmployee_Click);
            // 
            // cbDepartmentList
            // 
            this.cbDepartmentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmentList.FormattingEnabled = true;
            this.cbDepartmentList.Location = new System.Drawing.Point(115, 76);
            this.cbDepartmentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartmentList.Name = "cbDepartmentList";
            this.cbDepartmentList.Size = new System.Drawing.Size(176, 21);
            this.cbDepartmentList.TabIndex = 20;
            this.cbDepartmentList.DropDown += new System.EventHandler(this.cbDepartmentList_DropDown);
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(115, 38);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(176, 21);
            this.cbEmployeeList.TabIndex = 19;
            this.cbEmployeeList.DropDown += new System.EventHandler(this.cbEmployeeList_DropDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(11, 41);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 13);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "Employee: ";
            // 
            // lblHouseUnit2
            // 
            this.lblHouseUnit2.AutoSize = true;
            this.lblHouseUnit2.Location = new System.Drawing.Point(11, 81);
            this.lblHouseUnit2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseUnit2.Name = "lblHouseUnit2";
            this.lblHouseUnit2.Size = new System.Drawing.Size(65, 13);
            this.lblHouseUnit2.TabIndex = 17;
            this.lblHouseUnit2.Text = "Department:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRemoveList);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(331, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 53);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove employee from system";
            // 
            // cbRemoveList
            // 
            this.cbRemoveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoveList.FormattingEnabled = true;
            this.cbRemoveList.Location = new System.Drawing.Point(73, 20);
            this.cbRemoveList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRemoveList.Name = "cbRemoveList";
            this.cbRemoveList.Size = new System.Drawing.Size(176, 21);
            this.cbRemoveList.TabIndex = 28;
            this.cbRemoveList.DropDown += new System.EventHandler(this.cbRemoveList_DropDown);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(252, 20);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(104, 20);
            this.btnRemoveEmployee.TabIndex = 27;
            this.btnRemoveEmployee.Text = "Remove employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Employee:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddEmployee);
            this.groupBox2.Controls.Add(this.cbDepartments);
            this.groupBox2.Controls.Add(this.tbHourlySalary);
            this.groupBox2.Controls.Add(this.cbRole);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.tbUsername);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.lblRole);
            this.groupBox2.Controls.Add(this.lblHourlySalary);
            this.groupBox2.Controls.Add(this.lblHouseUnit);
            this.groupBox2.Location = new System.Drawing.Point(18, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 223);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a new employee";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(110, 180);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(157, 28);
            this.btnAddEmployee.TabIndex = 25;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(110, 140);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(158, 21);
            this.cbDepartments.TabIndex = 24;
            this.cbDepartments.DropDown += new System.EventHandler(this.cbDepartments_DropDown);
            // 
            // tbHourlySalary
            // 
            this.tbHourlySalary.Location = new System.Drawing.Point(110, 112);
            this.tbHourlySalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHourlySalary.Name = "tbHourlySalary";
            this.tbHourlySalary.Size = new System.Drawing.Size(80, 20);
            this.tbHourlySalary.TabIndex = 23;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(110, 81);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(158, 21);
            this.cbRole.TabIndex = 22;
            this.cbRole.DropDown += new System.EventHandler(this.cbRole_DropDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(110, 52);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(158, 20);
            this.tbPassword.TabIndex = 21;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(110, 24);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(158, 20);
            this.tbUsername.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 27);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 54);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(13, 84);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role:";
            // 
            // lblHourlySalary
            // 
            this.lblHourlySalary.AutoSize = true;
            this.lblHourlySalary.Location = new System.Drawing.Point(13, 115);
            this.lblHourlySalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHourlySalary.Name = "lblHourlySalary";
            this.lblHourlySalary.Size = new System.Drawing.Size(72, 13);
            this.lblHourlySalary.TabIndex = 6;
            this.lblHourlySalary.Text = "Hourly Salary:";
            // 
            // lblHouseUnit
            // 
            this.lblHouseUnit.AutoSize = true;
            this.lblHouseUnit.Location = new System.Drawing.Point(13, 142);
            this.lblHouseUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseUnit.Name = "lblHouseUnit";
            this.lblHouseUnit.Size = new System.Drawing.Size(65, 13);
            this.lblHouseUnit.TabIndex = 8;
            this.lblHouseUnit.Text = "Department:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbDepartmentEditAddress);
            this.tabPage2.Controls.Add(this.tbDepartmentEditName);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cbDepartmentEdit);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnDepartmentRemove);
            this.tabPage2.Controls.Add(this.cbDepartmentRemove);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnAssignEmployee);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbDepartmentAssign);
            this.tabPage2.Controls.Add(this.cbEmployeeAssign);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnCreateNewDepartment);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbDepartmentCreateAddress);
            this.tabPage2.Controls.Add(this.tbDepartmentCreateName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(698, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(184, 198);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 19);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Confirm";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Name";
            // 
            // tbDepartmentEditAddress
            // 
            this.tbDepartmentEditAddress.Location = new System.Drawing.Point(184, 128);
            this.tbDepartmentEditAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDepartmentEditAddress.Multiline = true;
            this.tbDepartmentEditAddress.Name = "tbDepartmentEditAddress";
            this.tbDepartmentEditAddress.Size = new System.Drawing.Size(128, 50);
            this.tbDepartmentEditAddress.TabIndex = 19;
            // 
            // tbDepartmentEditName
            // 
            this.tbDepartmentEditName.Location = new System.Drawing.Point(184, 91);
            this.tbDepartmentEditName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDepartmentEditName.Name = "tbDepartmentEditName";
            this.tbDepartmentEditName.Size = new System.Drawing.Size(128, 20);
            this.tbDepartmentEditName.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Edit Department";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Department";
            // 
            // cbDepartmentEdit
            // 
            this.cbDepartmentEdit.FormattingEnabled = true;
            this.cbDepartmentEdit.Location = new System.Drawing.Point(184, 54);
            this.cbDepartmentEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartmentEdit.Name = "cbDepartmentEdit";
            this.cbDepartmentEdit.Size = new System.Drawing.Size(128, 21);
            this.cbDepartmentEdit.TabIndex = 15;
            this.cbDepartmentEdit.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentEdit_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Remove Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Department";
            // 
            // btnDepartmentRemove
            // 
            this.btnDepartmentRemove.Location = new System.Drawing.Point(192, 311);
            this.btnDepartmentRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDepartmentRemove.Name = "btnDepartmentRemove";
            this.btnDepartmentRemove.Size = new System.Drawing.Size(127, 19);
            this.btnDepartmentRemove.TabIndex = 12;
            this.btnDepartmentRemove.Text = "Remove";
            this.btnDepartmentRemove.UseVisualStyleBackColor = true;
            this.btnDepartmentRemove.Click += new System.EventHandler(this.btnDepartmentRemove_Click);
            // 
            // cbDepartmentRemove
            // 
            this.cbDepartmentRemove.FormattingEnabled = true;
            this.cbDepartmentRemove.Location = new System.Drawing.Point(170, 286);
            this.cbDepartmentRemove.Name = "cbDepartmentRemove";
            this.cbDepartmentRemove.Size = new System.Drawing.Size(169, 21);
            this.cbDepartmentRemove.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Employee";
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Location = new System.Drawing.Point(13, 336);
            this.btnAssignEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(127, 19);
            this.btnAssignEmployee.TabIndex = 8;
            this.btnAssignEmployee.Text = "Assign";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 74);
            this.label7.TabIndex = 7;
            this.label7.Text = "Assign an employee to another department";
            // 
            // cbDepartmentAssign
            // 
            this.cbDepartmentAssign.FormattingEnabled = true;
            this.cbDepartmentAssign.Location = new System.Drawing.Point(13, 311);
            this.cbDepartmentAssign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartmentAssign.Name = "cbDepartmentAssign";
            this.cbDepartmentAssign.Size = new System.Drawing.Size(128, 21);
            this.cbDepartmentAssign.TabIndex = 6;
            // 
            // cbEmployeeAssign
            // 
            this.cbEmployeeAssign.FormattingEnabled = true;
            this.cbEmployeeAssign.Location = new System.Drawing.Point(14, 254);
            this.cbEmployeeAssign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployeeAssign.Name = "cbEmployeeAssign";
            this.cbEmployeeAssign.Size = new System.Drawing.Size(128, 21);
            this.cbEmployeeAssign.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // btnCreateNewDepartment
            // 
            this.btnCreateNewDepartment.Location = new System.Drawing.Point(11, 154);
            this.btnCreateNewDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateNewDepartment.Name = "btnCreateNewDepartment";
            this.btnCreateNewDepartment.Size = new System.Drawing.Size(127, 19);
            this.btnCreateNewDepartment.TabIndex = 4;
            this.btnCreateNewDepartment.Text = "Create";
            this.btnCreateNewDepartment.UseVisualStyleBackColor = true;
            this.btnCreateNewDepartment.Click += new System.EventHandler(this.btnCreateNewDepartment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create New Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // tbDepartmentCreateAddress
            // 
            this.tbDepartmentCreateAddress.Location = new System.Drawing.Point(11, 91);
            this.tbDepartmentCreateAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDepartmentCreateAddress.Multiline = true;
            this.tbDepartmentCreateAddress.Name = "tbDepartmentCreateAddress";
            this.tbDepartmentCreateAddress.Size = new System.Drawing.Size(128, 50);
            this.tbDepartmentCreateAddress.TabIndex = 1;
            // 
            // tbDepartmentCreateName
            // 
            this.tbDepartmentCreateName.Location = new System.Drawing.Point(3, 54);
            this.tbDepartmentCreateName.Name = "tbDepartmentCreateName";
            this.tbDepartmentCreateName.Size = new System.Drawing.Size(169, 20);
            this.tbDepartmentCreateName.TabIndex = 0;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.gbAssignUser.ResumeLayout(false);
            this.gbAssignUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbAssignUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHouseUnit2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblHourlySalary;
        private System.Windows.Forms.Label lblHouseUnit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateNewDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepartmentCreateAddress;
        private System.Windows.Forms.TextBox tbDepartmentCreateName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAssignEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDepartmentAssign;
        private System.Windows.Forms.ComboBox cbEmployeeAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDepartmentEditAddress;
        private System.Windows.Forms.TextBox tbDepartmentEditName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbDepartmentEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDepartmentRemove;
        private System.Windows.Forms.ComboBox cbDepartmentRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbHourlySalary;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cbDepartmentList;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.Button btnMoveEmployee;
        private System.Windows.Forms.ComboBox cbRemoveList;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbPersonalInfoList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnClearPersonalInfo;
    }
}