namespace ControleFinanceiro.Interface
{
    partial class TableManagement
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
            this.tableName = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(12, 25);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(260, 20);
            this.tableName.TabIndex = 0;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(9, 9);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(63, 13);
            this.tableNameLabel.TabIndex = 1;
            this.tableNameLabel.Text = "Table name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Field type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 5;
            // 
            // addField
            // 
            this.addField.Location = new System.Drawing.Point(102, 113);
            this.addField.Name = "addField";
            this.addField.Size = new System.Drawing.Size(75, 23);
            this.addField.TabIndex = 6;
            this.addField.Text = "Add Field";
            this.addField.UseVisualStyleBackColor = true;
            this.addField.Click += new System.EventHandler(this.addField_Click);
            // 
            // TableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.addField);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.tableName);
            this.Name = "TableManagement";
            this.Text = "TableManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addField;
    }
}