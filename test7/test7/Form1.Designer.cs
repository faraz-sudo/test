namespace ColorChangingTextBoxApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtSample = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSample2 = new System.Windows.Forms.TextBox();
            this.txtSample3 = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtSample
            this.txtSample.Location = new System.Drawing.Point(50, 80);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(200, 20);
            this.txtSample.TabIndex = 0;
            this.txtSample.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtSample.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hover over me!";

            // txtSample2
            this.txtSample2.Location = new System.Drawing.Point(50, 120);
            this.txtSample2.Name = "txtSample2";
            this.txtSample2.Size = new System.Drawing.Size(200, 20);
            this.txtSample2.TabIndex = 2;
            this.txtSample2.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtSample2.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);

            // txtSample3
            this.txtSample3.Location = new System.Drawing.Point(50, 160);
            this.txtSample3.Name = "txtSample3";
            this.txtSample3.Size = new System.Drawing.Size(200, 20);
            this.txtSample3.TabIndex = 3;
            this.txtSample3.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtSample3.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);

            // lblInstructions
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(30, 200);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(240, 13);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Move your mouse over the text boxes to see the effect!";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtSample3);
            this.Controls.Add(this.txtSample2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSample);
            this.Name = "Form1";
            this.Text = "Color Changing TextBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSample2;
        private System.Windows.Forms.TextBox txtSample3;
        private System.Windows.Forms.Label lblInstructions;
    }
}