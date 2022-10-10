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
    public partial class Form_AddButton : Form
    {
        public Form_AddButton()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        SqlConnection connection;


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            if ((checkIncomeBox1.Checked || checkExpenseBox2.Checked) && unitAmountBox2.Text != "" && comboBox1.Text != "" && dealerBox1.Text != "")
            {
                string i;
                if (checkIncomeBox1.Checked) { i = "Income"; } else { i = "Expense"; } ;                
                string sql = "INSERT INTO MainDataset (kullanıcı_id, açıklama, miktar, işlemTürü, birimTipi, alakalı, miktarÇeşidi)" +
                    "VALUES(" + Storage.Instance.loginID + ", N'" + descriptionBox4.Text + "', " + unitAmountBox2.Text + ", '" + i + "', N'" + comboBox1.Text + "', N'" + dealerBox1.Text + "', '" + comboBox2.Text + "')";

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please fill the areas correctly.");
            }
            this.Close();
        }

        private void checkIncomeBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkExpenseBox2.Checked = !checkIncomeBox1.Checked;
        }

        private void checkExpenseBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkIncomeBox1.Checked = !checkExpenseBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddButton_Load(object sender, EventArgs e)
        {
            var sql = "SELECT ürün_id, ürünAdı, kullanıcı_id FROM Products WHERE kullanıcı_id = " + Storage.Instance.loginID;
            connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.ValueMember = "ürün_id";
            comboBox1.DisplayMember = "ürünAdı";
            comboBox1.DataSource = ds.Tables[0];

            comboBox1.SelectedItem = null;

            //comboBox1.SelectedValue.ToString()
            //comboBox1.Text-> Gets or sets the text of the currently selected item.

            //DataRow dr;
            //dr = ds.NewRow();
            //dr.ItemArray = new object[2] { 0, "---Select an item---" };
            //bodyPos.Rows.InsertAt(dr, 0);
            //comboBox1.DataSource = bodyPos;
            //comboBox1.DisplayMember = bodyPos.Columns[1].ColumnName;
            //comboBox1.ValueMember = bodyPos.Columns[0].ColumnName;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedValue.ToString() != "")
            {
                {
                    var sql = "SELECT ürün_id, ölçümBirimi FROM Measurement WHERE ürün_id = " + comboBox1.SelectedValue;
                    connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    var ds2 = new DataSet();
                    adapter.Fill(ds2);

                    comboBox2.ValueMember = "ürün_id";
                    comboBox2.DisplayMember = "ölçümBirimi";
                    comboBox2.DataSource = ds2.Tables[0];
                    comboBox2.SelectedItem = null;
                    label8.Visible = false;

                }
            }
        }

        private void unitAmountBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label9.Visible = true;
            }
            else
            {
                e.Handled = false;
                label9.Visible = false;

            }
            //    else if ((Keys)e.KeyChar == Keys.Back)
            //    {
            //        e.Handled = true;
            //    }
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                label8.Visible = true;
            }
        }

    }
}