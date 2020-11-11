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
    /// Interaction logic for CustUpdate.xaml
    /// </summary>
    public partial class CustUpdate : Window
    {
        VikingAssignmentEntities _db = new VikingAssignmentEntities();
        int iD;

        public CustUpdate(int customID)
        {
            InitializeComponent();
            customID = iD;
            TextInsert();
        }

        public void TextInsert() //inserts preexisting data into the textboxs(and the combobox) making it easier to update for the user
        {
            Customers customersText= (from m in _db.Customers
                                      where m.cust_Id == iD
                                        select m).Single();
            insertFirstName.Text = customersText.cust_FirstName;
            insertLastName.Text = customersText.cust_LastName;
            insertAddress.Text = customersText.cust_Address;
            insertTelNum.Text = customersText.cust_Tel;
        }

        private void NumbersOnly(object sender, TextCompositionEventArgs e) //insertsnumbers
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void UpdateCust_Click(object sender, RoutedEventArgs e)
        {
            //if statement that casts an error message if a textBox is null
            if (string.IsNullOrEmpty(insertFirstName.Text) || string.IsNullOrEmpty(insertLastName.Text) || string.IsNullOrEmpty(insertAddress.Text) || string.IsNullOrEmpty(insertTelNum.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Customers updateCust = (from m in _db.Customers
                                        where m.cust_Id == iD
                                         select m).Single();
                {
                    updateCust.cust_FirstName = insertFirstName.Text;
                    updateCust.cust_LastName = insertLastName.Text;
                    updateCust.cust_Address = insertAddress.Text;
                    updateCust.cust_Tel = insertTelNum.Text;
                };
                _db.SaveChanges();
                //returns user to main menu
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void Chancel_Click(object sender, RoutedEventArgs e) //returns user to main window
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
