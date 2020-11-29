namespace calculator
{
    partial class Painter
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
            this.panel = new System.Windows.Forms.Panel();
            this.labelNotif = new System.Windows.Forms.Label();
            this.labelPointA = new System.Windows.Forms.Label();
            this.labelPointB = new System.Windows.Forms.Label();
            this.labelPointD = new System.Windows.Forms.Label();
            this.labelPointA_ = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonChangepoint = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelNotif);
            this.panel.Location = new System.Drawing.Point(154, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(703, 604);
            this.panel.TabIndex = 0;
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.BackColor = System.Drawing.Color.White;
            this.labelNotif.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.Location = new System.Drawing.Point(14, 10);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(136, 18);
            this.labelNotif.TabIndex = 6;
            this.labelNotif.Text = "Click somewhere!";
            this.labelNotif.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPointA
            // 
            this.labelPointA.AutoSize = true;
            this.labelPointA.BackColor = System.Drawing.SystemColors.Control;
            this.labelPointA.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointA.Location = new System.Drawing.Point(12, 71);
            this.labelPointA.Name = "labelPointA";
            this.labelPointA.Size = new System.Drawing.Size(16, 18);
            this.labelPointA.TabIndex = 2;
            this.labelPointA.Text = "A";
            this.labelPointA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPointB
            // 
            this.labelPointB.AutoSize = true;
            this.labelPointB.BackColor = System.Drawing.SystemColors.Control;
            this.labelPointB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointB.Location = new System.Drawing.Point(12, 121);
            this.labelPointB.Name = "labelPointB";
            this.labelPointB.Size = new System.Drawing.Size(16, 18);
            this.labelPointB.TabIndex = 3;
            this.labelPointB.Text = "B";
            this.labelPointB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPointD
            // 
            this.labelPointD.AutoSize = true;
            this.labelPointD.BackColor = System.Drawing.SystemColors.Control;
            this.labelPointD.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointD.Location = new System.Drawing.Point(12, 171);
            this.labelPointD.Name = "labelPointD";
            this.labelPointD.Size = new System.Drawing.Size(16, 18);
            this.labelPointD.TabIndex = 4;
            this.labelPointD.Text = "D";
            this.labelPointD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPointA_
            // 
            this.labelPointA_.AutoSize = true;
            this.labelPointA_.BackColor = System.Drawing.SystemColors.Control;
            this.labelPointA_.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointA_.Location = new System.Drawing.Point(12, 221);
            this.labelPointA_.Name = "labelPointA_";
            this.labelPointA_.Size = new System.Drawing.Size(24, 18);
            this.labelPointA_.TabIndex = 5;
            this.labelPointA_.Text = "A\'";
            this.labelPointA_.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(12, 535);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(127, 56);
            this.buttonFinish.TabIndex = 6;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonChangepoint
            // 
            this.buttonChangepoint.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangepoint.Location = new System.Drawing.Point(12, 284);
            this.buttonChangepoint.Name = "buttonChangepoint";
            this.buttonChangepoint.Size = new System.Drawing.Size(126, 52);
            this.buttonChangepoint.TabIndex = 7;
            this.buttonChangepoint.Text = "Change Point";
            this.buttonChangepoint.UseVisualStyleBackColor = true;
            this.buttonChangepoint.Click += new System.EventHandler(this.buttonChangepoint_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.SystemColors.Control;
            this.labelLocation.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(9, 40);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(16, 18);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(856, 603);
            this.Controls.Add(this.buttonChangepoint);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelPointA_);
            this.Controls.Add(this.labelPointD);
            this.Controls.Add(this.labelPointB);
            this.Controls.Add(this.labelPointA);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Painter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.Painter_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelPointA;
        private System.Windows.Forms.Label labelPointB;
        private System.Windows.Forms.Label labelPointD;
        private System.Windows.Forms.Label labelPointA_;
        private System.Windows.Forms.Label labelNotif;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonChangepoint;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}