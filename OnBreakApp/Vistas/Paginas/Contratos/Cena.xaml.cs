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

            LeerModalidad();
        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void radioButtonLocalOnBreak_Checked(object sender, RoutedEventArgs e)
        {
            textBoxValorArriendo.Visibility = Visibility.Visible;
            lblValorArriendo.Visibility = Visibility.Visible;
        }

        private void radioButtonLocalOnBreak_Unchecked(object sender, RoutedEventArgs e)
        {
            textBoxValorArriendo.Visibility = Visibility.Collapsed;
            lblValorArriendo.Visibility = Visibility.Collapsed;
        }


        public bool ValidarSeleccionModalidad()
        {
            if (comboBoxModalidades.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una modalidad.");
                return false;
            }
            return true;
        }
        public bool ValidarSeleccionAmbientacion()
        {
            if (radioButtonAmbientacionBasica.IsChecked == false && radioButtonAmbientacionPersonalizada.IsChecked == false)
            {
                MessageBox.Show("Debe seleccionar una ambientación.");
                return false;
            }

            return true;
        }

        public bool ObtenerMusicaAmbiental()
        {
            OnBreak.BC.Cenas cena = new OnBreak.BC.Cenas();
            bool musicaAmbiental = checkBoxMusicaAmbiental.IsChecked ?? false;
            cena.MusicaAmbiental = musicaAmbiental;

            return musicaAmbiental;
        }

        public bool LocalOnBreak()
        {
            OnBreak.BC.Cenas cena = new OnBreak.BC.Cenas();
            bool localOnBreak = false;
            if (radioButtonLocalOnBreak.IsChecked == true)
            {
                // El RadioButton "OnBreak" está marcado
                localOnBreak = true;
            }

            cena.LocalOnBreak = localOnBreak;

            return localOnBreak;
        }

        public bool OtroLocal()
        {
            OnBreak.BC.Cenas cena = new OnBreak.BC.Cenas();
            bool otroLocal = false;
            if (radioButtonLocalOtro.IsChecked == true)
            {
                otroLocal = true;
            }

            cena.OtroLocalOnBreak = otroLocal;

            return otroLocal;
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

        public OnBreak.BC.ModalidadServicio ObtenerModalidadSeleccionada()
        {
            if (comboBoxModalidades.SelectedItem is OnBreak.BC.ModalidadServicio modalidadServicio)
            {
                return modalidadServicio;
            }

            return null;
        }

        public (double PrecioBase, int PersonalBase) ObtenerDatosModalidadSeleccionada()
        {
            if (comboBoxModalidades.SelectedItem is OnBreak.BC.ModalidadServicio modalidadServicio)
            {
                return (modalidadServicio.ValorBase, modalidadServicio.PersonalBase);
            }

            return (0, 0); // Valores predeterminados en caso de que no se haya seleccionado ninguna modalidad
        }

        public OnBreak.BC.TipoAmbientacion ObtenerTipoAmbientacionSeleccionada()
        {
            OnBreak.BC.TipoAmbientacion ambientacion = new OnBreak.BC.TipoAmbientacion();
            var ambientaciones = ambientacion.ReadAll();

            var opcionSeleccioneAmbientacion = new OnBreak.BC.TipoAmbientacion { IdTipoAmbientacion = 0, Descripcion = "Seleccione" };
            ambientaciones.Insert(0, opcionSeleccioneAmbientacion);

            if (radioButtonAmbientacionBasica.IsChecked == true)
            {
                var tipoAmbientacionBasica = ambientaciones.FirstOrDefault(a => a.IdTipoAmbientacion == 10);
                return tipoAmbientacionBasica;
            }
            else if (radioButtonAmbientacionPersonalizada.IsChecked == true)
            {
                var tipoAmbientacionPersonalizada = ambientaciones.FirstOrDefault(a => a.IdTipoAmbientacion == 20);
                return tipoAmbientacionPersonalizada;
            }

            // No se seleccionó ninguna opción
            return null;
        }

        public bool ValidarSeleccionLocal()
        {
            if (radioButtonLocalOnBreak.IsChecked == false && radioButtonLocalOtro.IsChecked == false)
            {
                MessageBox.Show("Debe seleccionar un local.");
                return false;
            }

            return true;
        }

        private void checkBoxMusicaAmbiental_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxValorArriendo_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calcular5();
        }

        public double Calcular5()
        {
            double valorArriendo = 0;
            if (double.TryParse(textBoxValorArriendo.Text, out valorArriendo))
            {
                double porcentaje = valorArriendo * 0.05;
                return porcentaje;
            }
            else
            {
                // Manejar el caso en que el valor ingresado no sea válido (no es un número)
                textBoxValorArriendo.Text = string.Empty;
                MessageBox.Show("Debe ingresar un valor válido.");
                return 0;
            }
        }

    }
}
