namespace Test4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TrackBar sldValue;
        private System.Windows.Forms.Label lblValue;

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
            this.sldValue = new System.Windows.Forms.TrackBar();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sldValue)).BeginInit();
            this.SuspendLayout();

            // sldValue
            this.sldValue.Location = new System.Drawing.Point(30, 30);
            this.sldValue.Maximum = 100;
            this.sldValue.Minimum = 0;
            this.sldValue.Name = "sldValue";
            this.sldValue.Size = new System.Drawing.Size(200, 45);
            this.sldValue.TabIndex = 0;
            this.sldValue.Value = 50;
            this.sldValue.Scroll += new System.EventHandler(this.sldValue_Scroll);

            // lblValue
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(30, 80);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(95, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value of Slider: 50";

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.sldValue);
            this.Controls.Add(this.lblValue);
            this.Name = "Form1";
            this.Text = "Slider Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sldValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
