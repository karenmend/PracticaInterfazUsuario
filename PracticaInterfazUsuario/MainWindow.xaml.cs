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

namespace PracticaInterfazUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            lblPorcentajePropina.Text =
                Math.Round(sldPorcentajePropina.Value).
                ToString() + "%"; //Redondea 

            float total = float.Parse(txtTotal.Text); //transforma el valor de texto a flotante
            float porcentajePropina =
               (float)Math.Round(sldPorcentajePropina.Value);
            float propina =
                total * (porcentajePropina / 100);
            float totalConPropina =
                total + propina;

            lblResultadoPropina.Text = "$ " + //propiedad Text es la que se modifica 
                propina.ToString();
            lblResultadoTotalConPropina.Text = "$ " +
                totalConPropina.ToString();

        
        }
    }
}
