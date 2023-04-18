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
    /// Lógica de interacción para Coffee.xaml
    /// </summary>
    public partial class Coffee : Page
    {
        public Coffee()
        {
            InitializeComponent();

            // Agrega las opciones al ComboBox
            comboBoxModalidades.Items.Add("Light Break");
            comboBoxModalidades.Items.Add("Journal Break");
            comboBoxModalidades.Items.Add("Day Break");
        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
