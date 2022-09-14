﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class newNavigationPage : Page
	{
		public newNavigationPage()
		{
			this.InitializeComponent();
		}

		private void calculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage), null);
		}

		private void function2Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(currencyConversion), null);
		}

		private void function1Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mortgage_Calculator), null);
		}

		private async void tripButton_Click(object sender, RoutedEventArgs e)
		{
			var dialogMessage = new MessageDialog("This feature is yet to be added.");
			await dialogMessage.ShowAsync();
		}
	}
}
