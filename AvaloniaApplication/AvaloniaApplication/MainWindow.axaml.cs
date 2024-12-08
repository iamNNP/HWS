using Avalonia.Controls;

namespace AvaloniaApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Circle circle = new Circle(5, 5);
        }
    }
}