﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GitDemo
{
	/// <summary>
	/// Interaction logic for SecondWindow.xaml
	/// </summary>
	public partial class SecondWindow : Window
	{
		public SecondWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Hello there! This is a Git Demo!!");
		}
	}
}
