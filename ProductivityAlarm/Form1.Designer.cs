namespace ProductivityAlarm
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
            this.alarm_btn = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alarm_btn
            // 
            this.alarm_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.alarm_btn.BackgroundImage = global::ProductivityAlarm.Properties.Resources.relaxing_background_aqzjl5if48n6fwf0;
            this.alarm_btn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_btn.Location = new System.Drawing.Point(343, 30);
            this.alarm_btn.Name = "alarm_btn";
            this.alarm_btn.Size = new System.Drawing.Size(118, 57);
            this.alarm_btn.TabIndex = 0;
            this.alarm_btn.Text = "Set Alarm!";
            this.alarm_btn.UseVisualStyleBackColor = false;
            this.alarm_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Lucida Sans Typewriter", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(317, 115);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(169, 55);
            this.currentTime.TabIndex = 1;
            this.currentTime.Text = "00:00";
            this.currentTime.Click += new System.EventHandler(this.currentTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.alarm_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alarm_btn;
        private System.Windows.Forms.Label currentTime;
    }
}

