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
    public partial class Form_NewProduct : Form
    {
        public Form_NewProduct()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //add button
        {
            string sql = "";
            string selectedItem;
            if (textBox2.Text == "")
            {
                if (listBox1.Items.Count > 0)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        selectedItem = listBox1.Items[i].ToString();
                        sql = "INSERT INTO Measurement (ürün_id, ölçümBirimi) VALUES ((SELECT IDENT_CURRENT('Products')), '" + selectedItem + "'); \n" + sql;

                        //if (listBox1.Items[i].selected)
                        //{
                        //    if (selectedItem == "")
                        //    {
                        //        selectedItem = listBox1.Items[i].Value;
                        //    }
                        //}
                    }

                    sql = " INSERT INTO Products (ürünAdı, kullanıcı_id) VALUES ('" + textBox1.Text + "', " + Storage.Instance.loginID + "); \n" + sql;

                    //string sql = " INSERT INTO Products (kullanıcıAdı, şifre) VALUES('" + usernameBox1.Text + "', '" + passwordBox2.Text + "')";
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Please write at least one measurement unit!");
                }
            }
            else
            {
                MessageBox.Show("Please write the name of Product!");
            }

            if (sql != "")
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e) // add to list
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }
    }
}
//var sql = "SELECT measurement_id, ölçüm_birimi, ölçüm_birimi_kategorisi FROM Measurement JOIN Products ON measurement_id = ürün_id WHERE kullanıcı_id = " + Storage.Instance.loginID + " AND "measurement_id IN (SELECT ürün_id FROM Products WHERE )";


//comboBox1.DataSource = ds.Tables[0];
//comboBox1.ValueMember = "measurement_id";
//comboBox1.DisplayMember = "ölçüm_birimi_kategorisi";