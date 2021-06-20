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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Items currentItem;
        public MainWindow()
        {
            InitializeComponent();
            Items.InitItems();
            Items c = new Items();
            ItemsL.DataContext = c;
        }

        private void b_Add_Click(object sender, RoutedEventArgs e)
        {
            AddItem ai = new AddItem();
            ai.ShowDialog();
        }

        private void b_Edit_Click(object sender, RoutedEventArgs e)
        {
            EditItem ei = new EditItem(currentItem);
            ei.ShowDialog();
            ItemsL.SelectedIndex = 0;
        }

        private void ItemsL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items si = (Items)((sender as ListBox).SelectedItem);
            currentItem = si;
            DataContext = si;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ItemsL.SelectedIndex = 0;
        }
        private void ItemsL_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Items.AllItems.Remove(currentItem);
            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                foreach (var item in Items.AllItems)
                {
                    sw.WriteLine(string.Format("{0},{1},{2},{3}", item.Name, item.Type, item.Amount, item.Unit));
                }
            }
            ItemsL.SelectedIndex = 0;
        }
    }
}
