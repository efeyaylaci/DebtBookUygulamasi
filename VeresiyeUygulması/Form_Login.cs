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
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();
        }

        SqlDataReader usernameChecker;
        SqlCommand command;
        string sql;

        public void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
             
            sql = "SELECT id,kullanıcıAdı,şifre FROM Logins ";
            command = new SqlCommand(sql, connection);
            usernameChecker = command.ExecuteReader();
            var usernameList = new List<string>();
            int i = 0;
            bool validUsername = false;            

            usernameChecker.Close();
            usernameChecker = command.ExecuteReader();

            while(usernameChecker.Read()){

                i = i + 1;

                if (textBox2.Text == usernameChecker.GetValue(1).ToString())
                {
                    Storage.Instance.loginID = i;
                }

                if (usernameChecker.GetString(2) == textBox1.Text && usernameChecker.GetInt32(0) == Storage.Instance.loginID)
                {                   
                    validUsername = true;         
                }
            }
            
            if (validUsername )
            {
                Form_DataGridView mainform = new Form_DataGridView();
                this.Visible = false;
                mainform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You entered wrong username or password. \nPlease Try Again.");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            usernameChecker.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Register form_register = new Form_Register();
            form_register.ShowDialog();
        }

        //        public int GetIDToForm1(out int myvar)
        //        {
        //            myvar = 0;

        //            string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
        //            SqlConnection connection = new SqlConnection(connectionString);
        //            connection.Open();

        //            sql = "select id,kullanıcıAdı,şifre from Logins ";
        //            command = new SqlCommand(sql, connection);

        //            usernameChecker = command.ExecuteReader();

        //            while (usernameChecker.Read())
        //            {
        //                i = i + 1;

        //                MessageBox.Show(textBox2.Text);

        //                if (textBox2.Text == usernameChecker.GetValue(1).ToString())
        //                {
        //                    usernameRow = i;
        //                    //loginInfo.loginID = i;
        //                }
        //            }
        //            myvar = 0;

        //        }
    }
}

