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
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {

        public UserControl2()
        {
            InitializeComponent();
        }
        public string VardsUC2
        {
            get { return this.VardsBlock.Text; }
            set { this.VardsBlock.Text = value; }

        }
        public string UzvardsUC2
        {
            get { return this.UzvardsBlock.Text; }
            set { this.UzvardsBlock.Text = value; }
        }
        public string AmatsUC2
        {
            get { return this.AmatsBlock.Text; }
            set { this.AmatsBlock.Text = value; }
        }
        public string DatumsUC2
        {
            get { return this.DatumsBlock.Text; }
            set { this.DatumsBlock.Text = value; }
        }

        public event EventHandler Dzest;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dzest(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
