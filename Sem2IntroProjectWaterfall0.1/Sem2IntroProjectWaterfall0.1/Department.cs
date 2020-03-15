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
                MySqlConnection conn = SqlConnectionHandler.GetSqlConnection();
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

		public string Name
		{
			get { return name; }
			set
            {
                MySqlConnection conn = SqlConnectionHandler.GetSqlConnection();
                using (MySqlCommand cmd = new MySqlCommand($"UPDATE department SET name = @name WHERE departmentID=@departmentId", conn))
                {
                    cmd.Parameters.AddWithValue("@name", value);
                    cmd.Parameters.AddWithValue("@departmentId", this.DepartmentId);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
                name = value; }
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
            this.Name = name;
            this.Address = address;
            employees = new List<Employee>();

            MySqlConnection con = SqlConnectionHandler.GetSqlConnection();
            MySqlCommand cmd;
            MySqlDataReader dataReader;

            cmd = new MySqlCommand($"SELECT name FROM department WHERE name=@name", con);
            cmd.Parameters.AddWithValue("@name", name);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                cmd.Dispose();
                dataReader.Close();
                throw new Exception("Department name taken!");
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
                con.Close();
            }
        }

        public Department(string employeeId)
        {
            MySqlConnection con = SqlConnectionHandler.GetSqlConnection();
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
                    this.Name = dataReader.GetString(0);
                    this.Address = dataReader.GetString(1);
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
            } else { throw new Exception("You must always have one employee in a department!"); }
        }

        public void RemoveFromDatabase()
        {
            MySqlConnection con = SqlConnectionHandler.GetSqlConnection();
            foreach (Employee e in employees)
                e.RemoveFromDatabase();
            //First we clear the employees in the department that were not previously moved, then we delete the actual deaprtment
            using (MySqlCommand cmd = new MySqlCommand($"DELETE department WHERE departmentID=@departmentID", con))
            {
                cmd.Parameters.AddWithValue("@departmentID", this.DepartmentId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }
    }
    #endregion
}
