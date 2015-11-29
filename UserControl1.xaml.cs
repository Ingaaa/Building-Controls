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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            AmatsBox.Items.Add("Programmētājs");
            AmatsBox.Items.Add("Testētājs");
            AmatsBox.Items.Add("Vadītājs");
            DatumsBox.SelectedDate = DateTime.Now;
        }

        public string VardsUC
        {
            get { return this.VardsBox.Text; }
            set { this.VardsBox.Text = value; }

        }
        public string UzvardsUC
        {
            get { return this.UzvardsBox.Text; }
            set { this.UzvardsBox.Text = value; }
        }
        public amats AmatsUC
        {
            get
            {
                if (AmatsBox.SelectedIndex == 0) return amats.Programmētājs;
                else if (AmatsBox.SelectedIndex == 1) return amats.Testētējs;
                else return amats.Vadītājs;
            }
            set { this.AmatsBox.SelectedValue = value; }
        }
        public DateTime DatumsUC
        {
            get { return this.DatumsBox.SelectedDate.Value; }
            set { this.DatumsBox.SelectedDate = value; }
        }

        public event EventHandler Entered;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VardsBox.Text != "" && UzvardsBox.Text != "" && (AmatsBox.SelectedIndex == 0 || AmatsBox.SelectedIndex == 1 || AmatsBox.SelectedIndex == 2) && DatumsBox.SelectedDate.HasValue)
                {
                    Entered(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
