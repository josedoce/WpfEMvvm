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

namespace WpfEMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Veiculo veiculo;
        public MainWindow()
        {

            InitializeComponent();
            veiculo = new Veiculo();
            veiculo.VeiculoName = "Constellation";
            //DataContext = veiculo;
            VeiculoViewModel veiculo2 = new VeiculoViewModel();
            veiculo2.VeiculoNome = "Vectra Turbo";
            DataContext = veiculo2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            veiculo.VeiculoName = "Prisma tsi";
            MessageBox.Show(string.Format("O veiculo agora é {0}.", veiculo.VeiculoName));
        }
    }

    public class Veiculo
    {
        private string veiculo;
        public string VeiculoName
        {
            get { return veiculo; }
            set { veiculo = value; }
        }
    }
}
