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

namespace DataBinding
{

    public partial class MainWindow : Window
    {

        private List<Artikel> artikelliste;
        private int currentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            
            artikelliste = new List<Artikel>
            {
            new Artikel(1234567, "Jeans", 39.99),
            new Artikel(2234567, "Hoodie", 19.99),
            new Artikel(3234567, "T-Shirt", 9.99),
            new Artikel(4234567, "Shorts", 14.99),
            new Artikel(9876543, "Pullover", 25.99)
               };

            DataContext = artikelliste[currentIndex];
        }

        private void NextArticle_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % artikelliste.Count;
            DataContext = artikelliste[currentIndex];
        }

        private void Discount_Click(object sender, RoutedEventArgs e)
        {
            var currentArtikel = artikelliste[currentIndex];
            currentArtikel.Preis *= 0.7;
        }
    }
}
