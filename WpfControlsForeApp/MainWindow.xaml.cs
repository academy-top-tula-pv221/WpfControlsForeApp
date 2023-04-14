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

namespace WpfControlsForeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list;
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            //listBox.Items.Add(new ListBoxItem() { Content = "Item 4" });
            //listBox.Items.Insert(2, "Item insert 2");

            list = new List<string>()
            {
                "Item string 1", "Item string 2", "Item string 3", "Item string 4",
            };
            users = new()
            {
                new(){ Name = "Bob", Age = 23, Married = true, Salary = 10000.00M },
                new(){ Name = "Joe", Age = 48, Married = false, Salary = 20000.00M },
                new(){ Name = "Sam", Age = 35, Married = false, Salary = 30000.00M },
                new(){ Name = "Tim", Age = 19, Married = true, Salary = 15000.00M },
                new(){ Name = "Ben", Age = 35, Married = false, Salary = 25000.00M },
                new(){ Name = "Tom", Age = 19, Married = true, Salary = 38000.00M },
            };
            

            //listBox.ItemsSource = list;
            //
            listView.ItemsSource = users;
            //cmbBox.ItemsSource = users;
            dataGrid.ItemsSource = users;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //list.Add("item 5");
            listBox.SelectedItem = null;
            listBox.ItemsSource = users;
            listBox.DisplayMemberPath = nameof(User.Name);
            listBox.Items.Refresh();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //txtBlock.Text = listBox.SelectedItem.ToString();
        }
    }
}
