using System.Windows;
using WinForms = System.Windows.Forms;

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

    private void btnFire_Click(object sender, RoutedEventArgs e)
    {
        WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
        dialog.InitialDirectory = "C:\\Work\\Codes\\HMI\\VS\\WPF_Tutorials\\Ep11";
        WinForms.DialogResult result = dialog.ShowDialog();

        if(result == WinForms.DialogResult.OK)
        { 
            string folder = dialog.SelectedPath;
        }

    }
}