﻿using System.Windows;
using WPFTutorial.ViewModel;

namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainWindowViewModel vm = new MainWindowViewModel();
        DataContext = vm;
    }
}