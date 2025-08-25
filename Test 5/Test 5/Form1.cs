using System;
using System.Threading;
using System.Windows.Forms;

namespace Test_5
{
    public partial class firmTimeForm : Form
    {
        public firmTimeForm()
        {
            InitializeComponent();
        }

        private void firmTimeForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(UpdateTime));
            t.IsBackground = true; // ensures thread closes when app closes
            t.Start();
        }

        private void UpdateTime()
        {
            while (true)
            {
                if (lblTime.InvokeRequired)
                {
                    lblTime.BeginInvoke((MethodInvoker)delegate
                    {
                        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); // 12-hour with AM/PM
                    });
                }
                Thread.Sleep(1000);
            }
        }
    }
}
