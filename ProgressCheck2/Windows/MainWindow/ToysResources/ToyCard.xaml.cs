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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressCheck2.Windows.MainWindow.ToysResources
{
    /// <summary>
    /// Логика взаимодействия для ToyCard.xaml
    /// </summary>
    public partial class ToyCard : UserControl
    {
        #region Toy
        public Toy Toy
        {
            get { return (Toy)GetValue(ToyProperty); }
            set { SetValue(ToyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Toy.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToyProperty =
            DependencyProperty.Register("Toy", typeof(Toy), typeof(ToyCard));
        #endregion

        public ToyCard()
        {
            InitializeComponent();
        }
    }
}
