using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyPressDetector
{
    public partial class Form1 : Form
    {
        private Color currentTextColor = SystemColors.ControlText;
        private string colorMode = "Normal";

        public Form1()
        {
            InitializeComponent();

            // Subscribe to key events
            this.KeyDown += Form1_KeyDown;
            this.KeyPress += Form1_KeyPress;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle special keys like Arrow keys, Function keys, etc.
            HandleSpecialKeys(e);

            // Update key information
            UpdateKeyInfo(e);

            // Handle color changing keys
            HandleColorKeys(e);

            // Prevent system beep for certain keys
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle regular character keys
            lblPressedKey.Text = $"Key: {e.KeyChar}";
            lblPressedKey.ForeColor = currentTextColor;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Reset arrow display when key is released
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                lblArrowStatus.Visible = false;
            }

            // Reset on Escape key
            if (e.KeyCode == Keys.Escape)
            {
                ResetToDefault();
            }
        }

        private void HandleSpecialKeys(KeyEventArgs e)
        {
            // Handle arrow keys specifically
            switch (e.KeyCode)
            {
                case Keys.Up:
                    lblArrowStatus.Text = "↑ UP ARROW";
                    lblArrowStatus.Visible = true;
                    lblPressedKey.Text = "UP ARROW";
                    break;

                case Keys.Down:
                    lblArrowStatus.Text = "↓ DOWN ARROW";
                    lblArrowStatus.Visible = true;
                    lblPressedKey.Text = "DOWN ARROW";
                    break;

                case Keys.Left:
                    lblArrowStatus.Text = "← LEFT ARROW";
                    lblArrowStatus.Visible = true;
                    lblPressedKey.Text = "LEFT ARROW";
                    break;

                case Keys.Right:
                    lblArrowStatus.Text = "→ RIGHT ARROW";
                    lblArrowStatus.Visible = true;
                    lblPressedKey.Text = "RIGHT ARROW";
                    break;

                case Keys.Enter:
                    lblPressedKey.Text = "ENTER";
                    break;

                case Keys.Space:
                    lblPressedKey.Text = "SPACE";
                    break;

                case Keys.Tab:
                    lblPressedKey.Text = "TAB";
                    break;

                case Keys.Back:
                    lblPressedKey.Text = "BACKSPACE";
                    break;

                case Keys.Delete:
                    lblPressedKey.Text = "DELETE";
                    break;
            }
        }

        private void HandleColorKeys(KeyEventArgs e)
        {
            // Change text color based on key presses
            switch (e.KeyCode)
            {
                case Keys.R:
                    currentTextColor = Color.Red;
                    colorMode = "Red";
                    break;

                case Keys.G:
                    currentTextColor = Color.Green;
                    colorMode = "Green";
                    break;

                case Keys.B:
                    currentTextColor = Color.Blue;
                    colorMode = "Blue";
                    break;

                case Keys.Y:
                    currentTextColor = Color.Gold;
                    colorMode = "Yellow";
                    break;

                case Keys.P:
                    currentTextColor = Color.Purple;
                    colorMode = "Purple";
                    break;

                case Keys.W:
                    currentTextColor = SystemColors.ControlText;
                    colorMode = "Normal";
                    break;
            }

            // Apply the color change
            lblPressedKey.ForeColor = currentTextColor;
            lblColorStatus.Text = $"Color Mode: {colorMode} (Press R, G, B, Y, P, W)";
        }

        private void UpdateKeyInfo(KeyEventArgs e)
        {
            // Display detailed key information
            lblKeyInfo.Text = $"Key Code: {e.KeyCode} | Key Data: {e.KeyData} | " +
                             $"Key Value: {(int)e.KeyValue} | Modifiers: {e.Modifiers}";
        }

        private void ResetToDefault()
        {
            // Reset everything to default state
            lblPressedKey.Text = "Press Any Key";
            lblPressedKey.ForeColor = SystemColors.ControlText;
            lblArrowStatus.Visible = false;
            currentTextColor = SystemColors.ControlText;
            colorMode = "Normal";
            lblColorStatus.Text = "Color Mode: Normal (Press R, G, B, Y, P, W)";
            lblKeyInfo.Text = "Key Code: | Key Data: | Key Value: | Modifiers:";
        }

        // Optional: Handle form load to set focus properly
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Focus();
        }

        // Ensure form can receive key events even when controls have focus
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // This helps capture arrow keys even when other controls might interfere
            if (keyData == Keys.Up || keyData == Keys.Down ||
                keyData == Keys.Left || keyData == Keys.Right)
            {
                // Let the normal key events handle it
                return false;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}