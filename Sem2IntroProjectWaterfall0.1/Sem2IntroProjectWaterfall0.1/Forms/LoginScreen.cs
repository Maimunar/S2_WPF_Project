﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sem2IntroProjectWaterfall0._1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Assigns ENTER key press to trigger btnLogin method
            this.AcceptButton = btnLogin;

            if (!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                MySqlConnection conn = SqlConnectionHandler.GetSqlConnection();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT userID, username, password, role FROM users WHERE username=@username AND password=@password", conn))
                    {
                        cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                        cmd.Parameters.AddWithValue("@password", HashManager.GetSha256(tbPassword.Text));
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        if (dataReader.Read())
                        {
                            LoggedInUser.userID = dataReader.GetString(0);
                            LoggedInUser.role = (Role)dataReader.GetInt16(3);
                            //Opening dashboard on successful login
                            Dashboard newScreen = new Dashboard();
                            newScreen.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Failed login attempt. Please try again."); 
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), $"SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            else MessageBox.Show("Please fill all required fields before attempting to log in!");
        }
    }
}
