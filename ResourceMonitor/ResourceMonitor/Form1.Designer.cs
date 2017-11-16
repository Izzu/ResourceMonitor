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
            this.cpuText = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cpuPerf = new System.Diagnostics.PerformanceCounter();
            this.ramLabel = new System.Windows.Forms.Label();
            this.ramText = new System.Windows.Forms.Label();
            this.ramPerfAv = new System.Diagnostics.PerformanceCounter();
            this.ramBar = new System.Windows.Forms.ProgressBar();
            this.ramPerfPerc = new System.Diagnostics.PerformanceCounter();
            this.upLabel = new System.Windows.Forms.Label();
            this.upText = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.downText = new System.Windows.Forms.Label();
            this.upPerf = new System.Diagnostics.PerformanceCounter();
            this.downPerf = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfAv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPerf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPerf)).BeginInit();
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
            // cpuText
            // 
            this.cpuText.AutoSize = true;
            this.cpuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuText.Location = new System.Drawing.Point(144, 19);
            this.cpuText.Name = "cpuText";
            this.cpuText.Size = new System.Drawing.Size(32, 17);
            this.cpuText.TabIndex = 2;
            this.cpuText.Text = "0 %";
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
            // ramText
            // 
            this.ramText.AutoSize = true;
            this.ramText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramText.Location = new System.Drawing.Point(144, 54);
            this.ramText.Name = "ramText";
            this.ramText.Size = new System.Drawing.Size(80, 17);
            this.ramText.TabIndex = 4;
            this.ramText.Text = "0 MB FREE";
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
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLabel.Location = new System.Drawing.Point(12, 85);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(75, 20);
            this.upLabel.TabIndex = 6;
            this.upLabel.Text = "UPLOAD";
            // 
            // upText
            // 
            this.upText.AutoSize = true;
            this.upText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upText.Location = new System.Drawing.Point(93, 85);
            this.upText.Name = "upText";
            this.upText.Size = new System.Drawing.Size(54, 17);
            this.upText.TabIndex = 7;
            this.upText.Text = "0 Gbps";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLabel.Location = new System.Drawing.Point(12, 115);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(103, 20);
            this.downLabel.TabIndex = 8;
            this.downLabel.Text = "DOWNLOAD";
            // 
            // downText
            // 
            this.downText.AutoSize = true;
            this.downText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downText.Location = new System.Drawing.Point(121, 115);
            this.downText.Name = "downText";
            this.downText.Size = new System.Drawing.Size(54, 17);
            this.downText.TabIndex = 9;
            this.downText.Text = "0 Gbps";
            // 
            // upPerf
            // 
            this.upPerf.CategoryName = "Network Interface";
            this.upPerf.CounterName = "Bytes Sent/sec";
            this.upPerf.InstanceName = "Intel[R] 82579V Gigabit Network Connection";
            // 
            // downPerf
            // 
            this.downPerf.CategoryName = "Network Interface";
            this.downPerf.CounterName = "Bytes Received/sec";
            this.downPerf.InstanceName = "Intel[R] 82579V Gigabit Network Connection";
            // 
            // ResourceMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 156);
            this.Controls.Add(this.downText);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upText);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.ramBar);
            this.Controls.Add(this.ramText);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.cpuText);
            this.Controls.Add(this.cpuBar);
            this.Controls.Add(this.labelCPU);
            this.Name = "ResourceMonitor";
            this.Text = "Resource Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfAv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPerfPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPerf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPerf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.Label cpuText;
        private System.Windows.Forms.Timer Timer;
        private System.Diagnostics.PerformanceCounter cpuPerf;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label ramText;
        private System.Diagnostics.PerformanceCounter ramPerfAv;
        private System.Windows.Forms.ProgressBar ramBar;
        private System.Diagnostics.PerformanceCounter ramPerfPerc;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label upText;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label downText;
        private System.Diagnostics.PerformanceCounter upPerf;
        private System.Diagnostics.PerformanceCounter downPerf;
    }
}

