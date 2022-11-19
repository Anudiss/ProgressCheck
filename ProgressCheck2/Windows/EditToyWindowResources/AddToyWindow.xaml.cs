using ProgressCheck2.DatabaseConnection;
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
using System.Windows.Shapes;

namespace ProgressCheck2.Windows.EditToyWindowResources
{
    /// <summary>
    /// Логика взаимодействия для AddToyWindow.xaml
    /// </summary>
    public partial class AddToyWindow : Window
    {


        public Toy Toy
        {
            get { return (Toy)GetValue(ToyProperty); }
            set { SetValue(ToyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToyProperty =
            DependencyProperty.Register("ToyProperty", typeof(Toy), typeof(AddToyWindow));



        public AddToyWindow()
        {
            InitializeComponent();

            Toy = new Toy();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            DatabaseContext.Entities.Toy.Add(Toy);
            DatabaseContext.Entities.SaveChanges();
            Close();
        }
    }
}
