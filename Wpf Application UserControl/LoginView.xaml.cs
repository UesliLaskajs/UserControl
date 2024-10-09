using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Application_UserControl
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginClicked(object sender, RoutedEventArgs e)//After The Event Method is Triggered 
        {
            Window window = Window.GetWindow(this);//We Get The Window Of the Current Object wich is The LoginView In This Case
            window.Content = new UserInvoice(); //Than we Replace that window with the UserInvoice View on Event Triggered
        }
    }
}
