using Lab3;
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

namespace WpfApplication3
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

        //Method from clicking on File --> Load in the menu bar
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
    }
}
