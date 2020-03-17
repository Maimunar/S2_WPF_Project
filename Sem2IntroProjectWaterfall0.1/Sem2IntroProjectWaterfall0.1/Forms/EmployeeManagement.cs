﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2IntroProjectWaterfall0._1
{
    public partial class EmployeeManagement : Form
    {
        private List<Department> departments;
        private List<Employee> employees;

        public EmployeeManagement()
        {
            InitializeComponent();
            RefreshComboboxes();
            employees = Employee.GetAllEmployees();
            departments = Department.GetAllDepartments();
        }

        private void UpdateDepartmentList() { departments = Department.GetAllDepartments(); }
        private void UpdateEmployeeList() { employees = Employee.GetAllEmployees(); }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard newScreen = new Dashboard();
            newScreen.Show();
            this.Close();
        }

        private void cbRole_DropDown(object sender, EventArgs e)
        {
            cbRole.Items.Clear();
            foreach(Role role in Enum.GetValues(typeof(Role))) { cbRole.Items.Add(role); }
        }

        private void cbDepartments_DropDown(object sender, EventArgs e)
        {
            cbDepartments.Items.Clear();
            UpdateDepartmentList();
            foreach (Department department in departments) { cbDepartments.Items.Add(department.Name); }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbHourlySalary.Text))
            {
                MessageBox.Show("Please fill all required fields and try again.");
            }
            else
            {
                decimal hourlySalary;
                if (Decimal.TryParse(tbHourlySalary.Text, out hourlySalary))
                {
                    if (cbDepartments.SelectedIndex == -1) { MessageBox.Show("Please select a department and try again."); return; }
                    if (cbRole.SelectedIndex == -1) { MessageBox.Show("Please select a role and try again."); return; }
                    try
                    {
                        Employee newEmployee = new Employee(tbUsername.Text, tbPassword.Text, hourlySalary, (Role) cbRole.SelectedIndex, departments[cbDepartments.SelectedIndex].DepartmentId);
                        MessageBox.Show("Sucessfully added new employee to the system!");
                        tbUsername.Clear();
                        tbPassword.Clear();
                        tbHourlySalary.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), $"Failed to create new employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Invalid hourly salary input. Please check for any mistakes and try again.");
            }
        }

        private void cbEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmployeeList.Items.Clear();
            UpdateEmployeeList();
            foreach(Employee employee in employees) { cbDepartmentList.Items.Add(employee.Username); }
        }

        private void cbDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDepartmentList.Items.Clear();
            UpdateDepartmentList();
            foreach (Department department in departments) { cbDepartmentList.Items.Add(department.Name); }
        }

        private void btnMoveEmployee_Click(object sender, EventArgs e)
        {
            if (cbEmployeeList.SelectedIndex != -1 && cbDepartmentList.SelectedIndex != -1)
            {
                try
                {
                    employees[cbEmployeeList.SelectedIndex].DepartmentID = departments[cbDepartmentList.SelectedIndex].DepartmentId;
                    MessageBox.Show($"Successfully moved user ({employees[cbDepartmentList.SelectedIndex].Username}) to department ({departments[cbDepartmentList.SelectedIndex].Name})");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"Failed to move employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Missing information in required fields. Please check for mistakes and try again.");
        {
            try
            {
                Department newDepartment = new Department(tbDepartmentCreateName.Text, tbDepartmentCreateAddress.Text);
            } catch (Exception exc) { MessageBox.Show(exc.Message); }
            }

        void RefreshComboboxes()
        {
            List<Employee> allEmployees = Employee.GetAllEmployees();
            List<Department> allDepartments = Department.GetAllDepartments();

            cbEmployeeAssign.Items.Clear();
            cbDepartmentAssign.Items.Clear();
            cbDepartmentEdit.Items.Clear();
            cbDepartmentRemove.Items.Clear();

            cbEmployeeAssign.DataSource = allEmployees;
            cbEmployeeAssign.DisplayMember = "MainDetails";
            cbDepartmentAssign.DataSource = allDepartments;
            cbDepartmentAssign.DisplayMember = "Name";
            cbDepartmentEdit.DataSource = allDepartments;
            cbDepartmentEdit.DisplayMember = "Name";
            cbDepartmentRemove.DataSource = allDepartments;
            cbDepartmentRemove.DisplayMember = "Name";
        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee selectedUser = (Employee)cbEmployeeAssign.SelectedItem;
                Department selectedDepartment = (Department)cbDepartmentAssign.SelectedItem;
                Department.AssignEmployeeTo(selectedUser.UserID, selectedDepartment.DepartmentId);
                RefreshComboboxes();
            }catch(Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDepartmentEditAddress.TextLength > 0 && tbDepartmentEditName.TextLength > 0)
                {
                    Department selectedDepartment = (Department)cbDepartmentEdit.SelectedItem;
                    selectedDepartment.Address = tbDepartmentEditAddress.Text;
                    selectedDepartment.Name = tbDepartmentEditName.Text;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnDepartmentRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Department selectedDepartment = (Department)cbDepartmentEdit.SelectedItem;
                selectedDepartment.RemoveFromDatabase();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        
        private void cmbAssignUserList_DropDown(object sender, EventArgs e)
        {

        }
    }
}
