﻿namespace BlodtryksApplikation
{
    partial class BTAHovedvindue
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kalibrérSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKalibrerSystem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1552, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalibrérSystemToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // kalibrérSystemToolStripMenuItem
            // 
            this.kalibrérSystemToolStripMenuItem.Name = "kalibrérSystemToolStripMenuItem";
            this.kalibrérSystemToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.kalibrérSystemToolStripMenuItem.Text = "Kalibrér system";
            this.kalibrérSystemToolStripMenuItem.Click += new System.EventHandler(this.btnToolStripKalibrerSystem_Click);
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Location = new System.Drawing.Point(12, 51);
            this.btnKalibrerSystem.Name = "btnKalibrerSystem";
            this.btnKalibrerSystem.Size = new System.Drawing.Size(160, 40);
            this.btnKalibrerSystem.TabIndex = 1;
            this.btnKalibrerSystem.Text = "Kalibrér system";
            this.btnKalibrerSystem.UseVisualStyleBackColor = true;
            this.btnKalibrerSystem.Click += new System.EventHandler(this.btnKalibrerSystem_Click);
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 906);
            this.Controls.Add(this.btnKalibrerSystem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kalibrérSystemToolStripMenuItem;
        private System.Windows.Forms.Button btnKalibrerSystem;
    }
}
