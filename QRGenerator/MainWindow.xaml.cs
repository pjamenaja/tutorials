using System;
using System.Windows;

namespace QRGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtPromptPayID.Text = "3100600229665";
            txtAmount.Text = "1000";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uctlQRGenerator.GenerateQR();
        }
    }
}
