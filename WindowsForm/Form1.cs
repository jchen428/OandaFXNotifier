using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private string selection;
        private bool enabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(textBoxPrice.Text, out price))
            {
                labelInvalid.Visible = false;
                groupBox.Enabled = enabled;
                panel.Enabled = enabled;
                enabled = !enabled;

                if (enabled)
                {
                    button.Text = "Disable";
                    labelInfo.Text = "Notifications are enabled";
                }
                else
                {
                    button.Text = "Enable";
                    labelInfo.Text = "Notifications are disabled";
                }
            }
            else
            {
                labelInvalid.Visible = true;
            }
        }

        private void radioCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null)
            {
                Console.WriteLine("sender is not a RadioButton");
                return;
            }

            if (rb.Checked)
            {
                selection = rb.Text.ToUpper();
                Console.WriteLine(selection + " selected");
            }
        }
    }
}
