﻿using System;
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
    /// Interaction logic for CarrInsert.xaml
    /// </summary>
    public partial class CarrInsert : Window
    {
        public CarrInsert()
        {
            InitializeComponent();
        }
        private void NumbersOnly(object sender, TextCompositionEventArgs e)//limits the user to only number inputs within the given textbox
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }
    }
}