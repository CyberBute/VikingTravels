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

namespace VikingTravelsExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VikingAssignmentEntities _db = new VikingAssignmentEntities();
        public static DataGrid custDataGrid;
        public static DataGrid carrDataGrid;
        public static DataGrid jourDataGrid;
        
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        /// <summary>
        /// Loads in the content of the diffrent tables into the respective DataGrids
        /// </summary>
        public void Load()
        {
            myCustDataGrid.ItemsSource = _db.Customers.ToList();
            custDataGrid = myCustDataGrid;

            myCarrDataGrid.ItemsSource = _db.Carriers.ToList();
            carrDataGrid = myCarrDataGrid;

            myJourDataGrid.ItemsSource = _db.Journey.ToList();
            jourDataGrid = myJourDataGrid;
        }


        /// <summary>
        /// Gets user to the InsertCarr window.
        /// Wheere the user then can input data and store it in the myCarrDataGrid
        /// </summary>
        private void InsertCust_Click(object sender, RoutedEventArgs e)
        {
            CustInsert custInsert = new CustInsert();
            custInsert.Show();
            this.Close();
        }
    }
}
