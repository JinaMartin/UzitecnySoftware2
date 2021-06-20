using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace WpfApp1
{
   public class Items : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }
        public string Type
        {
            get => type;
            set { type = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type")); }
        }
        private int amount;
        public int Amount
        {
            get => amount;
            set { amount = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Amount")); }
        }
        private string unit;
        public string Unit
        {
            get => unit;
            set { unit = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Unit")); }
        }
        private string type;
        

        public static ObservableCollection<Items> AllItems { get; set; } = new ObservableCollection<Items>();

        public Items()
        {

        }
        public Items(string name, string type, int amount, string unit)
        {
            Name = name;
            Type = type;
            Amount = amount;
            Unit = unit;
        }

        public static void InitItems()
        {
            string line;
            try
            {
                using (StreamReader file = new StreamReader("data.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        AllItems.Add(new Items { Name = words[0], Type = words[1], Amount = Convert.ToInt32(words[2]), Unit = words[3]});
                    }
                }
            }
            catch (IOException)
            {
                using (StreamWriter sw = new StreamWriter("data.txt"))
                {

                }
            }
        }
   }
}
