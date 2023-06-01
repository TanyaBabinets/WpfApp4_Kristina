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
using WpfApp4_Kristina.Models;

namespace WpfApp4_Kristina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            controller.AddPerson(name.Text, int.Parse(age.Text));
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            foreach (var a in controller.GetAllPerson())
            {
                list.Items.Add(a);
            }

        }
        void Print()
        {
            list.Items.Clear();
            foreach (var a in controller.GetAllPerson())
            {
                list.Items.Add(a);
            }
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var a = list.SelectedItem;
                controller.Delete((Models.Person)a);
                Print();
            }
            catch (Exception ex) { MessageBox.Show("No choice"); }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            try
            {
                var list1 = controller.GetSearch(searchT.Text);
                list.Items.Clear();
                foreach (var a in list1)
                {

                    list.Items.Add(a);

                }

            }
            catch (Exception ex) { MessageBox.Show("Not found"); }
        }

    }
}

