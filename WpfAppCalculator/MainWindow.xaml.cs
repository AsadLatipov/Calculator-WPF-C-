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
using WpfAppCalculator;

namespace WpfAppCalculator
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

        private void BTNC_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = "";
        }

       

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Textb.Text = Textb.Text.Remove(Textb.Text.Length - 1, 1);
            }
            catch { }
            
            
        }

        private void BulishBTN_Click(object sender, RoutedEventArgs e)
        {
            if (Textb.Text[Textb.Text.Length - 1] == '/')
            {
                int asa = 0;
            }
            else
            {
                Textb.Text = Textb.Text + BulishBTN.Content.ToString();
            }
        }

        private void KupaytirBTN_Click(object sender, RoutedEventArgs e)
        {
            if (Textb.Text[Textb.Text.Length - 1] == '*')
            {
                int asa = 0;
            }
            else
            {
                Textb.Text = Textb.Text + "*";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + seven.Content.ToString();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + eight.Content.ToString();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + nine.Content.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (Textb.Text[Textb.Text.Length - 1] == '-')
            {
                int asa = 0;
            }
            else
            {
                Textb.Text = Textb.Text + minus.Content.ToString();
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + four.Content.ToString();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + five.Content.ToString();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + six.Content.ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (Textb.Text[Textb.Text.Length - 1] == '+')
            {
                int asa = 0;
            }
            else
            {
                Textb.Text = Textb.Text + plus.Content.ToString();
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + one.Content.ToString();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + two.Content.ToString();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + zero.Content.ToString();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = Textb.Text + three.Content.ToString();
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (Textb.Text[Textb.Text.Length - 1] == '.') 
            {
                int asa =0;
            }
            else
            {
                Textb.Text = Textb.Text + point.Content.ToString();
            }
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            Textb.Text = (Evaluate(Textb.Text).ToString());
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
        
}
