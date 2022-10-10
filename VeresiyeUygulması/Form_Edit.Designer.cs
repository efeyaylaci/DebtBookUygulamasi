namespace VeresiyeUygulması
{
    partial class Form_Edit
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
            this.dealerBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkExpenseBox2 = new System.Windows.Forms.CheckBox();
            this.checkIncomeBox1 = new System.Windows.Forms.CheckBox();
            this.descriptionBox4 = new System.Windows.Forms.TextBox();
            this.unitAmountBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dealerBox1
            // 
            this.dealerBox1.Location = new System.Drawing.Point(89, 121);
            this.dealerBox1.Name = "dealerBox1";
            this.dealerBox1.Size = new System.Drawing.Size(165, 20);
            this.dealerBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Dealer          :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkExpenseBox2
            // 
            this.checkExpenseBox2.AutoSize = true;
            this.checkExpenseBox2.Location = new System.Drawing.Point(188, 157);
            this.checkExpenseBox2.Name = "checkExpenseBox2";
            this.checkExpenseBox2.Size = new System.Drawing.Size(66, 17);
            this.checkExpenseBox2.TabIndex = 23;
            this.checkExpenseBox2.Text = "expense";
            this.checkExpenseBox2.UseVisualStyleBackColor = true;
            this.checkExpenseBox2.CheckedChanged += new System.EventHandler(this.checkExpenseBox2_CheckedChanged);
            // 
            // checkIncomeBox1
            // 
            this.checkIncomeBox1.AutoSize = true;
            this.checkIncomeBox1.Location = new System.Drawing.Point(88, 157);
            this.checkIncomeBox1.Name = "checkIncomeBox1";
            this.checkIncomeBox1.Size = new System.Drawing.Size(60, 17);
            this.checkIncomeBox1.TabIndex = 22;
            this.checkIncomeBox1.Text = "income";
            this.checkIncomeBox1.UseVisualStyleBackColor = true;
            this.checkIncomeBox1.CheckedChanged += new System.EventHandler(this.checkIncomeBox1_CheckedChanged);
            // 
            // descriptionBox4
            // 
            this.descriptionBox4.Location = new System.Drawing.Point(88, 189);
            this.descriptionBox4.Multiline = true;
            this.descriptionBox4.Name = "descriptionBox4";
            this.descriptionBox4.Size = new System.Drawing.Size(166, 85);
            this.descriptionBox4.TabIndex = 21;
            // 
            // unitAmountBox2
            // 
            this.unitAmountBox2.Location = new System.Drawing.Point(89, 45);
            this.unitAmountBox2.Name = "unitAmountBox2";
            this.unitAmountBox2.Size = new System.Drawing.Size(166, 20);
            this.unitAmountBox2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "(optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Description   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Transaction  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Unit Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product        :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Amount Unit :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 322);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dealerBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkExpenseBox2);
            this.Controls.Add(this.checkIncomeBox1);
            this.Controls.Add(this.descriptionBox4);
            this.Controls.Add(this.unitAmountBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Edit";
            this.Text = "DebtBook";
            this.Load += new System.EventHandler(this.Form_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dealerBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkExpenseBox2;
        private System.Windows.Forms.CheckBox checkIncomeBox1;
        private System.Windows.Forms.TextBox descriptionBox4;
        private System.Windows.Forms.TextBox unitAmountBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}