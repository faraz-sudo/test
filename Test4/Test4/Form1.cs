using System;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Update label with current slider value
        private void UpdateLabel(int value)
        {
            lblValue.Text = $"Value of Slider: {value}";
        }

        // Scroll event handler
        private void sldValue_Scroll(object sender, EventArgs e)
        {
            UpdateLabel(sldValue.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the label text
            UpdateLabel(sldValue.Value);
        }
    }
}
