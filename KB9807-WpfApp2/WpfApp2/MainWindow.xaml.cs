using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 0; i < 100; i++)
            {
                this.Items.Add(new Item { Id = i, Name = "ABC" });
            }

            this.DataContext = this.Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var recordsInView = this.xamDataGrid1.GetRecordsInView(false);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
