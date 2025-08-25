namespace KeyPressDetector
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
            this.lblPressedKey = new System.Windows.Forms.Label();
            this.lblKeyInfo = new System.Windows.Forms.Label();
            this.lblArrowStatus = new System.Windows.Forms.Label();
            this.lblColorStatus = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblPressedKey
            this.lblPressedKey.AutoSize = true;
            this.lblPressedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressedKey.Location = new System.Drawing.Point(120, 50);
            this.lblPressedKey.Name = "lblPressedKey";
            this.lblPressedKey.Size = new System.Drawing.Size(160, 37);
            this.lblPressedKey.TabIndex = 0;
            this.lblPressedKey.Text = "Press Any Key";
            this.lblPressedKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblKeyInfo
            this.lblKeyInfo.AutoSize = true;
            this.lblKeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyInfo.Location = new System.Drawing.Point(50, 120);
            this.lblKeyInfo.Name = "lblKeyInfo";
            this.lblKeyInfo.Size = new System.Drawing.Size(300, 20);
            this.lblKeyInfo.TabIndex = 1;
            this.lblKeyInfo.Text = "Key Code: | Key Data: | Key Value: | Modifiers:";

            // lblArrowStatus
            this.lblArrowStatus.AutoSize = true;
            this.lblArrowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowStatus.Location = new System.Drawing.Point(150, 160);
            this.lblArrowStatus.Name = "lblArrowStatus";
            this.lblArrowStatus.Size = new System.Drawing.Size(100, 24);
            this.lblArrowStatus.TabIndex = 2;
            this.lblArrowStatus.Text = "↑ → ↓ ←";
            this.lblArrowStatus.Visible = false;

            // lblColorStatus
            this.lblColorStatus.AutoSize = true;
            this.lblColorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorStatus.Location = new System.Drawing.Point(50, 200);
            this.lblColorStatus.Name = "lblColorStatus";
            this.lblColorStatus.Size = new System.Drawing.Size(300, 20);
            this.lblColorStatus.TabIndex = 3;
            this.lblColorStatus.Text = "Color Mode: Normal (Press R, G, B, Y, P, W)";

            // lblInstructions
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(30, 240);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(340, 13);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Press R, G, B, Y, P, W for colors | Arrow keys for direction | ESC to reset";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblColorStatus);
            this.Controls.Add(this.lblArrowStatus);
            this.Controls.Add(this.lblKeyInfo);
            this.Controls.Add(this.lblPressedKey);
            this.KeyPreview = true; // Important: Allows form to receive key events first
            this.Name = "Form1";
            this.Text = "Key Press Detector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPressedKey;
        private System.Windows.Forms.Label lblKeyInfo;
        private System.Windows.Forms.Label lblArrowStatus;
        private System.Windows.Forms.Label lblColorStatus;
        private System.Windows.Forms.Label lblInstructions;
    }
}