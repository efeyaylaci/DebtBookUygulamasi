namespace VeresiyeUygulması
{
    partial class Form_Deneme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.açıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.işlemTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alakalıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defterDatasetiDataSet1 = new VeresiyeUygulması.DefterDatasetiDataSet1();
            this.mainDatasetTableAdapter = new VeresiyeUygulması.DefterDatasetiDataSet1TableAdapters.MainDatasetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defterDatasetiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kullanıcıidDataGridViewTextBoxColumn,
            this.açıklamaDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.işlemTürüDataGridViewTextBoxColumn,
            this.birimTipiDataGridViewTextBoxColumn,
            this.alakalıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mainDatasetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullanıcıidDataGridViewTextBoxColumn
            // 
            this.kullanıcıidDataGridViewTextBoxColumn.DataPropertyName = "kullanıcı_id";
            this.kullanıcıidDataGridViewTextBoxColumn.HeaderText = "kullanıcı_id";
            this.kullanıcıidDataGridViewTextBoxColumn.Name = "kullanıcıidDataGridViewTextBoxColumn";
            // 
            // açıklamaDataGridViewTextBoxColumn
            // 
            this.açıklamaDataGridViewTextBoxColumn.DataPropertyName = "açıklama";
            this.açıklamaDataGridViewTextBoxColumn.HeaderText = "açıklama";
            this.açıklamaDataGridViewTextBoxColumn.Name = "açıklamaDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // işlemTürüDataGridViewTextBoxColumn
            // 
            this.işlemTürüDataGridViewTextBoxColumn.DataPropertyName = "işlemTürü";
            this.işlemTürüDataGridViewTextBoxColumn.HeaderText = "işlemTürü";
            this.işlemTürüDataGridViewTextBoxColumn.Name = "işlemTürüDataGridViewTextBoxColumn";
            // 
            // birimTipiDataGridViewTextBoxColumn
            // 
            this.birimTipiDataGridViewTextBoxColumn.DataPropertyName = "birimTipi";
            this.birimTipiDataGridViewTextBoxColumn.HeaderText = "birimTipi";
            this.birimTipiDataGridViewTextBoxColumn.Name = "birimTipiDataGridViewTextBoxColumn";
            // 
            // alakalıDataGridViewTextBoxColumn
            // 
            this.alakalıDataGridViewTextBoxColumn.DataPropertyName = "alakalı";
            this.alakalıDataGridViewTextBoxColumn.HeaderText = "alakalı";
            this.alakalıDataGridViewTextBoxColumn.Name = "alakalıDataGridViewTextBoxColumn";
            // 
            // mainDatasetBindingSource
            // 
            this.mainDatasetBindingSource.DataMember = "MainDataset";
            this.mainDatasetBindingSource.DataSource = this.defterDatasetiDataSet1;
            // 
            // defterDatasetiDataSet1
            // 
            this.defterDatasetiDataSet1.DataSetName = "DefterDatasetiDataSet1";
            this.defterDatasetiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDatasetTableAdapter
            // 
            this.mainDatasetTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Deneme";
            this.Text = "Form_Deneme";
            this.Load += new System.EventHandler(this.Form_Deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defterDatasetiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DefterDatasetiDataSet1 defterDatasetiDataSet1;
        private System.Windows.Forms.BindingSource mainDatasetBindingSource;
        private DefterDatasetiDataSet1TableAdapters.MainDatasetTableAdapter mainDatasetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alakalıDataGridViewTextBoxColumn;
    }
}