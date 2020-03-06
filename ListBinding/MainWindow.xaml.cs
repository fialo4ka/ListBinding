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
        private Dictionary<Benutzer, string> _alleBenutzer;
        public Dictionary<Benutzer, string> AlleBenutzer
        {
            get
            {
                if (_alleBenutzer == null)
                {
                    _alleBenutzer = new Dictionary<Benutzer, string>();
                    _alleBenutzer.Add(new Benutzer("1 user", "1"), "1");
                    _alleBenutzer.Add(new Benutzer("2 user", "2"), "2");
                    _alleBenutzer.Add(new Benutzer("3 user", "3"), "3");
                    _alleBenutzer.Add(new Benutzer("4 user", "4"), "4");
                    _alleBenutzer.Add(new Benutzer("5 user", "5"), "5");
                    _alleBenutzer.Add(new Benutzer("6 user", "6"), "6");
                    _alleBenutzer.Add(new Benutzer("7 user", "7"), "7");
                    _alleBenutzer.Add(new Benutzer("8 user", "8"), "8");
                }
                return _alleBenutzer;
            }
        }


        public MainWindow()
        {
            List<ListDetails> listDetails = new List<ListDetails>()
                {
                    new ListDetails("23", new Benutzer("1 user", "1")),
                    new ListDetails("55", new Benutzer("8 user", "8")),
                    new ListDetails("44", new Benutzer("5 user", "5")),
                };

            ObservableCollection<ListDetails> ListDetails = new ObservableCollection<ListDetails>(listDetails);
            InitializeComponent();
            lvBezirke.ItemsSource = ListDetails;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class ListDetails
    {
        public Benutzer Benutzer { get; set; }
        public string Bezirk { get; set; }

        public ListDetails(string bezirk, Benutzer benutzer)
        {
            Benutzer = benutzer;
            Bezirk = bezirk;
        }
    }


    public class Benutzer
    {
        public string Loginname { get; set; }
        public string Name { get; set; }
        public Benutzer(string name, string loginname)
        {
            Name = name;
            Loginname = loginname;
        }
    }
}
