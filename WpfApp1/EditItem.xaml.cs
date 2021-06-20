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
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro EditItem.xaml
    /// </summary>
    public partial class EditItem : Window
    {
        public Items currentItem;
        public EditItem(Items item)
        {
            InitializeComponent();
            for (int i = 1; i <= 100; i++)
            {
                ComboBoxItem c_item = new ComboBoxItem();
                c_item.Content = i;
                c_amount.Items.Add(c_item);
            }
            DataContext = item;
            currentItem = item;
        }

        private void b_Edit_Click(object sender, RoutedEventArgs e)
        {
            Items.AllItems.Remove(currentItem);
            Items.AllItems.Add((Items)DataContext);
            using (StreamWriter tw = new StreamWriter("data.txt"))
            {
                foreach (var item in Items.AllItems)
                {
                    tw.WriteLine(string.Format("{0},{1},{2},{3}", item.Name, item.Type, item.Amount, item.Unit));
                }
            }
            this.Close();
        }

        private void b_Delete_Click(object sender, RoutedEventArgs e)
        {
            Items.AllItems.Remove(currentItem);
            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                foreach (var item in Items.AllItems)
                {
                    sw.WriteLine(string.Format("{0},{1},{2},{3}", item.Name, item.Type, item.Amount, item.Unit));
                }
            }
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                b_Edit.IsEnabled = false;
            }
            else
            {

                b_Edit.IsEnabled = true;
            }
        }
    }
}
