//Project: Lab 4
//Description: Read/Write using WPF application
//Name: Alex Moreno, Andy Wold, Bethaly Tenango
//Date: 11 Jul 2016
//Instructor: Brother Daniel Masterson
//Course: CS 176 - Windows Desktop Development

using System;
using System.Collections.Generic;
using System.Data;
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

namespace Lab_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Method from clicking on File >> Load in the menu bar [Andy]
        private void menuLoad_Click(object sender, RoutedEventArgs e)
        {
            // Create two DataTable instances.
            DataTable table1 = new DataTable("patients");
            ReadFile.readFile("testFile.csv", table1);
            // Create a DataSet and put both tables in it.
            DataSet set = new DataSet("office");
            set.Tables.Add(table1);
            dataGrid.ItemsSource = set.Tables["patients"].DefaultView;
        }

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            //Save data to CSV file here

        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            // Code to exit program [Andy]
            Environment.Exit(0);
        }
    }
}
