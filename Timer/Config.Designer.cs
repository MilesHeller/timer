namespace Timer
{
    partial class FRMkonfig
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSFLstart = new System.Windows.Forms.Button();
            this.LBtimer = new System.Windows.Forms.Label();
            this.RBUhrTimer = new System.Windows.Forms.RadioButton();
            this.RBprozentTimer = new System.Windows.Forms.RadioButton();
            this.GBTimererschreinung = new System.Windows.Forms.GroupBox();
            this.TBtime = new System.Windows.Forms.MaskedTextBox();
            this.GBTimererschreinung.SuspendLayout();
            this.SuspendLayout();
            // 
            // BSFLstart
            // 
            this.BSFLstart.Location = new System.Drawing.Point(229, 54);
            this.BSFLstart.Name = "BSFLstart";
            this.BSFLstart.Size = new System.Drawing.Size(75, 23);
            this.BSFLstart.TabIndex = 0;
            this.BSFLstart.Text = "Start";
            this.BSFLstart.UseVisualStyleBackColor = true;
            this.BSFLstart.Click += new System.EventHandler(this.BSFLstart_Click);
            // 
            // LBtimer
            // 
            this.LBtimer.AutoSize = true;
            this.LBtimer.Location = new System.Drawing.Point(258, 196);
            this.LBtimer.Name = "LBtimer";
            this.LBtimer.Size = new System.Drawing.Size(46, 13);
            this.LBtimer.TabIndex = 1;
            this.LBtimer.Text = "LBTimer";
            // 
            // RBUhrTimer
            // 
            this.RBUhrTimer.AutoSize = true;
            this.RBUhrTimer.Checked = true;
            this.RBUhrTimer.Location = new System.Drawing.Point(6, 19);
            this.RBUhrTimer.Name = "RBUhrTimer";
            this.RBUhrTimer.Size = new System.Drawing.Size(89, 17);
            this.RBUhrTimer.TabIndex = 3;
            this.RBUhrTimer.TabStop = true;
            this.RBUhrTimer.Text = "Millisekunden";
            this.RBUhrTimer.UseVisualStyleBackColor = true;
            // 
            // RBprozentTimer
            // 
            this.RBprozentTimer.AutoSize = true;
            this.RBprozentTimer.Location = new System.Drawing.Point(6, 42);
            this.RBprozentTimer.Name = "RBprozentTimer";
            this.RBprozentTimer.Size = new System.Drawing.Size(61, 17);
            this.RBprozentTimer.TabIndex = 4;
            this.RBprozentTimer.Text = "Prozent";
            this.RBprozentTimer.UseVisualStyleBackColor = true;
            // 
            // GBTimererschreinung
            // 
            this.GBTimererschreinung.Controls.Add(this.RBUhrTimer);
            this.GBTimererschreinung.Controls.Add(this.RBprozentTimer);
            this.GBTimererschreinung.Location = new System.Drawing.Point(209, 103);
            this.GBTimererschreinung.Name = "GBTimererschreinung";
            this.GBTimererschreinung.Size = new System.Drawing.Size(200, 69);
            this.GBTimererschreinung.TabIndex = 5;
            this.GBTimererschreinung.TabStop = false;
            this.GBTimererschreinung.Text = "Anzeigemodus";
            // 
            // TBtime
            // 
            this.TBtime.Location = new System.Drawing.Point(38, 56);
            this.TBtime.Mask = "##:##:##";
            this.TBtime.Name = "TBtime";
            this.TBtime.Size = new System.Drawing.Size(100, 20);
            this.TBtime.TabIndex = 6;
            // 
            // FRMkonfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 277);
            this.Controls.Add(this.TBtime);
            this.Controls.Add(this.GBTimererschreinung);
            this.Controls.Add(this.LBtimer);
            this.Controls.Add(this.BSFLstart);
            this.Name = "FRMkonfig";
            this.Text = "Timer (Version 0.3)";
            this.GBTimererschreinung.ResumeLayout(false);
            this.GBTimererschreinung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BSFLstart;
        private System.Windows.Forms.Label LBtimer;
        private System.Windows.Forms.RadioButton RBUhrTimer;
        private System.Windows.Forms.RadioButton RBprozentTimer;
        private System.Windows.Forms.GroupBox GBTimererschreinung;
        private System.Windows.Forms.MaskedTextBox TBtime;
    }
}

