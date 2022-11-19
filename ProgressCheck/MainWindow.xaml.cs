using ProgressCheck.DatabaseConnection;
using System.Windows;

namespace ProgressCheck
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static User AuthorizatedUser { get; set; }
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;
        }

        public void UpdateUserData()
        {
            PageContainer.Navigate(new ContentPage.ContentPage());
        }
    }
}
