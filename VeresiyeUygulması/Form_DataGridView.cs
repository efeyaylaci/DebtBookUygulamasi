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
    public partial class Form_DataGridView : Form
    {
        public Form_DataGridView()
        {
            InitializeComponent();
        }

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private bool filter;
        private int columnNumber;

        private void Form3_Load(object sender, EventArgs e)
        {
            Fill_dataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddButton form_AddButton = new Form_AddButton();
            form_AddButton.ShowDialog();

            Fill_dataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (filter)
            {
                columnNumber = e.ColumnIndex - 1;
            }
            else
            {
                columnNumber = e.ColumnIndex;
            }

            if (columnNumber == 8 && e.RowIndex != -1 && dataGridView1.CurrentRow.Cells["açıklama"].Value.ToString() != "") // açıklama
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["açıklama"].Value.ToString());
                }
            }

            if (columnNumber == 10 && e.RowIndex != -1) //delete
            {
                Storage.Instance.Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                Storage.Instance.açıklama = dataGridView1.CurrentRow.Cells["açıklama"].Value.ToString();
                Storage.Instance.miktar = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
                Storage.Instance.işlemTürü = dataGridView1.CurrentRow.Cells["işlemTürü"].Value.ToString();
                Storage.Instance.birimTipi = dataGridView1.CurrentRow.Cells["birimTipi"].Value.ToString();
                Storage.Instance.alakalı = dataGridView1.CurrentRow.Cells["alakalı"].Value.ToString();
                Storage.Instance.birimTipi = dataGridView1.CurrentRow.Cells["miktarÇeşidi"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure to delete the " + Storage.Instance.miktar + " " + Storage.Instance.birimTipi + " debt of '" + Storage.Instance.alakalı + "'", "Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True";
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    string sql = "DELETE FROM MainDataset WHERE Id=" + Storage.Instance.Id + ";";

                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = new SqlCommand(sql, connection);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    Fill_dataGridView();
                }
            }

            if (columnNumber == 9 && e.RowIndex != -1) // edit
            {
                Storage.Instance.Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                Storage.Instance.açıklama = dataGridView1.CurrentRow.Cells["açıklama"].Value.ToString();
                Storage.Instance.miktar = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
                Storage.Instance.işlemTürü = dataGridView1.CurrentRow.Cells["işlemTürü"].Value.ToString();
                Storage.Instance.birimTipi = dataGridView1.CurrentRow.Cells["birimTipi"].Value.ToString();
                Storage.Instance.alakalı = dataGridView1.CurrentRow.Cells["alakalı"].Value.ToString();
                Storage.Instance.miktarÇeşidi = dataGridView1.CurrentRow.Cells["miktarÇeşidi"].Value.ToString();

                Form_Edit form_edit = new Form_Edit();
                form_edit.ShowDialog();

                Fill_dataGridView();
            }


        }
        public void Fill_dataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Clear();

            var select = "SELECT Id, alakalı, birimTipi, miktar, miktarÇeşidi, işlemTürü, açıklama, eklenmeTarihi FROM MainDataset where kullanıcı_id = " + Storage.Instance.loginID;
            connection = new SqlConnection(@"Data Source=DESKTOP-BIMFCD4;Initial Catalog=DefterDataseti;Integrated Security=True");

            adapter = new SqlDataAdapter(select, connection);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;



            if (filter)
            {
                DataColumn dcRowString = ds.Tables[0].Columns.Add("_RowString", typeof(string));
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < ds.Tables[0].Columns.Count - 1; i++)
                    {
                        sb.Append(dataRow[i].ToString());
                        sb.Append("\t");
                    }
                    dataRow[dcRowString] = sb.ToString();
                }

                ds.Tables[0].DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns["_RowString"].Visible = false;

            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            dataGridView1.Columns.Add("descriptionIcon", "");
            dataGridView1.Columns.Add("editIcon", "");
            dataGridView1.Columns.Add("deleteIcon", "");

            dataGridView1.Columns["açıklama"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;


            //dataGridView1.Columns.Add("descriptionIcon", "");
            //dataGridView1.Columns.Add("editIcon", "");
            //dataGridView1.Columns.Add("deleteIcon", "");

            //DataGridViewColumn descriptionColumn = dataGridView1.Columns[7];
            //DataGridViewColumn thirdColumn = dataGridView.Columns[2];
            //descriptionColumn.ToolTipText =
            //  "This column uses a default cell.";
            //thirdColumn.ToolTipText =
            //    "This column uses a template cell." +
            //    " Style changes to one cell apply to all cells.";

            //dataGridView1.Columns[8].ToolTipText = "Click this button to see description for this row.";

            dataGridView1.Columns["editIcon"].DisplayIndex = 1;
            dataGridView1.Columns["deleteIcon"].DisplayIndex = 0;

            dataGridView1.Columns["editIcon"].Width = 13;
            dataGridView1.Columns["deleteIcon"].Width = 15;
            dataGridView1.Columns["descriptionIcon"].Width = 17;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["editIcon"] = new DataGridViewImageCell();
                dataGridView1.Rows[i].Cells["editIcon"].Value = (System.Drawing.Image)Properties.Resources.edit;

                dataGridView1.Rows[i].Cells["deleteIcon"] = new DataGridViewImageCell();
                dataGridView1.Rows[i].Cells["deleteIcon"].Value = (System.Drawing.Image)Properties.Resources.delete;

                dataGridView1.Rows[i].Cells["descriptionIcon"] = new DataGridViewImageCell();
                if (dataGridView1.Rows[i].Cells["açıklama"].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].Cells["descriptionIcon"].Value = (System.Drawing.Image)Properties.Resources.description16;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["descriptionIcon"].Value = (System.Drawing.Image)Properties.Resources.empty;
                }
            }

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_NewProduct form_Product = new Form_NewProduct();
            form_Product.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to exit to login screen", "Logout", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Visible = false;
                Form_Login form_Login = new Form_Login();
                form_Login.ShowDialog();
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["editIcon"] = new DataGridViewImageCell();
                dataGridView1.Rows[i].Cells["editIcon"].Value = (System.Drawing.Image)Properties.Resources.edit;

                dataGridView1.Rows[i].Cells["deleteIcon"] = new DataGridViewImageCell();
                dataGridView1.Rows[i].Cells["deleteIcon"].Value = (System.Drawing.Image)Properties.Resources.delete;

                dataGridView1.Rows[i].Cells["descriptionIcon"] = new DataGridViewImageCell();
                if (dataGridView1.Rows[i].Cells["açıklama"].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].Cells["descriptionIcon"].Value = (System.Drawing.Image)Properties.Resources.description16;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["descriptionIcon"].Value = (System.Drawing.Image)Properties.Resources.empty;
                }
            }
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {

            if (filter)
            {
                columnNumber = e.ColumnIndex -1;
            }
            else
            {
                columnNumber = e.ColumnIndex;
            }

            if (columnNumber == 8 && e.RowIndex != -1 && dataGridView1.Rows[e.RowIndex].Cells["açıklama"].Value.ToString() != "")
            {
                e.ToolTipText = "Description Button For This Row";
            }

            if (columnNumber == 8 && e.RowIndex != -1 && dataGridView1.Rows[e.RowIndex].Cells["açıklama"].Value.ToString() == "")
            {
                e.ToolTipText = "There is no description for this row.";
            }

            if (columnNumber == 10 && e.RowIndex != -1)
            {
                e.ToolTipText = "Delete Button";
            }

            if (columnNumber == 9 && e.RowIndex != -1)
            {
                e.ToolTipText = "Edit Button";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                filter = false;
            }
            else
            {
                filter = true;
            }

            Fill_dataGridView();

            //DataColumn dcRowString = dataGridView1.Columns.Add("_RowString", "");
            //foreach (DataRow dataRow in dataGridView1.Rows)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            //    {
            //        sb.Append(dataRow[i].ToString());
            //        sb.Append("\t");
            //    }
            //    dataRow[dcRowString] = sb.ToString();
            //}

            //dataGridView1.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);



            //StringBuilder filter = new StringBuilder();

            //foreach (var column in dataGridView1.Columns)
            //{
            //    if (filter.ToString() == "")
            //    {
            //        filter.Append(column.Name + " like '" + textBox1.Text + "'");
            //    }
            //    else
            //    {
            //        filter.Append(" OR ");
            //        filter.Append(column. + " like '" + textBox1.Text + "'");
            //    }
            

            //RowFilter = filter.ToString();
            
        }
    }
}
