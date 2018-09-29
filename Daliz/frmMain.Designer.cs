namespace Daliz
{
    partial class frmMain
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
            this.dgGoods = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.پروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دادههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فیلدهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgGoods
            // 
            this.dgGoods.AllowUserToOrderColumns = true;
            this.dgGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title});
            this.dgGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGoods.Location = new System.Drawing.Point(0, 24);
            this.dgGoods.Name = "dgGoods";
            this.dgGoods.Size = new System.Drawing.Size(705, 148);
            this.dgGoods.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "شناسه";
            this.id.Name = "id";
            // 
            // Title
            // 
            this.Title.HeaderText = "عنوان کالا";
            this.Title.Name = "Title";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پروندهToolStripMenuItem,
            this.دادههاToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // پروندهToolStripMenuItem
            // 
            this.پروندهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.پروندهToolStripMenuItem.Name = "پروندهToolStripMenuItem";
            this.پروندهToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.پروندهToolStripMenuItem.Text = "پرونده";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // دادههاToolStripMenuItem
            // 
            this.دادههاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فیلدهاToolStripMenuItem});
            this.دادههاToolStripMenuItem.Name = "دادههاToolStripMenuItem";
            this.دادههاToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.دادههاToolStripMenuItem.Text = "داده‌ها";
            // 
            // فیلدهاToolStripMenuItem
            // 
            this.فیلدهاToolStripMenuItem.Name = "فیلدهاToolStripMenuItem";
            this.فیلدهاToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.فیلدهاToolStripMenuItem.Text = "فیلدها";
            this.فیلدهاToolStripMenuItem.Click += new System.EventHandler(this.فیلدهاToolStripMenuItem_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.دربارهToolStripMenuItem.Text = "درباره";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 172);
            this.Controls.Add(this.dgGoods);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "دالیز";
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem پروندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دادههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فیلدهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
    }
}

