﻿
namespace Lec10_DelegateEvent
{
    partial class FormEEG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartEEG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanelUserControlWaves = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartEEG)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEEG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEEG.ChartAreas.Add(chartArea1);
            this.chartEEG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEEG.Legends.Add(legend1);
            this.chartEEG.Location = new System.Drawing.Point(0, 0);
            this.chartEEG.Name = "chartEEG";
            this.chartEEG.Size = new System.Drawing.Size(1055, 493);
            this.chartEEG.TabIndex = 0;
            this.chartEEG.Text = "chart1";
            // 
            // flowLayoutPanelUserControlWaves
            // 
            this.flowLayoutPanelUserControlWaves.AutoSize = true;
            this.flowLayoutPanelUserControlWaves.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelUserControlWaves.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelUserControlWaves.Location = new System.Drawing.Point(0, 12);
            this.flowLayoutPanelUserControlWaves.Name = "flowLayoutPanelUserControlWaves";
            this.flowLayoutPanelUserControlWaves.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelUserControlWaves.TabIndex = 1;
            // 
            // FormEEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 493);
            this.Controls.Add(this.flowLayoutPanelUserControlWaves);
            this.Controls.Add(this.chartEEG);
            this.Name = "FormEEG";
            this.Text = "FormEEG";
            ((System.ComponentModel.ISupportInitialize)(this.chartEEG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEEG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserControlWaves;
    }
}

