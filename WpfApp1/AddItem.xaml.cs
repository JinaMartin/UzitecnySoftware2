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
    /// Interakční logika pro AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        public Items newItem = new Items("Název položky", "Jiné", 1, "ks");
        public AddItem()
        {
            InitializeComponent();
            for (int i = 1; i <= 100; i++)
            {
                ComboBoxItem c_item = new ComboBoxItem();
                c_item.Content = i;
                c_amount.Items.Add(c_item);
            }
            DataContext = newItem;
        }

        private void b_Add_Click(object sender, RoutedEventArgs e)
        {
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

        private void b_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tb_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                b_Add.IsEnabled = false;
            }
            else
            {

                b_Add.IsEnabled = true;
            }
        }
    }
}
