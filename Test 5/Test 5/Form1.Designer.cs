namespace Test_5
{
    partial class firmTimeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(50, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 45);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";

            // firmTimeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.lblTime);
            this.Name = "firmTimeForm";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.firmTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
