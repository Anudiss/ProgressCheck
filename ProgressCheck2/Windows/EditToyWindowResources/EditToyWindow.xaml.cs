using ProgressCheck2.DatabaseConnection;
using System.Windows;

namespace ProgressCheck2.Windows.EditToyWindowResources
{
    /// <summary>
    /// Логика взаимодействия для EditToyWindow.xaml
    /// </summary>
    public partial class EditToyWindow : Window
    {
        #region Toy
        public Toy Toy
        {
            get { return (Toy)GetValue(ToyProperty); }
            set { SetValue(ToyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Toy.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToyProperty =
            DependencyProperty.Register("Toy", typeof(Toy), typeof(EditToyWindow));
        #endregion

        public EditToyWindow()
        {
            InitializeComponent();
        }
    }
}
