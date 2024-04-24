using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;

namespace AvaloniaApp
{
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void First_Button_Click(object sender, RoutedEventArgs e) {
            First_Button.Background = Brushes.White;
        }
        public void Second_Button_Click(object sender, RoutedEventArgs e) {
            Second_Button.Background = Brushes.Blue;
        }
        public void Third_Button_Click(object sender, RoutedEventArgs e) {
            Third_Button.Background = Brushes.Red;
        }
    }
}
