using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// A Currency Conversion calculator.
	/// </summary>
	public sealed partial class currencyConversion : Page
	{
		const double USD_EUR = 0.85189982, USD_GBP = 0.72872436, USD_INR = 74.257327, EUR_USD = 1.1739732, EUR_GBP = 0.8556672, EUR_INR = 87.00755, GPB_USD = 1.371907, GPB_EUR = 1.1686692, GPB_INR = 101.68635, INR_USD = 0.011492628, INR_EUR = 0.013492774, INR_GBP = 0.0098339397;
		double value, conversion;
		string selection1, selection2;
		private async void calcButton_Click(object sender, RoutedEventArgs e)
		{
			double result;
			
// Changing empty amount box to '0'
			if (amountTextBox.Text == "")
			{
				amountTextBox.Text = "0";
			}
			// converting amountTextBox text to double
			try
			{
				value = double.Parse(amountTextBox.Text);
			}
			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error: Amount must be a valid decimal number." + theException);
				await dialogMessage.ShowAsync();
				amountTextBox.Focus(FocusState.Programmatic);
				return;
			}
			if (value < 0)
			{
				var dialogMessage = new MessageDialog("Error: Amount must be greater than 0.");
				await dialogMessage.ShowAsync();
				amountTextBox.Focus(FocusState.Programmatic);
				return;
			}
			// Converts currency using convertCurrency function.
			conversion = convertCurrency(value);
			result = conversion * value;
			// Outputs result as readable text in the resultText block.
			string resultText = value + " " + selection1 + " " + "Equals: " + result + " " + selection2;
			resultTextBlock.Text = resultText;
		}

		public currencyConversion()
		{
			this.InitializeComponent();
		}

		private double convertCurrency(double conversion)
		{
			if (fromComboBox.SelectedIndex is 0 == true && toComboBox.SelectedIndex is 1 == true)
			{
				conversion = USD_EUR;
				selection1 = "US Dollars";
				selection2 = "Euros";
			}
			if (fromComboBox.SelectedIndex is 0 == true && toComboBox.SelectedIndex is 2 == true)
			{
				conversion = USD_GBP;
				selection1 = "US Dollars";
				selection2 = "Great British Pounds";
			}
			if (fromComboBox.SelectedIndex is 0 == true && toComboBox.SelectedIndex is 3 == true)
			{
				conversion = USD_INR;
				selection1 = "US Dollars";
				selection2 = "Indian Rupees";
			}
			if (fromComboBox.SelectedIndex is 1 == true && toComboBox.SelectedIndex is 0 == true)
			{
				conversion = EUR_USD;
				selection1 = "Euros";
				selection2 = "US Dollars";
			}
			if (fromComboBox.SelectedIndex is 1 == true && toComboBox.SelectedIndex is 2 == true)
			{
				conversion = EUR_GBP;
				selection1 = "Euros";
				selection2 = "Great British Pounds";
			}
			if (fromComboBox.SelectedIndex is 1 == true && toComboBox.SelectedIndex is 3 == true)
			{
				conversion = EUR_INR;
				selection1 = "Euros";
				selection2 = "Indian Rupees";
			}
			if (fromComboBox.SelectedIndex is 2 == true && toComboBox.SelectedIndex is 0 == true)
			{
				conversion = GPB_USD;
				selection1 = "Great British Pounds";
				selection2 = "US Dollars";
			}
			if (fromComboBox.SelectedIndex is 2 == true && toComboBox.SelectedIndex is 1 == true)
			{
				conversion = GPB_EUR;
				selection1 = "Great British Pounds";
				selection2 = "Euros";
			}
			if (fromComboBox.SelectedIndex is 2 == true && toComboBox.SelectedIndex is 3 == true)
			{
				conversion = GPB_INR;
				selection1 = "Great British Pounds";
				selection2 = "Indian Rupees";
			}
			if (fromComboBox.SelectedIndex is 3 == true && toComboBox.SelectedIndex is 0 == true)
			{
				conversion = INR_USD;
				selection1 = "Indian Rupees";
				selection2 = "US Dollars";
			}
			if (fromComboBox.SelectedIndex is 3 == true && toComboBox.SelectedIndex is 1 == true)
			{
				conversion = INR_EUR;
				selection1 = "Indian Rupees";
				selection2 = "Euros";
			}
			if (fromComboBox.SelectedIndex is 3 == true && toComboBox.SelectedIndex is 2 == true)
			{
				conversion = INR_GBP;
				selection1 = "Indian Rupees";
				selection2 = "Great British Pounds";
			}
			return conversion;
		}

	}
	
}
