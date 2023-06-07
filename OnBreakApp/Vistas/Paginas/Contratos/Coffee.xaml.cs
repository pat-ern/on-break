using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
//using System.Windows.Forms;


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

            //// Agrega las opciones al ComboBox
            //comboBoxModalidades.Items.Add("Light Break");
            //comboBoxModalidades.Items.Add("Journal Break");
            //comboBoxModalidades.Items.Add("Day Break");

            //logica para validar fechas
            //DateTime fechaInicio = fechaIni.SelectedDateTime.Value;
            //TimeSpan horaInicio = TimeSpan.Parse(textHoraInicio.Text);
            //DateTime fechaHoraInicio = fechaInicio.Add(horaInicio);

            //DateTime fechaActual = DateTime.Now;
            //DateTime fechaMaxima = fechaActual.AddMonths(10);

            //if (fechaHoraInicio < fechaActual || fechaHoraInicio > fechaMaxima)
            //{
            //    MessageBox.Show("La fecha y hora de inicio del evento no puede ser menor a la fecha y hora actual, ni exceder de 10 meses.");
            //    datePickerFechaInicio.Focus();
            //    return;
            //}

            LeerModalidad();

        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            //abrir pagina de lista de clientes para poder buscar informacion
            Paginas.Clientes.ListaClientes listaClientes = new Paginas.Clientes.ListaClientes();
            listaClientes.Show();
        }

        public bool ValidarSeleccionModalidad()
        {
            if (comboBoxModalidades.SelectedIndex <= 0)
            {
                return false;
            }
            return true;
        }

        public bool ObtenerAlimentacionVegetariana()
        {
            return checkBoxVegetariana.IsChecked ?? false;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LeerModalidad()
        {

            OnBreak.BC.ModalidadServicio modalidadServicio = new OnBreak.BC.ModalidadServicio();

            var modalidadServicios = modalidadServicio.ReadAll();

            // Filtrar los eventos por idTipoEvento igual a 20
            modalidadServicios = modalidadServicios.Where(m => m.IdTipoEvento == 10).ToList();

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

        private void checkBoxVegetariana_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
