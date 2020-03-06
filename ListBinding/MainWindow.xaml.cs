using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<KeyValuePair<User, string>> _alleUser;
        public ObservableCollection<KeyValuePair<User, string>> AlleUser
        {
            get
            {
                if (_alleUser == null)
                {
                    _alleUser = new ObservableCollection<KeyValuePair<User, string>>();
                    _alleUser.Add(new KeyValuePair<User, string>(new User("1 user", "1"), "1"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("2 user", "2"), "2"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("3 user", "3"), "3"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("4 user", "4"), "4"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("5 user", "5"), "5"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("6 user", "6"), "6"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("7 user", "7"), "7"));
                    _alleUser.Add(new KeyValuePair<User, string>(new User("8 user", "8"), "8"));
                }
                return _alleUser;
            }
        }

        ObservableCollection<ListDetails> ListDetails;

        public MainWindow()
        {
            List<ListDetails> listDetails = new List<ListDetails>()
                {
                    new ListDetails("data 1", new User("1 user", "1")),
                    new ListDetails("data 2", new User("8 user", "8")),
                    new ListDetails("data 3", new User("5 user", "5")),
                };

            ListDetails = new ObservableCollection<ListDetails>(listDetails);
            InitializeComponent();
            lvBezirke.ItemsSource = ListDetails;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvBezirkeClick.ItemsSource = ListDetails;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lvBezirkeClick.ItemsSource = null;
        }
    }

    public class ListDetails
    {
        public User User { get; set; }
        public string Bezirk { get; set; }

        public ListDetails(string bezirk, User user)
        {
            User = user;
            Bezirk = bezirk;
        }
    }

    public class User
    {
        public string Loginname { get; set; }
        public string Name { get; set; }
        public User(string name, string loginname)
        {
            Name = name;
            Loginname = loginname;
        }
    }
}
