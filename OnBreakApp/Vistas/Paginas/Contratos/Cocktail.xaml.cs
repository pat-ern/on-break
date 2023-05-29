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

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Cocktail.xaml
    /// </summary>
    public partial class Cocktail : Page
    {
        public Cocktail()
        {
            InitializeComponent();

            // Agrega las opciones al ComboBox
            comboBoxModalidades.Items.Add("Quick Cocktail");
            comboBoxModalidades.Items.Add("Ambient Cocktail");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
