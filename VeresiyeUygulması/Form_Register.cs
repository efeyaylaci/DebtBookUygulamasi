using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VeresiyeUygulması
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        SqlDataReader userChecker;
        SqlConnection connection;
        SqlCommand command;
        bool invalidUsername;

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT id, kullanıcıAdı, şifre FROM logins";
            command = new SqlCommand(sql, connection);
            userChecker = command.ExecuteReader();

            while (userChecker.Read())
            {
                if(usernameBox1.Text == userChecker.GetValue(1).ToString())
                {
                    invalidUsername = true;
                }
            }

            userChecker.Close();

            if (invalidUsername)
            {
                MessageBox.Show("This username is already taken! Please choose another one.");
            }
            else if (passwordBox2.Text.Length < 8)
            {
                MessageBox.Show("Your password must be at least 8 character long.");
            }
            else if (passwordBox2 == passwordRepeatBox1)
            {
                MessageBox.Show("Please write your password correctly in both box.");
            }
            else
            {
                sql = " INSERT INTO Logins (kullanıcıAdı, şifre) VALUES('" + usernameBox1.Text + "', '" + passwordBox2.Text + "')";

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("User created successfully! You can login now.");
                this.Close();
            }
        }
    }
}
