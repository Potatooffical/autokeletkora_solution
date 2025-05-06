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
using Testtomegindexkezel;

namespace Bmi_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_szamol_Click(object sender, RoutedEventArgs e)
        {
            //int magassag = int.Parse(tbx_magassag.Text);
            //int suly = int.Parse(tbx_testsuly.Text);
            if (double.TryParse(tbx_magassag.Text, out double magassag) && double.TryParse(tbx_testsuly.Text, out double suly) && magassag>0 && suly>0)
            {
                var egyember = new Ember("Gyurcsny Ferenc ", 2000, "Férfi", magassag, suly);
                double tti = egyember.Testtomegindex();
                tb_testomegindex.Text = Convert.ToString(Math.Round(tti, 2));
                tb_eredmeny.Text = egyember.Bmitabla_WPF();
            }
            else
            {
                MessageBox.Show ("FormatException,Program Nem Megfelelő Karaktert talált ");
            }
            
        }

        private void btn_ujszamol_Click(object sender, RoutedEventArgs e)
        {
            tb_testomegindex.Text = " ";
            tb_eredmeny.Text = " ";
            tbx_magassag.Clear();
            tbx_testsuly.Clear();
        }
    }
}
