﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IntroProjectWaterfall0._1
{
    class Department
    {
		#region variables + properties

		private string departmentId;
		private string name;
		private string address;
		List<Employee> employees;
		public List<Employee> Employees
		{
			get { return this.employees; }
		}
		public string Address
		{
			get { return address; }
			set {
                using (MySqlConnection conn = new MySqlConnection(SqlConnectionHandler.ServerConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"UPDATE department SET address = @address WHERE departmentID=@departmentId", conn))
                    {
                        cmd.Parameters.AddWithValue("@address", value);
                        cmd.Parameters.AddWithValue("@departmentId", this.DepartmentId);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    conn.Close();
                    address = value;
                }
            }
		}

		public string Name
		{
			get { return name; }
			set
            {
                using (MySqlConnection conn = new MySqlConnection(SqlConnectionHandler.ServerConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"UPDATE department SET name = @name WHERE departmentID=@departmentId", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", value);
                        cmd.Parameters.AddWithValue("@departmentId", this.DepartmentId);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    conn.Close();
                    name = value;
                }
            }
		}

		public string DepartmentId
		{
			get { return departmentId; }
			set { departmentId = value; }
		}

        #endregion
        #region Constructors

        public Department(string name, string address)
        {
            this.name = name;
            this.address = address;
            employees = new List<Employee>();

            using (MySqlConnection con = new MySqlConnection(SqlConnectionHandler.ServerConnection))
            {
                con.Open();
                MySqlCommand cmd;
                MySqlDataReader dataReader;

                cmd = new MySqlCommand($"SELECT name FROM department WHERE name=@name", con);
                cmd.Parameters.AddWithValue("@name", name);
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    cmd.Dispose();
                    dataReader.Close();
                    throw new NameTakenException("Department name taken!");
                }
                else
                {
                    cmd.Dispose();
                    dataReader.Close();
                    do
                    {
                        this.DepartmentId = GenerateDepartmentID();
                        cmd = new MySqlCommand($"SELECT departmentID FROM department WHERE departmentID=@departmentID", con);
                        cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                        dataReader = cmd.ExecuteReader();
                    }
                    while (dataReader.Read());
                    cmd.Dispose();
                    dataReader.Close();
                    //Making sure that the ID is unique

                    using (cmd = new MySqlCommand($"INSERT INTO department (departmentID, name, address) VALUES (@departmentID, @name, @address)", con))
                    {
                        cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                        cmd.Parameters.AddWithValue("@name", this.Name);
                        cmd.Parameters.AddWithValue("@address", this.Address);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                }
                con.Close();
            }
        }
        public Department(string departmentId)
        {
            this.DepartmentId = departmentId;
            using (MySqlConnection con = new MySqlConnection(SqlConnectionHandler.ServerConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand($"SELECT name, address FROM department WHERE departmentID=@departmentID", con))
                {
                    cmd.Parameters.AddWithValue("@departmentID", DepartmentId);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        this.name = dataReader.GetString(0);
                        this.address = dataReader.GetString(1);
                    }
                    cmd.Dispose();
                    dataReader.Close();
                }
                //Get all other properties from department table
                
                using (MySqlCommand cmd = new MySqlCommand($"SELECT userID FROM users WHERE departmentID=@departmentID", con))
                {
                    cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    this.employees = new List<Employee>();

                    while (dataReader.Read())
                    {
                        //employees.Add(new Employee(dataReader.GetString(0)));
                    }
                    cmd.Dispose();
                    dataReader.Close();
                }   
                con.Close();
            }
        }
        public Department(string employeeId, bool withEmployeeId)
        {
            withEmployeeId = true;

            using (MySqlConnection con = new MySqlConnection(SqlConnectionHandler.ServerConnection))
            {
                con.Open();
                MySqlCommand cmd;
                MySqlDataReader dataReader;

                cmd = new MySqlCommand($"SELECT departmentID FROM users WHERE userID=@userID", con);
                cmd.Parameters.AddWithValue("@userID", employeeId);
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    this.DepartmentId = dataReader.GetString(0);
                }
                cmd.Dispose();
                dataReader.Close();
                //Get department id from the user

                using (cmd = new MySqlCommand($"SELECT name, address FROM department WHERE departmentID=@departmentID", con))
                {
                    cmd.Parameters.AddWithValue("@departmentID", DepartmentId);
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        this.name = dataReader.GetString(0);
                        this.address = dataReader.GetString(1);
                    }
                }
                //Get all other properties from department table
                cmd.Dispose();
                dataReader.Close();

                cmd = new MySqlCommand($"SELECT userID FROM users WHERE departmentID=@departmentID", con);
                cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                dataReader = cmd.ExecuteReader();
                this.employees = new List<Employee>();

                while (dataReader.Read())
                {
                    employees.Add(new Employee(dataReader.GetString(0)));
                }
                cmd.Dispose();
                dataReader.Close();
                con.Close();
            }
        }

        #endregion
        #region Methods

        private string GenerateDepartmentID()
        {
            Guid key = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(key.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            GuidString = GuidString.Replace("/", "");

            return GuidString;
        }

        public override string ToString()
        {
            return $"Department {this.Name} on {this.Address} - {this.employees.Count} Workers.";
        }

        public void RemoveEmployee(string userID)
        {
            bool atleastOneWorking = (employees.Count > 1) ? true : false;

            if (atleastOneWorking)
            {
                foreach (Employee e in employees)
                    if (e.UserID == userID)
                    {
                        e.RemoveFromDatabase();
                        employees.Remove(e);
                        break;
                    }
            } else {
                throw new MinimalEmployeesException("You must always have one employee in a department!"); }
        }

        public void RemoveFromDatabase()
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionHandler.ServerConnection))
            {
                con.Open();
                foreach (Employee e in employees) { e.RemoveFromDatabase(); }    
                //First we clear the employees in the department that were not previously moved, then we delete the actual deaprtment
                using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM department WHERE departmentID=@departmentID", con))
                {
                    cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();
            }
        }
        
        public static List<Department> GetAllDepartments()
        {
            List<Department> allDepartments = new List<Department>();
            using (MySqlConnection con = new MySqlConnection(SqlConnectionHandler.ServerConnection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand($"SELECT departmentID FROM department", con))
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        allDepartments.Add(new Department(dataReader.GetString(0)));
                    }
                    cmd.Dispose();
                    dataReader.Close();
                }
                con.Close();
            }
            return allDepartments;
        }

        public static void AssignEmployeeTo (string userID, string newDepartmentId)
        {
            foreach (Employee e in Employee.GetAllEmployees())
                if (e.UserID == userID)
                    e.DepartmentID = newDepartmentId;
        }
    }
    #endregion
}
