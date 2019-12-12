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
using System.Windows.Shapes;

namespace Surface_Original_Image_Checker
{
    /// <summary>
    /// Interaction logic for about.xaml
    /// </summary>
    public partial class about : Window
    {
        private void Hyperlink_Click(object sender, RoutedEventArgs e)

        {

            // open URL

            Hyperlink source = sender as Hyperlink;

            if (source != null)

            {

                System.Diagnostics.Process.Start(source.NavigateUri.ToString());

            }

        }
        public about()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
