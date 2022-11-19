using ProgressCheck.DatabaseConnection;
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

namespace ProgressCheck.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        #region Error message
        public string ErrorMessage
        {
            get { return (string)GetValue(ErrorMessageProperty); }
            set { SetValue(ErrorMessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ErrorMessage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ErrorMessageProperty =
            DependencyProperty.Register("ErrorMessage", typeof(string), typeof(LoginPage), new PropertyMetadata(string.Empty));
        #endregion

        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            string login = LoginField.Text.Trim();
            string password = PasswordField.Password.Trim();

            if (login == string.Empty || password == string.Empty)
            {
                ErrorMessage = "Логин или пароль не могут быть пустыми";
                return;
            }

            User authorizatedUser = Connection.Entities.User.FirstOrDefault(user => user.Login == login &&
                                                                                    user.Password == password);
            if (authorizatedUser == default(User))
            {
                ErrorMessage = "Неверный логин или пароль";
                return;
            }

            MainWindow.AuthorizatedUser = authorizatedUser;
            MainWindow.Instance.UpdateUserData();
        }

        private void OnRegisterClick(object sender, RoutedEventArgs e) =>
            MainWindow.Instance.PageContainer.Navigate(new RegisterPage());
    }
}
