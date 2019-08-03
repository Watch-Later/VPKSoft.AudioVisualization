﻿namespace TestApplication
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btStartStopLine = new System.Windows.Forms.Button();
            this.cbCombineChannels = new System.Windows.Forms.CheckBox();
            this.btStartStopBars = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.audioVisualizationPlot1 = new VPKSoft.AudioVisualization.AudioVisualizationPlot();
            this.audioVisualizationBars1 = new VPKSoft.AudioVisualization.AudioVisualizationBars();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStartStopLine
            // 
            this.btStartStopLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStartStopLine.Location = new System.Drawing.Point(12, 472);
            this.btStartStopLine.Name = "btStartStopLine";
            this.btStartStopLine.Size = new System.Drawing.Size(75, 23);
            this.btStartStopLine.TabIndex = 1;
            this.btStartStopLine.Text = "Start";
            this.btStartStopLine.UseVisualStyleBackColor = true;
            this.btStartStopLine.Click += new System.EventHandler(this.BtStartStop_Click);
            // 
            // cbCombineChannels
            // 
            this.cbCombineChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCombineChannels.AutoSize = true;
            this.cbCombineChannels.Location = new System.Drawing.Point(269, 478);
            this.cbCombineChannels.Name = "cbCombineChannels";
            this.cbCombineChannels.Size = new System.Drawing.Size(113, 17);
            this.cbCombineChannels.TabIndex = 2;
            this.cbCombineChannels.Text = "Combine channels";
            this.cbCombineChannels.UseVisualStyleBackColor = true;
            this.cbCombineChannels.CheckedChanged += new System.EventHandler(this.CbCombineChannels_CheckedChanged);
            // 
            // btStartStopBars
            // 
            this.btStartStopBars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStartStopBars.Location = new System.Drawing.Point(93, 472);
            this.btStartStopBars.Name = "btStartStopBars";
            this.btStartStopBars.Size = new System.Drawing.Size(75, 23);
            this.btStartStopBars.TabIndex = 4;
            this.btStartStopBars.Text = "Start";
            this.btStartStopBars.UseVisualStyleBackColor = true;
            this.btStartStopBars.Click += new System.EventHandler(this.BtStartStopBars_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.audioVisualizationPlot1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.audioVisualizationBars1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 454);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // audioVisualizationPlot1
            // 
            this.audioVisualizationPlot1.ColorAudioChannelLeft = System.Drawing.Color.Aqua;
            this.audioVisualizationPlot1.ColorAudioChannelRight = System.Drawing.Color.LimeGreen;
            this.audioVisualizationPlot1.ColorHertzLabels = System.Drawing.Color.Magenta;
            this.audioVisualizationPlot1.CombineChannels = false;
            this.audioVisualizationPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioVisualizationPlot1.Location = new System.Drawing.Point(3, 3);
            this.audioVisualizationPlot1.Name = "audioVisualizationPlot1";
            this.audioVisualizationPlot1.Size = new System.Drawing.Size(770, 221);
            this.audioVisualizationPlot1.TabIndex = 0;
            // 
            // audioVisualizationBars1
            // 
            this.audioVisualizationBars1.ColorAudioChannelLeft = System.Drawing.Color.Aqua;
            this.audioVisualizationBars1.ColorAudioChannelRight = System.Drawing.Color.LimeGreen;
            this.audioVisualizationBars1.ColorHertzLabels = System.Drawing.Color.Magenta;
            this.audioVisualizationBars1.CombineChannels = false;
            this.audioVisualizationBars1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioVisualizationBars1.HertzSpan = 200;
            this.audioVisualizationBars1.Location = new System.Drawing.Point(3, 230);
            this.audioVisualizationBars1.Name = "audioVisualizationBars1";
            this.audioVisualizationBars1.Size = new System.Drawing.Size(770, 221);
            this.audioVisualizationBars1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btStartStopBars);
            this.Controls.Add(this.cbCombineChannels);
            this.Controls.Add(this.btStartStopLine);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VPKSoft.AudioVisualization.AudioVisualizationPlot audioVisualizationPlot1;
        private System.Windows.Forms.Button btStartStopLine;
        private System.Windows.Forms.CheckBox cbCombineChannels;
        private System.Windows.Forms.Button btStartStopBars;
        private VPKSoft.AudioVisualization.AudioVisualizationBars audioVisualizationBars1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

