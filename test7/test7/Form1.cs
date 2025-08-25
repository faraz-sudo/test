using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorChangingTextBoxApp
{
    public partial class Form1 : Form
    {
        // Colors for different states
        private readonly Color NormalColor = SystemColors.Window;
        private readonly Color HoverColor = Color.LightYellow;
        private readonly Color LeaveColor = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();

            // Set initial colors
            SetAllTextBoxColors(NormalColor);
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            // Change background color when mouse enters
            if (sender is TextBox textBox)
            {
                textBox.BackColor = HoverColor;
                textBox.ForeColor = Color.DarkBlue;

                // Optional: Add a border effect
                textBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            // Restore original color when mouse leaves
            if (sender is TextBox textBox)
            {
                textBox.BackColor = LeaveColor;
                textBox.ForeColor = SystemColors.WindowText;

                // Optional: Restore border style
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // Helper method to set all textbox colors
        private void SetAllTextBoxColors(Color color)
        {
            txtSample.BackColor = color;
            txtSample2.BackColor = color;
            txtSample3.BackColor = color;
        }

        // Optional: Handle form load to set initial properties
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set some additional properties for better visual effect
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Text = "Hover over me!";
                    textBox.ReadOnly = true; // Make them read-only for demonstration
                    textBox.Cursor = Cursors.Hand; // Change cursor to hand
                }
            }
        }
    }
}