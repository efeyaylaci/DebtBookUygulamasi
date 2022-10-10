using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeresiyeUygulması
{
    public partial class Form_Deneme : Form
    {
        public Form_Deneme()
        {
            InitializeComponent();
        }

        private void Form_Deneme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'defterDatasetiDataSet1.MainDataset' table. You can move, or remove it, as needed.
            this.mainDatasetTableAdapter.Fill(this.defterDatasetiDataSet1.MainDataset);
            // TODO: This line of code loads data into the 'defterDatasetiDataSet.MainDataset' table. You can move, or remove it, as needed.

        }
    }
}
