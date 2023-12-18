using Microsoft.Win32;
using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDiaog = new OpenFileDialog();
            fileDiaog.Filter = "C# Source Files | *.cs";
            fileDiaog.InitialDirectory = "C:\\Work\\Codes\\HMI\\VS\\WPF_Tutorials\\Ep10\\WPFTutorial";
            fileDiaog.Title = "Please pick a CS Source file(s)...";
            fileDiaog.Multiselect = true;

            bool? success = fileDiaog.ShowDialog();
            if(success == true)
            {
                string[] path = fileDiaog.FileNames;
                string[] fileName = fileDiaog.SafeFileNames;
                
                tbInfo.Text = fileName[fileName.Length - 1];
            }
            else
            {

            }

        }
    }
}