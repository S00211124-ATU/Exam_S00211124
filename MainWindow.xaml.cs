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
using static Exam_S00211124.RentalProperty;

namespace Exam_S00211124
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> Properties = new List<RentalProperty>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //RentalData db = new RentalData();

            //var query = from p in db.Properties
            //            orderby p.Location
            //            select p;

            //allProperties = query.ToList();

            //lbx1.ItemsSource = allProperties;

            RentalProperty p1 = new RentalProperty()
            {
                Price = 400m,
                TypeOfRental = RentalType.House,
                Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                "The house has 4 large double bedrooms with ample space for a desk, " +
                "a large kitchen with all mod cons.  " +
                "There is also a dining room and a large sitting room",
                Location = "Ballinode"
            };

            RentalProperty p2 = new RentalProperty()
            {
                Price = 400m,
                TypeOfRental = RentalType.Share,
                Description = "1 bedroom available to share in a 3 bedroom house located in the " +
    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
    "IT Sligo with regular buses to and from the campus",
                Location = "Strandhill"
            };

            Properties.Add(p1);
            Properties.Add(p2);
            lbx1.ItemsSource = Properties;
        }

        private void lbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // what is selected
            RentalProperty selected = lbx1.SelectedItem as RentalProperty;

            // if something is selected
            if (selected != null)
            {
                //update display
                txtDesc.Text = selected.Description;
               
            }
        }
    }
}
