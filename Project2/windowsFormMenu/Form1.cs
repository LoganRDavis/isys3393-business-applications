using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace windowsFormMenu
{
    public partial class Form1 : Form
    {
        string username;
        const double fruitSaladPrice = 9.95;
        const double pastaSaladPrice = 12.0;
        const double smoothiePrice = 4.95;
        const double fruitJuicePrice = 3.95;
        const double cupcakePrice = 3.0;
        const double shortcakePrice = 6.0;

        public Form1()
        {
            InitializeComponent();
            username = Interaction.InputBox("Enter your name.", "Customer's Name", "MyName", -1, -1);
        }

        private void fruitSaladRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            saladPriceText.Text = fruitSaladPrice.ToString("C");
            saladSelectionLabel.Text = "Salads Selection: Fruit Salad";
            saladQuantityInput.Focus();
            saladSelectionLabel.Show();
        }

        private void pastaSaladRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            saladPriceText.Text = pastaSaladPrice.ToString("C");
            saladSelectionLabel.Text = "Salads Selection: Pasta Salad";
            saladQuantityInput.Focus();
            saladSelectionLabel.Show();
        }

        private void smoothieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            drinkPriceText.Text = smoothiePrice.ToString("C");
            drinkSelectionLabel.Text = "Drinks Selection: Smoothie";
            drinkQuantityInput.Focus();
            drinkSelectionLabel.Show();
        }

        private void fruitJuiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            drinkPriceText.Text = fruitJuicePrice.ToString("C");
            drinkSelectionLabel.Text = "Drinks Selection: Fruit Juice";
            drinkQuantityInput.Focus();
            drinkSelectionLabel.Show();
        }

        private void cupcakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dessertPriceText.Text = cupcakePrice.ToString("C");
            dessertsSelectionLabel.Text = "Desserts Selection: Cupcake";
            dessertQuantityInput.Focus();
            dessertsSelectionLabel.Show();
        }

        private void shortcakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dessertPriceText.Text = shortcakePrice.ToString("C");
            dessertsSelectionLabel.Text = "Desserts Selection: Shortcake";
            dessertQuantityInput.Focus();
            dessertsSelectionLabel.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fruitSaladRadioButton.Checked = false;
            pastaSaladRadioButton.Checked = false;
            smoothieRadioButton.Checked = false;
            fruitJuiceRadioButton.Checked = false;
            cupcakeRadioButton.Checked = false;
            shortcakeRadioButton.Checked = false;
            outputMessage.Text = "";
            saladPriceText.Text = "0";
            saladQuantityInput.Text = "0";
            drinkPriceText.Text = "0";
            drinkQuantityInput.Text = "0";
            dessertPriceText.Text = "0";
            dessertQuantityInput.Text = "0";
            saladSelectionLabel.Hide();
            drinkSelectionLabel.Hide();
            dessertsSelectionLabel.Hide();
            calculateButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double saladPrice = double.Parse(saladPriceText.Text.Replace("$", String.Empty));
            int saladQuantity = Math.Abs(int.Parse(saladQuantityInput.Text));
            double drinkPrice = double.Parse(drinkPriceText.Text.Replace("$", String.Empty));
            int drinkQuantity = Math.Abs(int.Parse(drinkQuantityInput.Text));
            double dessertPrice = double.Parse(dessertPriceText.Text.Replace("$", String.Empty));
            int dessertQuantity = Math.Abs(int.Parse(dessertQuantityInput.Text));

            double totalAmount = saladQuantity * saladPrice + drinkQuantity * drinkPrice + dessertQuantity * dessertPrice;
            int totalQuantity = saladQuantity + drinkQuantity + dessertQuantity;
            outputMessage.Text = "The total sales was " + totalAmount.ToString("C") + "\n" +
                "The total items sold were " + totalQuantity + "\n" +
                username + ", thank you for your purchase.";
        }
    }
}
