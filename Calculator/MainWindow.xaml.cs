using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double UltimulNumar, result;
        OperatorulSelectat selectedOperator;

        public MainWindow()
        {
            InitializeComponent();

            LabelRezultat.Content = "0";

        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int ValoareSelectata = 0;

            if (sender == ButonZero)
                ValoareSelectata = 0;
            if (sender == ButonUnu)
                ValoareSelectata = 1;
            if (sender == ButonDoi)
                ValoareSelectata = 2;
            if (sender == ButonTrei)
                ValoareSelectata = 3;
            if (sender == ButonPatru)
                ValoareSelectata = 4;
            if (sender == ButonCinci)
                ValoareSelectata = 5;
            if (sender == ButonSase)
                ValoareSelectata = 6;
            if (sender == ButonSapte)
                ValoareSelectata = 7;
            if (sender == ButonOpt)
                ValoareSelectata = 8;
            if (sender == ButonNoua)
                ValoareSelectata = 9;



            LabelRezultat.Content = LabelRezultat.Content.ToString() == "0" ? LabelRezultat.Content = $"{ValoareSelectata}" : LabelRezultat.Content = $"{LabelRezultat.Content}{ValoareSelectata}";
        }

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            LabelRezultat.Content = double.TryParse(LabelRezultat.Content.ToString(), out UltimulNumar) ? UltimulNumar = UltimulNumar * (-1) : LabelRezultat.Content; 
        }

        private void btnPercentage_Click(object sender, RoutedEventArgs e)
        {
            LabelRezultat.Content = double.TryParse(LabelRezultat.Content.ToString(), out UltimulNumar) ? UltimulNumar = UltimulNumar / (-1) : LabelRezultat.Content;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double NoulNumar;
            if (double.TryParse(LabelRezultat.Content.ToString(), out NoulNumar))
            {
                switch(selectedOperator)
                {
                    case OperatorulSelectat.Adunare:
                        result = SimpleMath.Adunare(UltimulNumar, NoulNumar);
                        break;
                    case OperatorulSelectat.Scadere:
                        result = SimpleMath.Scadere(UltimulNumar, NoulNumar);
                        break;
                    case OperatorulSelectat.Inmultire:
                        result = SimpleMath.Inmultire(UltimulNumar, NoulNumar);
                        break;
                    case OperatorulSelectat.Impartire:
                        result = SimpleMath.Impartire(UltimulNumar, NoulNumar);
                        break;
                }

                LabelRezultat.Content = result.ToString();
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if(!LabelRezultat.Content.ToString().Contains("."))
                LabelRezultat.Content = $"{LabelRezultat.Content}.";
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(LabelRezultat.Content.ToString(), out UltimulNumar))
            {
                LabelRezultat.Content = "0";
            }

            if (sender == BtnInmultire)
                selectedOperator = OperatorulSelectat.Inmultire;
            if (sender == ButonImpartire)
                selectedOperator = OperatorulSelectat.Impartire;
            if (sender == ButonAdunare)
                selectedOperator = OperatorulSelectat.Adunare;
            if (sender == ButonScadere)
                selectedOperator = OperatorulSelectat.Scadere;

        }

        private void btnAc_Click(object sender, RoutedEventArgs e)
        {
            LabelRezultat.Content = "0";
        }
    }
}
