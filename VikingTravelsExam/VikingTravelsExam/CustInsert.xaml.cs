using System;
using System.Collections.Generic;
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
    /// Interaction logic for CustInsert.xaml
    /// </summary>
    public partial class CustInsert : Window
    {
        VikingAssignmentEntities _db = new VikingAssignmentEntities();

        public CustInsert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limits the user to only number inputs within the given textbox
        /// </summary>
        private void NumbersOnly(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        /// <summary>
        /// Btn event that takes user data input and adds it to the Customers table.
        /// Then it automatically updates the myCustDataGrid (by updating custDataGrid)
        /// Also returns the user to the main menu.
        /// </summary>
        private void AddCust_Click(object sender, RoutedEventArgs e)
        {
            //if statement that casts an error message if a textBox is null
            if (!string.IsNullOrEmpty(insertFirstName.Text)|| !string.IsNullOrEmpty(insertLastName.Text) || !string.IsNullOrEmpty(insertAddress.Text) || !string.IsNullOrEmpty(insertTelNum.Text))
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

                //returns user to main menu
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void Chancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
