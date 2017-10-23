namespace Timer
{
    partial class FRMAnzeige
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
            this.LBanzeige = new System.Windows.Forms.Label();
            this.TimerAnzeige = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBanzeige
            // 
            this.LBanzeige.AutoSize = true;
            this.LBanzeige.Font = new System.Drawing.Font("DejaVu Sans Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBanzeige.ForeColor = System.Drawing.Color.Red;
            this.LBanzeige.Location = new System.Drawing.Point(12, 9);
            this.LBanzeige.Name = "LBanzeige";
            this.LBanzeige.Size = new System.Drawing.Size(110, 31);
            this.LBanzeige.TabIndex = 0;
            this.LBanzeige.Text = "label1";
            // 
            // TimerAnzeige
            // 
            this.TimerAnzeige.Interval = 1;
            this.TimerAnzeige.Tick += new System.EventHandler(this.TimerAnzeige_Tick);
            // 
            // FRMAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 43);
            this.Controls.Add(this.LBanzeige);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMAnzeige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Anzeige";
            this.Load += new System.EventHandler(this.FRMAnzeige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBanzeige;
        private System.Windows.Forms.Timer TimerAnzeige;
    }
}