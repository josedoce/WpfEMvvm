using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfEMvvm
{
    public class VeiculoViewModel : INotifyPropertyChanged
    {
        private string veiculo;

       

        public ICommand MudarCommand { get; set; }


        //sem essa propriedade, não poderemos alterar nada.
        public event PropertyChangedEventHandler? PropertyChanged;

        public VeiculoViewModel() {
            MudarCommand = new RelayCommand(AlgumaLogica, CanExecutarLogica);
        }   

        public bool CanExecutarLogica()
        {
            //execute algo se tiver validado.
            return true;
        }

        public void AlgumaLogica()
        {
            VeiculoNome = "Monza Biturbo";
            MessageBox.Show("Logica...");
        }

        public string VeiculoNome
        {
            get { return veiculo; }
            set
            {
                veiculo = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
