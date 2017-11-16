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
            this.cpubar = new System.Windows.Forms.ProgressBar();
            this.perCPU = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cpuPerf = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).BeginInit();
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
            // cpubar
            // 
            this.cpubar.Location = new System.Drawing.Point(60, 21);
            this.cpubar.Name = "cpubar";
            this.cpubar.Size = new System.Drawing.Size(78, 15);
            this.cpubar.TabIndex = 1;
            // 
            // perCPU
            // 
            this.perCPU.AutoSize = true;
            this.perCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perCPU.Location = new System.Drawing.Point(144, 19);
            this.perCPU.Name = "perCPU";
            this.perCPU.Size = new System.Drawing.Size(32, 17);
            this.perCPU.TabIndex = 2;
            this.perCPU.Text = "0 %";
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
            // ResourceMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.perCPU);
            this.Controls.Add(this.cpubar);
            this.Controls.Add(this.labelCPU);
            this.Name = "ResourceMonitor";
            this.Text = "Resource Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuPerf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.ProgressBar cpubar;
        private System.Windows.Forms.Label perCPU;
        private System.Windows.Forms.Timer Timer;
        private System.Diagnostics.PerformanceCounter cpuPerf;
    }
}

