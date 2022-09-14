using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class mortgage_Calculator : Page
	{
		public mortgage_Calculator()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			double P = double.Parse(PrincipalBorrowBox.Text);
			double M;
			double y_rate = double.Parse(YearlyInterestRateBox.Text);
			double n;
			double Years = double.Parse(YearsBox.Text);
			double Months = double.Parse(MonthsBox.Text);
			double i = (y_rate/100) / 12;
			MonthlyRepaymentBox.Text = i.ToString();
			n = (Years/12) + Months;
			M = P * (i * Math.Pow((1 + i), n))/ Math.Pow((1 + i), n) - 1;

			MonthlyInterestRateBox.Text = i.ToString();
			MonthlyRepaymentBox.Text = M.ToString();

		}

		private void back_Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(newNavigationPage), null);
		}
	}
}
