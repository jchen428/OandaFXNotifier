using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OandaRest;
using OandaRest.TradeLibrary.DataTypes;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private bool _enabled;
        private List<Instrument> _instruments;

        public Form1()
        {
            InitializeComponent();
            populateInstruments();
        }

        private async void populateInstruments()
        {
            Credentials creds = Credentials.getDefaultCredentials();
            _instruments = await Rest.getInstrumentsAsync(creds.defaultAccountId);

            foreach (var instrument in _instruments)
                comboBoxInstruments.Items.Add(instrument.displayName);

            comboBoxInstruments.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(textBoxPrice.Text, out price) && comboBoxInstruments.SelectedItem != null)
            {
                labelInvalid.Visible = false;
                groupBox.Enabled = _enabled;
                panel.Enabled = _enabled;
                _enabled = !_enabled;

                if (_enabled)
                {
                    button.Text = "Disable";
                    labelInfo.Text = "Notifications are enabled";
                    StreamRates.startStream(price, comboBoxInstruments.SelectedIndex);
                }
                else
                {
                    button.Text = "Enable";
                    labelInfo.Text = "Notifications are disabled";
                    StreamRates.stopStream();
                }
            }
            else
            {
                labelInvalid.Visible = true;
            }
            StreamRates.sendNotification();
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
                StreamRates.setMode(rb.Text.ToUpper());
                Console.WriteLine(rb.Text.ToUpper() + " selected");
            }
        }

        private void comboBoxInstruments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Instrument selected = _instruments[comboBoxInstruments.SelectedIndex];
            StreamRates.setInstrument(selected);
            Console.WriteLine(selected.displayName + " selected");
        }
    }
}
