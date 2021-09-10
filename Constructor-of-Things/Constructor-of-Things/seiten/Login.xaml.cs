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


namespace Constructor_of_Things
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login1 : Window
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            seiten.main_page main_Page = new seiten.main_page();
            main_Page.Show();
            this.Close();
        }

        private void REGISTRIEREN_Click(object sender, RoutedEventArgs e)
        {
            seiten.registrierung registrierung = new seiten.registrierung();
            registrierung.Show();
            
        }

        private void SCHLISSEN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtb_Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtb_Username.Text.Length == 0)
            {
                lbl_username.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_username.Visibility = Visibility.Hidden;
            }
        }

        private void txtb_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtb_Password.Password.Length == 0)
            {
                lbl_Passwort.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_Passwort.Visibility = Visibility.Hidden;
            }
        }
    }
}
