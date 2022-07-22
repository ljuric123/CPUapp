namespace Perf_monitor
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
            this.cpunamevar = new System.Windows.Forms.Label();
            this.CPUname = new System.Windows.Forms.Label();
            this.CPUclockspeed = new System.Windows.Forms.Label();
            this.cpuclockspeedvar = new System.Windows.Forms.Label();
            this.CPUvolt = new System.Windows.Forms.Label();
            this.cpuvoltvar = new System.Windows.Forms.Label();
            this.cpuperprotime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpunamevar
            // 
            this.cpunamevar.AutoSize = true;
            this.cpunamevar.Location = new System.Drawing.Point(128, 64);
            this.cpunamevar.Name = "cpunamevar";
            this.cpunamevar.Size = new System.Drawing.Size(35, 13);
            this.cpunamevar.TabIndex = 0;
            this.cpunamevar.Text = "label1";
            // 
            // CPUname
            // 
            this.CPUname.AutoSize = true;
            this.CPUname.Location = new System.Drawing.Point(59, 64);
            this.CPUname.Name = "CPUname";
            this.CPUname.Size = new System.Drawing.Size(63, 13);
            this.CPUname.TabIndex = 1;
            this.CPUname.Text = "CPU Name:";
            // 
            // CPUclockspeed
            // 
            this.CPUclockspeed.AutoSize = true;
            this.CPUclockspeed.Location = new System.Drawing.Point(59, 94);
            this.CPUclockspeed.Name = "CPUclockspeed";
            this.CPUclockspeed.Size = new System.Drawing.Size(96, 13);
            this.CPUclockspeed.TabIndex = 2;
            this.CPUclockspeed.Text = "CPU Clock Speed:";
            // 
            // cpuclockspeedvar
            // 
            this.cpuclockspeedvar.AutoSize = true;
            this.cpuclockspeedvar.Location = new System.Drawing.Point(162, 94);
            this.cpuclockspeedvar.Name = "cpuclockspeedvar";
            this.cpuclockspeedvar.Size = new System.Drawing.Size(35, 13);
            this.cpuclockspeedvar.TabIndex = 3;
            this.cpuclockspeedvar.Text = "label1";
            // 
            // CPUvolt
            // 
            this.CPUvolt.AutoSize = true;
            this.CPUvolt.Location = new System.Drawing.Point(62, 125);
            this.CPUvolt.Name = "CPUvolt";
            this.CPUvolt.Size = new System.Drawing.Size(71, 13);
            this.CPUvolt.TabIndex = 4;
            this.CPUvolt.Text = "CPU Voltage:";
            // 
            // cpuvoltvar
            // 
            this.cpuvoltvar.AutoSize = true;
            this.cpuvoltvar.Location = new System.Drawing.Point(139, 125);
            this.cpuvoltvar.Name = "cpuvoltvar";
            this.cpuvoltvar.Size = new System.Drawing.Size(35, 13);
            this.cpuvoltvar.TabIndex = 5;
            this.cpuvoltvar.Text = "label2";
            // 
            // cpuperprotime
            // 
            this.cpuperprotime.AutoSize = true;
            this.cpuperprotime.Location = new System.Drawing.Point(142, 153);
            this.cpuperprotime.Name = "cpuperprotime";
            this.cpuperprotime.Size = new System.Drawing.Size(35, 13);
            this.cpuperprotime.TabIndex = 6;
            this.cpuperprotime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 511);
            this.Controls.Add(this.cpuperprotime);
            this.Controls.Add(this.cpuvoltvar);
            this.Controls.Add(this.CPUvolt);
            this.Controls.Add(this.cpuclockspeedvar);
            this.Controls.Add(this.CPUclockspeed);
            this.Controls.Add(this.CPUname);
            this.Controls.Add(this.cpunamevar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CPUname;
        private System.Windows.Forms.Label CPUclockspeed;
        private System.Windows.Forms.Label CPUvolt;
        public System.Windows.Forms.Label cpunamevar;
        public System.Windows.Forms.Label cpuclockspeedvar;
        public System.Windows.Forms.Label cpuvoltvar;
        public System.Windows.Forms.Label cpuperprotime;
    }
}

