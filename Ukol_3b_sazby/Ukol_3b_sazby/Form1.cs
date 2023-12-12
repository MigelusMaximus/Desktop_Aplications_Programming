using System;
using System.Windows.Forms;

namespace Ukol_3b_sazby
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


            taxRateComboBox.Items.Add("10%");
            taxRateComboBox.Items.Add("15%");
            taxRateComboBox.Items.Add("20%");


            taxRateComboBox.SelectedIndexChanged += new EventHandler(taxRateComboBox_SelectedIndexChanged);
            confirmButton.Click += new EventHandler(confirmButton_Click);
        }
        private void selectedTaxRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void taxRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zobrazení vybrané sazby daně
            selectedTaxRateLabel.Text = "Vybraná sazba daně: " + taxRateComboBox.SelectedItem.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Akce pre tlacitko, v pripade, ze by sme potrebovali so sadzbou nieco dalej robit

        }
    }
}
