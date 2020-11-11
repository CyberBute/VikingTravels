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
    /// Interaction logic for CarrUpdate.xaml
    /// </summary>
    public partial class CarrUpdate : Window
    {
        VikingAssignmentEntities _db = new VikingAssignmentEntities();
        int iD;
        public CarrUpdate(int carrID)
        {
            InitializeComponent();
            carrID = iD;
            TextInsert();
        }

        /// <summary>
        /// Inserts preexisting data into the textboxs making it easier to update for the user
        /// </summary>
        public void TextInsert()
        {
            Carriers carrText = (from m in _db.Carriers
                                 where m.carr_Id == iD
                                 select m).Single();
            insertFirstName.Text = carrText.carr_FirstName;
            insertLastName.Text = carrText.carr_LastName;
            insertAddress.Text = carrText.carr_Address;
            insertTelNum.Text = carrText.carr_Tel;
            insertCarrRemarks.Text = carrText.remarks;
        }

        private void NumbersOnly(object sender, TextCompositionEventArgs e) //insertsnumbers
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void UpdateCust_Click(object sender, RoutedEventArgs e)
        {
            //if statement that casts an error message if a textBox is null
            if (string.IsNullOrEmpty(insertFirstName.Text) || string.IsNullOrEmpty(insertLastName.Text) || string.IsNullOrEmpty(insertAddress.Text) || string.IsNullOrEmpty(insertTelNum.Text) || string.IsNullOrEmpty(insertCarrRemarks.Text))
            {
                errorMessage.Opacity = 100;
            }
            else
            {

                //takes user input and saves it to Customers table
                Carriers updateCarr = (from m in _db.Carriers
                                       where m.carr_Id == iD
                                       select m).Single();
                {
                    updateCarr.carr_FirstName = insertFirstName.Text;
                    updateCarr.carr_LastName = insertLastName.Text;
                    updateCarr.carr_Address = insertAddress.Text;
                    updateCarr.carr_Tel = insertTelNum.Text;
                    updateCarr.remarks = insertCarrRemarks.Text;
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
