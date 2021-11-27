using System;
using System.Diagnostics;
using System.Windows;

namespace MyAwesomeProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
#if DEBUG
            Debug.WriteLine("Hello from debug");
#endif
        }
    }
}
