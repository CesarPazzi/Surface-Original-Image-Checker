using Microsoft.Win32;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Surface_Original_Image_Checker
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Surface\OSImage";
            string valueName = "ImageProductName";
            // RegistryKey SurfaceImageCheck = Registry.LocalMachine.OpenSubKey(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Surface\OSImage", true);
            if (Registry.GetValue(keyName, valueName, null) == null)
            {
                Estado.Content = "FAIL";
            }
            else
            {
                Estado.Content = "OK";
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            about window_about = new about();
            window_about.ShowDialog();
        }
    }
}
