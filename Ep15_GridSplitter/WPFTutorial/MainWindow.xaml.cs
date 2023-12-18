using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void myGridSplitter_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        myGridSplitter.Background = Brushes.White;
    }

    private void myGridSplitter_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        myGridSplitter.Background = Brushes.Gray;
    }
}