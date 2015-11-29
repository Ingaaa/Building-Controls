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

namespace mdControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Kolekcija.kolekcija.Add(new Darbinieks("Inga", "Pire", new DateTime(1995, 11, 21), amats.Programmētājs));
            Kolekcija.kolekcija.Add(new Darbinieks("Ozola", "Zile", new DateTime(2013, 6, 10), amats.Testētējs));
            listBox.ItemsSource = Kolekcija.kolekcija; //Listboxam kā datu avotu uzstādu kolekciju, kurā atrodas darbinieki
            listBox.DisplayMemberPath = "PilnaisVards"; //Tiek rādīts objekta pilnais vārds
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Listboxā izvēloties kādu objektu, tiek parādītas viņa īpašības

            if (listBox.SelectedIndex >= 0)
            {
                int i = listBox.SelectedIndex;
                Darbinieks temp;
                temp = Kolekcija.kolekcija.ElementAt(i);

                string format = "yyyy.MM.dd";
                //UserControl2 īpašībām tiek uzstādītas jaunās vērtības
                uc2.VardsUC2 = temp.Vards;
                uc2.UzvardsUC2 = temp.Uzvards;
                uc2.DatumsUC2 = temp.Dz_datums.ToString(format);
                uc2.AmatsUC2 = temp.Amatss.ToString();
            }

        }

        private void uc1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uc2_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void uc1_Entered(object sender, EventArgs e)
        {
            //Nospiežot pogu "Saglabāt" tiek pievienots jauns darbinieks kolekcijai
            listBox.ItemsSource = null;
            Kolekcija.kolekcija.Add(new Darbinieks(uc1.VardsUC, uc1.UzvardsUC, uc1.DatumsUC, uc1.AmatsUC));

            listBox.ItemsSource = Kolekcija.kolekcija;
            uc1.VardsBox.Clear();
            uc1.UzvardsBox.Clear();
            uc1.AmatsBox.Items.Refresh();
            uc1.DatumsBox.SelectedDate = DateTime.Now;
        }

        private void uc2_Dzest(object sender, EventArgs e)
        {
            //Nospiežot pogu "Dzēst" tiek dzēsts izvēlētais darbinieks
            if (listBox.SelectedIndex>=0)
            {
                int i = listBox.SelectedIndex;
                listBox.ItemsSource = null;
                Kolekcija.kolekcija.RemoveAt(i);
 
                listBox.ItemsSource = Kolekcija.kolekcija;
                uc2.VardsBlock.Text = "";
                uc2.UzvardsBlock.Text = "";
                uc2.AmatsBlock.Text = "";
                uc2.DatumsBlock.Text = "";
            }
            
        }
    }
}
