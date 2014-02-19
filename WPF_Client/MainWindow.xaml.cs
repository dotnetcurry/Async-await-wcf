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

namespace WPF_Client
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

        private async void btnGetEmployees_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Data is Not Received Yet....";
            MyRef.ServiceClient Proxy = new MyRef.ServiceClient();

            var Result = await Proxy.GetEmployeesAsync();
            dgEmp.ItemsSource = Result;
            txtInfo.Text = "Data Received....";
        }
    }
}
