using ProgressCheck2.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;

namespace ProgressCheck2.Windows.MainWindow
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool IsAdmin { get; set; } = false;

        #region Toys
        public ObservableCollection<Toy> Toys
        {
            get { return (ObservableCollection<Toy>)GetValue(ToysProperty); }
            set { SetValue(ToysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToysProperty =
            DependencyProperty.Register("Toys", typeof(ObservableCollection<Toy>), typeof(MainWindow));
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            Toys = DatabaseContext.Entities.Toy.Local;

            #region Sort component initializated
            List<Sorting> sortings = new List<Sorting>()
            {
                new Sorting()
                {
                    Name = "По возрастанию стоимости",
                    SortDescription = new SortDescription()
                    {
                        Direction = ListSortDirection.Ascending,
                        PropertyName = "Cost"
                    }
                },
                new Sorting()
                {
                    Name = "По убыванию стоимости",
                    SortDescription = new SortDescription()
                    {
                        Direction = ListSortDirection.Descending,
                        PropertyName = "Cost"
                    }
                }
            };
            ToysContainer.Items.SortDescriptions.Add(sortings[0].SortDescription);

            SortComponent.ItemsSource = sortings;
            SortComponent.DisplayMemberPath = "Name";
            SortComponent.SelectedIndex = 0;
            #endregion
        }

        private void OnSortingChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) =>
            ToysContainer.Items.SortDescriptions[0] = (SortComponent.SelectedItem as Sorting).SortDescription;

        private void OnSearchBoxChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ToysContainer.Items.Filter = (obj) =>
            {
                Toy toy = obj as Toy;
                string textToSearch = SearchComponent.Text.Trim().ToLower();
                return toy.Name.Trim().ToLower().StartsWith(textToSearch) ||
                       toy.Description.Trim().ToLower().StartsWith(textToSearch);
            };
        }
    }

    public class Sorting
    {
        public string Name { get; set; }
        public SortDescription SortDescription { get; set; }
    }
}
