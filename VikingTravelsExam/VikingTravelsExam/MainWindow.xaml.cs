using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VikingAssignment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Carriers", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                insertJourCarrName.Items.Add(row["carr_FirstName"].ToString());
            }

            myCustDataGrid.ItemsSource = _db.Customers.ToList();
            custDataGrid = myCustDataGrid;

            myCarrDataGrid.ItemsSource = _db.Carriers.ToList();
            carrDataGrid = myCarrDataGrid;

            myJourDataGrid.ItemsSource = _db.Journey.ToList();
            jourDataGrid = myJourDataGrid;
        }

        private void InsertCust_Click(object sender, RoutedEventArgs e)
        {
            //if statement that casts an error message if a textBox is null
            if (string.IsNullOrEmpty(insertFirstName.Text) || string.IsNullOrEmpty(insertLastName.Text) || string.IsNullOrEmpty(insertAddress.Text) || string.IsNullOrEmpty(insertTelNum.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Customers custInsert = new Customers()
                {
                    cust_FirstName = insertFirstName.Text,
                    cust_LastName = insertLastName.Text,
                    cust_Address = insertAddress.Text,
                    cust_Tel = insertTelNum.Text
                };
                _db.Customers.Add(custInsert);
                _db.SaveChanges();
                //upadtes the custDataGrid
                MainWindow.custDataGrid.ItemsSource = _db.Customers.ToList();
            }
        }
        private void NumbersOnly(object sender, TextCompositionEventArgs e)//limits the user to only number inputs within the given textbox
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void CustUpdateBtn_Click(object sender, RoutedEventArgs e) //sends user to CustUpdate page
        {
            int iD = (custDataGrid.SelectedItem as Customers).cust_Id;
            CustUpdate UPage = new CustUpdate(iD);
            UPage.Show();
            this.Close();
        }

        private void CustDeleteBtn_Click(object sender, RoutedEventArgs e) //Delets seleceted item form DATAGRID and from the respected data table
        {
            int iD = (custDataGrid.SelectedItem as Customers).cust_Id;
            var deleteCust = _db.Customers.Where(m => m.cust_Id == iD).Single();
            _db.Customers.Remove(deleteCust);
            _db.SaveChanges();
            custDataGrid.ItemsSource = _db.Customers.ToList();

        }

        private void InsertCarr_Click(object sender, RoutedEventArgs e)
        {
            //if statement that casts an error message if a textBox is null
            if (string.IsNullOrEmpty(insertCarrFirstName.Text) || string.IsNullOrEmpty(insertCarrLastName.Text) || string.IsNullOrEmpty(insertCarrAddress.Text) || string.IsNullOrEmpty(insertCarrTelNum.Text) || string.IsNullOrEmpty(insertCarrRemarks.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Carriers carrInsert = new Carriers()
                {
                    carr_FirstName = insertCarrFirstName.Text,
                    carr_LastName = insertCarrLastName.Text,
                    carr_Address = insertCarrAddress.Text,
                    carr_Tel = insertCarrTelNum.Text,
                    remarks = insertCarrRemarks.Text
                };
                _db.Carriers.Add(carrInsert);
                _db.SaveChanges();
                //upadtes the custDataGrid
                MainWindow.carrDataGrid.ItemsSource = _db.Carriers.ToList();
            }
        }

        private void CarrUpdateBtn_Click(object sender, RoutedEventArgs e) //sends user to CustUpdate page
        {
            int iD = (carrDataGrid.SelectedItem as Carriers).carr_Id;
            CarrUpdate UPage = new CarrUpdate(iD);
            UPage.Show();
            this.Close();
        }

        private void CarrDeleteBtn_Click(object sender, RoutedEventArgs e) //Delets seleceted item form DATAGRID and from the respected data table
        {
            int iD = (carrDataGrid.SelectedItem as Carriers).carr_Id;
            var deleteCarr = _db.Carriers.Where(m => m.carr_Id == iD).Single();
            _db.Carriers.Remove(deleteCarr);
            _db.SaveChanges();
            carrDataGrid.ItemsSource = _db.Carriers.ToList();
        }

        private void InsertJour_Click(object sender, RoutedEventArgs e)
        {
            //if statement that checks if the essential userinputs has been made
            if (string.IsNullOrEmpty(insertJourTitle.Text) || string.IsNullOrEmpty(insertJourCity.Text) || string.IsNullOrEmpty(insertJourStart.Text) || string.IsNullOrEmpty(insertJourEnd.Text) || string.IsNullOrEmpty(insertJourPrice.Text) || string.IsNullOrEmpty(insertJourRemarks.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Journey journeyInsert = new Journey()
                {
                    title = insertJourTitle.Text,
                    city = insertJourCity.Text,
                    startDate = (DateTime)insertJourStart.SelectedDate,
                    endDate = (DateTime)insertJourEnd.SelectedDate,
                    maxTravelers = short.Parse(insertJourMax.Text),
                    jour_Carrier = insertJourCarrName.Text,
                    pricePerTravelers = int.Parse(insertJourPrice.Text),
                    descriptions = insertJourRemarks.Text
                };
                _db.Journey.Add(journeyInsert);
                _db.SaveChanges();
                //upadtes the custDataGrid
                MainWindow.jourDataGrid.ItemsSource = _db.Journey.ToList();
            }
        }

        private void JourUpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int iD = (jourDataGrid.SelectedItem as Journey).jour_Id;
            JourUpdate UPage = new JourUpdate(iD);
            UPage.Show();
            this.Close();
        }

        private void JourDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int iD = (jourDataGrid.SelectedItem as Journey).jour_Id;
            var deleteJour = _db.Journey.Where(m => m.jour_Id == iD).Single();
            _db.Journey.Remove(deleteJour);
            _db.SaveChanges();
            jourDataGrid.ItemsSource = _db.Carriers.ToList();
        }
    }
}
