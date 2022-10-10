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
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();
        }

        string i;
        SqlConnection connection;
        SqlDataAdapter adapter;
        bool closeThis; 

        private void Form_Edit_Load(object sender, EventArgs e)
        {

            //comboBox1.SelectedValue = Storage.Instance.birimTipi;
            unitAmountBox2.Text = Storage.Instance.miktar;
            dealerBox1.Text = Storage.Instance.alakalı;
            descriptionBox4.Text = Storage.Instance.açıklama;
            //comboBox2.SelectedValue = Storage.Instance.miktarÇeşidi;

            if (Storage.Instance.birimTipi == "Income")
            {
                checkIncomeBox1.Checked = true;
            }
            else
            {
                checkExpenseBox2.Checked = true;
            }

            var sql = "SELECT ürün_id, ürünAdı, kullanıcı_id FROM Products WHERE kullanıcı_id = " + Storage.Instance.loginID;
            connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "ürün_id";
            comboBox1.DisplayMember = "ürünAdı";
            comboBox1.SelectedIndex = comboBox1.FindStringExact(Storage.Instance.birimTipi);

            sql = "SELECT ürün_id, ölçümBirimi FROM Measurement WHERE ürün_id = " + comboBox1.SelectedValue;
            connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");
            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);

            var ds2 = new DataSet();
            adapter.Fill(ds2);

            comboBox2.ValueMember = "ürün_id";
            comboBox2.DisplayMember = "ölçümBirimi";
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.SelectedIndex = comboBox2.FindStringExact(Storage.Instance.miktarÇeşidi);

            //comboBox2.SelectedValue = ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            DialogResult dialogResult = MessageBox.Show("Are you sure to update the debt of '" + Storage.Instance.alakalı + "'", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();

                if ((checkIncomeBox1.Checked || checkExpenseBox2.Checked) && unitAmountBox2.Text != "" && comboBox1.Text != "" && dealerBox1.Text != "")
                {
                    if (checkIncomeBox1.Checked) { i = "Income"; } else { i = "Expense"; };
                    string sql = "UPDATE MainDataset SET açıklama='" + descriptionBox4.Text + "', miktar=" + unitAmountBox2.Text + ", işlemTürü ='" + i + "', birimTipi ='" + comboBox1.Text + "', alakalı ='" + dealerBox1.Text + "' " +
                        "WHERE Id=" + Storage.Instance.Id + ";";

                    adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sql, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please fill the areas correctly.");
                }


                closeThis = true;
            }

            if (closeThis) { this.Close(); }
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
                }

            }
        }
    }
}
