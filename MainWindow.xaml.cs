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

namespace NameList
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

        // submits item to list from text box
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(myTextBox.Text) && !myListBox.Items.Contains(myTextBox.Text))
            {
                myListBox.Items.Add(myTextBox.Text);
                myTextBox.Clear();
            }
        }

        // removes item from list
        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            myListBox.Items.RemoveAt(0);
        }
    }
}
