namespace Proiect3_AI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cirosisDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDataTMS = new System.Windows.Forms.ToolStripMenuItem();
            this.antrenamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cirosisDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cirosisDGV
            // 
            this.cirosisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cirosisDGV.Location = new System.Drawing.Point(12, 31);
            this.cirosisDGV.Name = "cirosisDGV";
            this.cirosisDGV.RowHeadersWidth = 51;
            this.cirosisDGV.RowTemplate.Height = 29;
            this.cirosisDGV.Size = new System.Drawing.Size(1322, 674);
            this.cirosisDGV.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataTMS,
            this.antrenamentToolStripMenuItem,
            this.testareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadDataTMS
            // 
            this.loadDataTMS.Name = "loadDataTMS";
            this.loadDataTMS.Size = new System.Drawing.Size(105, 24);
            this.loadDataTMS.Text = "Normalizare";
            // 
            // antrenamentToolStripMenuItem
            // 
            this.antrenamentToolStripMenuItem.Name = "antrenamentToolStripMenuItem";
            this.antrenamentToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.antrenamentToolStripMenuItem.Text = "Antrenament";
            this.antrenamentToolStripMenuItem.Click += new System.EventHandler(this.antrenamentToolStripMenuItem_Click);
            // 
            // testareToolStripMenuItem
            // 
            this.testareToolStripMenuItem.Name = "testareToolStripMenuItem";
            this.testareToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.testareToolStripMenuItem.Text = "Testare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 727);
            this.Controls.Add(this.cirosisDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cirosisDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView cirosisDGV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadDataTMS;
        private ToolStripMenuItem antrenamentToolStripMenuItem;
        private ToolStripMenuItem testareToolStripMenuItem;
    }
}