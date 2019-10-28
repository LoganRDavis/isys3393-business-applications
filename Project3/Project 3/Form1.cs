using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class form : Form
    {
        private double? menuChoicePrice = null;
        private double? sauceChoicePrice = null;
        private double? sideChoicePrice = null;
        private String[] sauceChoiceNames = {"Drawn Butter", "Aioli", "Garlic", "Hollandaise", "Remoulade"};
        private double[] sauceChoicePrices = {1.00, 2.50, 1.50, 3.00, 2.50};
        private String[] sideChoiceNames = { "Brussels Sprouts", "Butternut Squash", "Macaroni Salad", "Roasted Broccoli" };
        private double[] sideChoicePrices = {3.00, 4.00, 2.50, 2.00};

        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            currentDateText.Text = DateTime.Now.ToString("D");
            numberOfGuestsInput.Focus();
            saucesDropdown.Items.AddRange(this.sauceChoiceNames);
            sidesDropdown.Items.AddRange(this.sideChoiceNames);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void steakOption_CheckedChanged(object sender, EventArgs e)
        {
            if (steakOption.Checked) {
                this.menuChoicePrice = 30.95;
            }
        }

        private void chickenOption_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenOption.Checked) {
                this.menuChoicePrice = 19.95;
            }
        }

        private void pastaOption_CheckedChanged(object sender, EventArgs e)
        {
            if (pastaOption.Checked) {
                this.menuChoicePrice = 14.95;
            }
        }

        private void saucesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = saucesDropdown.SelectedIndex;
            if (index >= 0) {
                this.sauceChoicePrice = this.sauceChoicePrices[index];
            }
        }

        private void sidesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = sidesDropdown.SelectedIndex;
            if (index >= 0) {
                this.sideChoicePrice = this.sideChoicePrices[index];
            }
        }

        private double getTotalAmount()
        {
            int numberOfGuests;
            if (int.TryParse(numberOfGuestsInput.Text, out numberOfGuests))
            {
                double totalAmount = 0.0;
                if (this.menuChoicePrice != null)
                {
                    totalAmount += (double)this.menuChoicePrice * numberOfGuests;
                }
                if (this.sauceChoicePrice != null)
                {
                    totalAmount += (double)this.sauceChoicePrice * numberOfGuests;
                }
                if (this.sideChoicePrice != null)
                {
                    totalAmount += (double)this.sideChoicePrice * numberOfGuests;
                }
                if (openBarOption.Checked)
                {
                    totalAmount += 25.0 * numberOfGuests;
                }
                if (wineOption.Checked)
                {
                    totalAmount += 8.0 * numberOfGuests;
                }
                amountDue.Text = totalAmount.ToString("C");
                return totalAmount;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please Enter A Valid Number Of Guests.", "Hodge's Catering",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return -1;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            getTotalAmount();
        }

        private void clearInputs()
        {
            this.menuChoicePrice = null;
            this.sauceChoicePrice = null;
            this.sideChoicePrice = null;
            steakOption.Checked = false;
            chickenOption.Checked = false;
            pastaOption.Checked = false;
            saucesDropdown.SelectedIndex = -1;
            sidesDropdown.SelectedIndex = -1;
            openBarOption.Checked = false;
            wineOption.Checked = false;
            amountDue.Text = "";
            numberOfGuestsInput.Text = "";
            numberOfGuestsInput.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void summary_Click(object sender, EventArgs e)
        {
            double totalAmount = getTotalAmount();
            if (totalAmount >= 0)
            {
                int numberOfGuests = int.Parse(numberOfGuestsInput.Text);
                String summaryText = "Total Events: 1\n" +
                    "Total Guests: " + numberOfGuests.ToString() + "\n" +
                    "Total Amount Due: " + totalAmount.ToString("C") + "\n\n" +
                    "Would you like to clear the summary information?";
                if (System.Windows.Forms.MessageBox.Show(summaryText, "Hodge's Catering", 
                    System.Windows.Forms.MessageBoxButtons.YesNo, 
                    System.Windows.Forms.MessageBoxIcon.Information) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    clearInputs();
                }
            }
        }
    }
}
