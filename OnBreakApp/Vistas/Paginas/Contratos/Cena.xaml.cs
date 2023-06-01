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
    /// Lógica de interacción para Cena.xaml
    /// </summary>
    public partial class Cena : Page
    {
        public Cena()
        {
            InitializeComponent();
            //comboBoxModalidades.Items.Add("Ejecutiva");
            //comboBoxModalidades.Items.Add("Celebración");

            LeerModalidad();
        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void LeerModalidad()
        {

            OnBreak.BC.ModalidadServicio modalidadServicio = new OnBreak.BC.ModalidadServicio();

            var modalidadServicios = modalidadServicio.ReadAll();

            // Filtrar los eventos por idTipoEvento igual a 20
            modalidadServicios = modalidadServicios.Where(m => m.IdTipoEvento == 30).ToList();

            // Crear objeto "Seleccione" y agregarlo al inicio de la lista de modalidad servicio que es un string IdModalidad es un string
            var opcionSeleccioneModalidad = new OnBreak.BC.ModalidadServicio { IdModalidad = "", Nombre = "Seleccione" };
            modalidadServicios.Insert(0, opcionSeleccioneModalidad);

            // Asignar lista filtrada al combobox

            comboBoxModalidades.ItemsSource = modalidadServicios;
            comboBoxModalidades.DisplayMemberPath = "Nombre";
            comboBoxModalidades.SelectedValuePath = "IdModalidad";

            // Seleccionar el objeto "Seleccione"
            comboBoxModalidades.SelectedIndex = 0;
        }
    }
}
