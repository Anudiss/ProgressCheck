using ProgressCheck.DatabaseConnection;
using System.Linq;
using System.Net.Configuration;
using System.Windows;
using System.Windows.Controls;

namespace ProgressCheck.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        #region Error message
        public string ErrorMessage
        {
            get { return (string)GetValue(ErrorMessageProperty); }
            set { SetValue(ErrorMessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ErrorMessage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ErrorMessageProperty =
            DependencyProperty.Register("ErrorMessage", typeof(string), typeof(RegisterPage), new PropertyMetadata(string.Empty));
        #endregion

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, RoutedEventArgs e) =>
            MainWindow.Instance.PageContainer.Navigate(new LoginPage());

        private void OnRegisterClick(object sender, RoutedEventArgs e)
        {
            string login = LoginField.Text.Trim();
            string password = PasswordField.Password.Trim();

            if (login == string.Empty)
            {
                ErrorMessage = "Логин не может быть пустым";
                return;
            }

            if (Connection.Entities.User.Any(user => user.Login == login))
            {
                ErrorMessage = "Пользователь с таким логином уже есть";
                return;
            }

            User authorizatedUser = new User()
            {
                Login = login,
                Password = password,
                Role_ID = 2
            };
            Connection.Entities.User.Add(authorizatedUser);
            Connection.Entities.SaveChanges();

            MainWindow.AuthorizatedUser = authorizatedUser;
            MainWindow.Instance.UpdateUserData();
        }
    }
}
