namespace ResourceMonitor
{
    partial class ResourceMonitor
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
            this.labelCPU = new System.Windows.Forms.Label();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.cpuPerc = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cpuPerf = new System.Diagnostics.PerformanceCounter();
            this.ramLabel = new System.Windows.Forms.Label();
            this.ramAmt = new System.Windows.Forms.Label();
            this.ramPerfAv = new System.Diagnostics.PerformanceCounter();
            this.ramBar = new System.Windows.Forms.ProgressBar();
            this.ramPerfPerc = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfAv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfPerc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(12, 19);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(42, 20);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "CPU";
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(60, 21);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(78, 15);
            this.cpuBar.TabIndex = 1;
            // 
            // cpuPerc
            // 
            this.cpuPerc.AutoSize = true;
            this.cpuPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPerc.Location = new System.Drawing.Point(144, 19);
            this.cpuPerc.Name = "cpuPerc";
            this.cpuPerc.Size = new System.Drawing.Size(32, 17);
            this.cpuPerc.TabIndex = 2;
            this.cpuPerc.Text = "0 %";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cpuPerf
            // 
            this.cpuPerf.CategoryName = "Processor";
            this.cpuPerf.CounterName = "% Processor Time";
            this.cpuPerf.InstanceName = "_Total";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLabel.Location = new System.Drawing.Point(12, 52);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(45, 20);
            this.ramLabel.TabIndex = 3;
            this.ramLabel.Text = "RAM";
            // 
            // ramAmt
            // 
            this.ramAmt.AutoSize = true;
            this.ramAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramAmt.Location = new System.Drawing.Point(144, 54);
            this.ramAmt.Name = "ramAmt";
            this.ramAmt.Size = new System.Drawing.Size(40, 17);
            this.ramAmt.TabIndex = 4;
            this.ramAmt.Text = "0 MB";
            // 
            // ramPerfAv
            // 
            this.ramPerfAv.CategoryName = "Memory";
            this.ramPerfAv.CounterName = "Available MBytes";
            // 
            // ramBar
            // 
            this.ramBar.Location = new System.Drawing.Point(60, 55);
            this.ramBar.Name = "ramBar";
            this.ramBar.Size = new System.Drawing.Size(78, 15);
            this.ramBar.TabIndex = 5;
            // 
            // ramPerfPerc
            // 
            this.ramPerfPerc.CategoryName = "Memory";
            this.ramPerfPerc.CounterName = "% Committed Bytes In Use";
            // 
            // ResourceMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.ramBar);
            this.Controls.Add(this.ramAmt);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.cpuPerc);
            this.Controls.Add(this.cpuBar);
            this.Controls.Add(this.labelCPU);
            this.Name = "ResourceMonitor";
            this.Text = "Resource Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfAv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfPerc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.Label cpuPerc;
        private System.Windows.Forms.Timer Timer;
        private System.Diagnostics.PerformanceCounter cpuPerf;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label ramAmt;
        private System.Diagnostics.PerformanceCounter ramPerfAv;
        private System.Windows.Forms.ProgressBar ramBar;
        private System.Diagnostics.PerformanceCounter ramPerfPerc;
    }
}

