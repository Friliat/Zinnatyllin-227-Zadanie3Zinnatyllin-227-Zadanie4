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
using static System.Math;

namespace Prak4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double l = Convert.ToDouble(TexA.Text);
            double L = 1 + 24.86 * Pow(10,-2);
            double λ = Convert.ToDouble(Texλ.Text);
            double D = L + Sin(l * λ) / (2 + Cos(Pow(λ, 2))) + λ - Pow(10, λ);
            TexRe.Text += "\n" + "D=" + D;
        }
    }
}
