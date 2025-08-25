using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperation.SelectedIndex = 0; // Select first operation by default
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous error message
            lblError.Text = "";
            lblError.Visible = false;

            try
            {
                // Validate and parse first number
                if (!double.TryParse(txtNumber1.Text, out double number1))
                {
                    throw new FormatException("First number must be a valid numeric value.");
                }

                // Validate and parse second number
                if (!double.TryParse(txtNumber2.Text, out double number2))
                {
                    throw new FormatException("Second number must be a valid numeric value.");
                }

                // Check for negative numbers
                if (number1 < 0)
                {
                    throw new ArgumentException("First number cannot be negative.");
                }

                if (number2 < 0)
                {
                    throw new ArgumentException("Second number cannot be negative.");
                }

                // Perform calculation based on selected operation
                double result = 0;
                string operation = cmbOperation.SelectedItem.ToString();

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        result = number1 / number2;
                        break;
                }

                // Display result
                lblResult.Text = $"Result: {result}";
            }
            catch (FormatException ex)
            {
                ShowError($"Input Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                ShowError($"Validation Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                ShowError($"Math Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                ShowError($"Unexpected Error: {ex.Message}");
            }
        }

        private void ShowError(string errorMessage)
        {
            lblError.Text = errorMessage;
            lblError.Visible = true;
            lblResult.Text = "Result: Error";
        }
    }
}