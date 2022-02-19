using System.Windows;

namespace WpfAppCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void BTNC_Click(object sender, RoutedEventArgs e) => Textb.Text = "";
        
        private void BulishBTN_Click(object sender, RoutedEventArgs e) => Checker(Division.Content.ToString());

        private void KupaytirBTN_Click(object sender, RoutedEventArgs e) => Checker(Multiplication.Content.ToString());

        private void seven_Click(object sender, RoutedEventArgs e) => Numbers(seven.Content.ToString());

        private void eight_Click(object sender, RoutedEventArgs e) => Numbers(eight.Content.ToString());

        private void nine_Click(object sender, RoutedEventArgs e) => Numbers(nine.Content.ToString());

        private void minus_Click(object sender, RoutedEventArgs e) => Checker(minus.Content.ToString());


        private void four_Click(object sender, RoutedEventArgs e) => Numbers(four.Content.ToString());

        private void five_Click(object sender, RoutedEventArgs e) => Numbers(five.Content.ToString());

        private void six_Click(object sender, RoutedEventArgs e) => Numbers(six.Content.ToString());


        private void plus_Click(object sender, RoutedEventArgs e) => Checker(plus.Content.ToString());


        private void one_Click(object sender, RoutedEventArgs e) => Numbers(one.Content.ToString());

        private void two_Click(object sender, RoutedEventArgs e) => Numbers(two.Content.ToString());

        private void zero_Click(object sender, RoutedEventArgs e) => Numbers(zero.Content.ToString());


        private void three_Click(object sender, RoutedEventArgs e) => Numbers(three.Content.ToString());

        private void point_Click(object sender, RoutedEventArgs e) => Checker(point.Content.ToString());

        private void Numbers(string obj) => Textb.Text = Textb.Text + obj;

        private void equal_Click(object sender, RoutedEventArgs e) => Textb.Text = (Evaluate(Textb.Text).ToString());

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Textb.Text = Textb.Text.Remove(Textb.Text.Length - 1, 1);
            }
            catch { }
        }

        private void Checker(string obj)
        {
            try
            {
                if (obj != Textb.Text[Textb.Text.Length - 1].ToString())
                {
                    Textb.Text = Textb.Text + obj;
                }
            }
            catch { }
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
