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
using System.Windows.Shapes;

namespace VikingTravelsExam
{
    /// <summary>
    /// Interaction logic for JourUpdate.xaml
    /// </summary>
    public partial class JourUpdate : Window
    {
        VikingAssignmentEntities _db = new VikingAssignmentEntities();
        int iD;
        public JourUpdate(int carrID)
        {
            InitializeComponent();
            carrID = iD;
            TextInsert();
        }

        /// <summary>
        /// inserts preexisting data into the textboxs(and the combobox) making it easier to update for the user
        /// </summary>
        public void TextInsert()
        {
            //The soul reason why I can't update is right where
            Journey journeyLoad = (from m in _db.Journey where m.jour_Id == iD select m).Single(); 
            insertTitle.Text = journeyLoad.title;
            insertCity.Text = journeyLoad.city;
            insertStartDate.DisplayDate = journeyLoad.startDate;
            insertEndDate.DisplayDate = journeyLoad.endDate;
            insertMax.Text = Convert.ToString(journeyLoad.maxTravelers);
            insertPrice.Text = Convert.ToString(journeyLoad.pricePerTravelers);
            insertDic.Text = journeyLoad.descriptions;

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VikingAssignment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Carriers", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                insertCarrierNames.Items.Add(row["carr_FirstName"].ToString());
            }
        }

        private void NumbersOnly(object sender, TextCompositionEventArgs e)//limits the user to only number inputs within the given textbox
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void UpdateJour_Click(object sender, RoutedEventArgs e)
        {            //if statement that checks if the essential userinputs has been made
            if (string.IsNullOrEmpty(insertTitle.Text) || string.IsNullOrEmpty(insertCity.Text) || string.IsNullOrEmpty(insertStartDate.Text) || string.IsNullOrEmpty(insertEndDate.Text) || string.IsNullOrEmpty(insertPrice.Text) || string.IsNullOrEmpty(insertDic.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Journey journeyInsert = new Journey()
                {
                    title = insertTitle.Text,
                    city = insertCity.Text,
                    startDate = (DateTime)insertStartDate.SelectedDate,
                    endDate = (DateTime)insertEndDate.SelectedDate,
                    maxTravelers = short.Parse(insertMax.Text),
                    jour_Carrier = insertCarrierNames.Text,
                    pricePerTravelers = short.Parse(insertPrice.Text),
                    descriptions = insertDic.Text
                };
                _db.Journey.Add(journeyInsert);
                _db.SaveChanges();
                //upadtes the custDataGrid
                MainWindow.jourDataGrid.ItemsSource = _db.Journey.ToList();
                //returns user to main menu
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }

        }

        private void Chancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
