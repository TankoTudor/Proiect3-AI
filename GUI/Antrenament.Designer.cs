namespace Proiect3_AI
{
    partial class Antrenament
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
            this.label1 = new System.Windows.Forms.Label();
            this.ratadeinvNud = new System.Windows.Forms.NumericUpDown();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.neuHL1NUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.errorNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nrHLNUD = new System.Windows.Forms.NumericUpDown();
            this.hl2Label = new System.Windows.Forms.Label();
            this.neuHL2NUD = new System.Windows.Forms.NumericUpDown();
            this.neuHL3NUD = new System.Windows.Forms.NumericUpDown();
            this.hl3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratadeinvNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrHLNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL3NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rata de invatare:";
            // 
            // ratadeinvNud
            // 
            this.ratadeinvNud.DecimalPlaces = 2;
            this.ratadeinvNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ratadeinvNud.Location = new System.Drawing.Point(138, 674);
            this.ratadeinvNud.Name = "ratadeinvNud";
            this.ratadeinvNud.Size = new System.Drawing.Size(62, 27);
            this.ratadeinvNud.TabIndex = 1;
            this.ratadeinvNud.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 14);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1236, 537);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1019, 559);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 63);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1143, 559);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 63);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numar neuroni HL1:";
            // 
            // neuHL1NUD
            // 
            this.neuHL1NUD.Location = new System.Drawing.Point(381, 580);
            this.neuHL1NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.neuHL1NUD.Name = "neuHL1NUD";
            this.neuHL1NUD.Size = new System.Drawing.Size(62, 27);
            this.neuHL1NUD.TabIndex = 6;
            this.neuHL1NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eroarea:";
            // 
            // errorNUD
            // 
            this.errorNUD.DecimalPlaces = 2;
            this.errorNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.errorNUD.Location = new System.Drawing.Point(81, 640);
            this.errorNUD.Name = "errorNUD";
            this.errorNUD.Size = new System.Drawing.Size(62, 27);
            this.errorNUD.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numar HL:";
            // 
            // nrHLNUD
            // 
            this.nrHLNUD.Location = new System.Drawing.Point(97, 600);
            this.nrHLNUD.Name = "nrHLNUD";
            this.nrHLNUD.Size = new System.Drawing.Size(62, 27);
            this.nrHLNUD.TabIndex = 10;
            this.nrHLNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrHLNUD.ValueChanged += new System.EventHandler(this.nrHLNUD_ValueChanged);
            // 
            // hl2Label
            // 
            this.hl2Label.AutoSize = true;
            this.hl2Label.Location = new System.Drawing.Point(234, 620);
            this.hl2Label.Name = "hl2Label";
            this.hl2Label.Size = new System.Drawing.Size(141, 20);
            this.hl2Label.TabIndex = 11;
            this.hl2Label.Text = "Numar neuroni HL2:";
            this.hl2Label.Visible = false;
            // 
            // neuHL2NUD
            // 
            this.neuHL2NUD.Location = new System.Drawing.Point(381, 620);
            this.neuHL2NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.neuHL2NUD.Name = "neuHL2NUD";
            this.neuHL2NUD.Size = new System.Drawing.Size(62, 27);
            this.neuHL2NUD.TabIndex = 12;
            this.neuHL2NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neuHL2NUD.Visible = false;
            // 
            // neuHL3NUD
            // 
            this.neuHL3NUD.Location = new System.Drawing.Point(381, 663);
            this.neuHL3NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.neuHL3NUD.Name = "neuHL3NUD";
            this.neuHL3NUD.Size = new System.Drawing.Size(62, 27);
            this.neuHL3NUD.TabIndex = 13;
            this.neuHL3NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neuHL3NUD.Visible = false;
            // 
            // hl3Label
            // 
            this.hl3Label.AutoSize = true;
            this.hl3Label.Location = new System.Drawing.Point(234, 663);
            this.hl3Label.Name = "hl3Label";
            this.hl3Label.Size = new System.Drawing.Size(141, 20);
            this.hl3Label.TabIndex = 14;
            this.hl3Label.Text = "Numar neuroni HL3:";
            this.hl3Label.Visible = false;
            // 
            // Antrenament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 705);
            this.Controls.Add(this.hl3Label);
            this.Controls.Add(this.neuHL3NUD);
            this.Controls.Add(this.neuHL2NUD);
            this.Controls.Add(this.hl2Label);
            this.Controls.Add(this.nrHLNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.neuHL1NUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.ratadeinvNud);
            this.Controls.Add(this.label1);
            this.Name = "Antrenament";
            this.Text = "Antrenament";
            ((System.ComponentModel.ISupportInitialize)(this.ratadeinvNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrHLNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuHL3NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown ratadeinvNud;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private Button btnStart;
        private Button btnStop;
        private Label label2;
        private NumericUpDown neuHL1NUD;
        private Label label3;
        private NumericUpDown errorNUD;
        private Label label4;
        private NumericUpDown nrHLNUD;
        private Label hl2Label;
        private NumericUpDown neuHL2NUD;
        private NumericUpDown neuHL3NUD;
        private Label hl3Label;
    }
}