namespace Daliz
{
    partial class frmFieldManager
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetDaliz = new System.Data.DataSet();
            this.meta_keys = new System.Data.DataTable();
            this.Id = new System.Data.DataColumn();
            this.Title = new System.Data.DataColumn();
            this.Slug = new System.Data.DataColumn();
            this.Table = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDaliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta_keys)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "اسکرام";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSetDaliz;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataSetDaliz
            // 
            this.dataSetDaliz.DataSetName = "dataSetDaliz";
            this.dataSetDaliz.Locale = new System.Globalization.CultureInfo("fa");
            this.dataSetDaliz.Tables.AddRange(new System.Data.DataTable[] {
            this.meta_keys});
            // 
            // meta_keys
            // 
            this.meta_keys.CaseSensitive = false;
            this.meta_keys.Columns.AddRange(new System.Data.DataColumn[] {
            this.Id,
            this.Title,
            this.Slug,
            this.Table});
            this.meta_keys.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, false)});
            this.meta_keys.TableName = "meta_keys";
            // 
            // Id
            // 
            this.Id.AutoIncrement = true;
            this.Id.ColumnName = "Id";
            this.Id.DataType = typeof(int);
            // 
            // Title
            // 
            this.Title.ColumnName = "Title";
            // 
            // Slug
            // 
            this.Slug.Caption = "Slug";
            this.Slug.ColumnName = "Slug";
            // 
            // Table
            // 
            this.Table.Caption = "Table";
            this.Table.ColumnName = "Table";
            // 
            // frmFieldManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFieldManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فیلدها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDaliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta_keys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Data.DataSet dataSetDaliz;
        private System.Data.DataTable meta_keys;
        private System.Data.DataColumn Id;
        private System.Data.DataColumn Title;
        private System.Data.DataColumn Slug;
        private System.Data.DataColumn Table;
    }
}