using System;
using System.Data; // Used to evaluate mathematical expressions
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string input = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            input += button.Content.ToString();
            Display.Text = input;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            input = "";
            Display.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                input = new DataTable().Compute(input, null).ToString();
                Display.Text = input;
            }
            catch
            {
                Display.Text = "Error";
                input = "";
            }
        }
    }
}
