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

namespace ProgressCheck.UserControls
{
    /// <summary>
    /// Логика взаимодействия для PasswordField.xaml
    /// </summary>
    public partial class PasswordField : UserControl
    {
        #region Password
        public string Password => PasswordContainer.Password;
        #endregion
        #region LabelFontSize
        public int LabelFontSize
        {
            get { return (int)GetValue(LabelFontSizeProperty); }
            set { SetValue(LabelFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelFontSizeProperty =
            DependencyProperty.Register("LabelFontSize", typeof(int), typeof(PasswordField), new PropertyMetadata(14));
        #endregion
        #region Label font weight
        public FontWeight LabelFontWeight
        {
            get { return (FontWeight)GetValue(LabelFontWeightProperty); }
            set { SetValue(LabelFontWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelFontWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelFontWeightProperty =
            DependencyProperty.Register("LabelFontWeight", typeof(FontWeight), typeof(PasswordField), new PropertyMetadata(FontWeights.SemiBold));
        #endregion
        #region Label
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(PasswordField), new PropertyMetadata(string.Empty));
        #endregion

        public PasswordField()
        {
            InitializeComponent();
        }
    }
}
