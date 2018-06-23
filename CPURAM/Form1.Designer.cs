namespace CPURAM
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1Cpu = new System.Windows.Forms.ProgressBar();
            this.progressBar2Ram = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.LbCpu = new System.Windows.Forms.Label();
            this.LbRam = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU :";
            // 
            // progressBar1Cpu
            // 
            this.progressBar1Cpu.Location = new System.Drawing.Point(94, 122);
            this.progressBar1Cpu.Name = "progressBar1Cpu";
            this.progressBar1Cpu.Size = new System.Drawing.Size(396, 23);
            this.progressBar1Cpu.TabIndex = 1;
            // 
            // progressBar2Ram
            // 
            this.progressBar2Ram.Location = new System.Drawing.Point(94, 173);
            this.progressBar2Ram.Name = "progressBar2Ram";
            this.progressBar2Ram.Size = new System.Drawing.Size(396, 23);
            this.progressBar2Ram.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "RAM :";
            // 
            // LbCpu
            // 
            this.LbCpu.AutoSize = true;
            this.LbCpu.Location = new System.Drawing.Point(508, 122);
            this.LbCpu.Name = "LbCpu";
            this.LbCpu.Size = new System.Drawing.Size(32, 17);
            this.LbCpu.TabIndex = 4;
            this.LbCpu.Text = "0 %";
            // 
            // LbRam
            // 
            this.LbRam.AutoSize = true;
            this.LbRam.Location = new System.Drawing.Point(508, 179);
            this.LbRam.Name = "LbRam";
            this.LbRam.Size = new System.Drawing.Size(32, 17);
            this.LbRam.TabIndex = 5;
            this.LbRam.Text = "0 %";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(94, 227);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(396, 300);
            this.chart1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 550);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LbRam);
            this.Controls.Add(this.LbCpu);
            this.Controls.Add(this.progressBar2Ram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1Cpu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RAM & CPU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1Cpu;
        private System.Windows.Forms.ProgressBar progressBar2Ram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbCpu;
        private System.Windows.Forms.Label LbRam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

