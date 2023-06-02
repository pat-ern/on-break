using OnBreak.BC;
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
    /// Lógica de interacción para Listado_contrato.xaml
    /// </summary>
    public partial class ListaContratos
    {

        public string VentanaOrigen { get; set; }
        public AdminContratos ParentWindow { get; internal set; }

        public ListaContratos()
        {
            InitializeComponent();

            var contratos = new Contrato().ReadAll();
            var modalidad = new ModalidadServicio().ReadAll();
            var tipoEvento = new TipoEvento().ReadAll();
            var clientes = new Cliente().ReadAll();


            for (int i = 0; i < contratos.Count; i++)
            {
                // RESCATAR EL RUT DEL CLIENTE
                contratos[i].Cliente = clientes.Find(a => a.RutCliente == contratos[i].RutCliente);
                contratos[i].ModalidadServicio = modalidad.Find(a => a.IdModalidad == contratos[i].IdModalidad);
                contratos[i].ModalidadServicio.TipoEvento = tipoEvento.Find(a => a.IdTipoEvento == contratos[i].ModalidadServicio.IdTipoEvento);
            }

            this.tablaContrato.ItemsSource = contratos;
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void TextBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string textoBusqueda = txt_busquedaRut.Text;

            //var resultadosRut = from c in contratos
            //                    where c.Cliente.RutCliente.Contains(textoBusqueda)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void TextBoxNroContrato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string textoBusqueda = txt_busquedaNroContrato.Text;

            //var resultadosRut = from c in contratos
            //                    where c.Numero.Contains(textoBusqueda)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void TipoEvento_Click(object sender, RoutedEventArgs e)
        {

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultados = from c in contratos
            //                 where c.ModalidadServicio.TipoEvento.Descripcion.Equals((String)valorSeleccionado)
            //                 select c;

            //this.miTabla.ItemsSource = resultados.ToList();

        }

        private void ModalidadServicio_Click(object sender, RoutedEventArgs e)
        {

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultados = from c in contratos
            //                 where c.ModalidadServicio.Nombre.Equals((String)valorSeleccionado)
            //                 select c;

            //this.miTabla.ItemsSource = resultados.ToList();

        }

        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var contratoSeleccionado = tablaContrato.SelectedItem as Contrato;

            if (contratoSeleccionado != null)
            {
                if (VentanaOrigen == "AdminContratos")
                {
                    ParentWindow.txt_buscar_nro.Text = contratoSeleccionado.Numero;
                    ParentWindow.txt_buscar_rut.Text = contratoSeleccionado.RutCliente;
                    ParentWindow.txt_razon_social.Text = contratoSeleccionado.Cliente.RazonSocial;
                    ParentWindow.txt_tipo_evento.Text = contratoSeleccionado.ModalidadServicio.TipoEvento.Descripcion;
                    ParentWindow.fechaIni.SelectedDateTime = contratoSeleccionado.FechaHoraInicio;
                    ParentWindow.fechaFin.SelectedDateTime = contratoSeleccionado.FechaHoraTermino;
                    ParentWindow.txt_asistentes.Value = contratoSeleccionado.Asistentes;
                    ParentWindow.txt_personal_adicional.Value = contratoSeleccionado.PersonalAdicional;
                    ParentWindow.checkBox_realizado.IsChecked = Convert.ToBoolean(contratoSeleccionado.Realizado);
                    ParentWindow.txt_valor_total.Text = contratoSeleccionado.ValorTotalContrato.ToString();
                }

                if (contratoSeleccionado.ModalidadServicio.TipoEvento.Descripcion == "Cocktail")
                {
                    Paginas.Contratos.Cocktail cocktail = new Paginas.Contratos.Cocktail();

                    // Acceder a la entidad Cocktail y rellenar los campos con los datos del contrato seleccionado
                    cocktail.comboBoxModalidades.SelectedValue = contratoSeleccionado.ModalidadServicio.IdModalidad;

                    var cocktails = new OnBreak.BC.Cocktail().ReadAll();
                    var cocktailSeleccionado = cocktails.FirstOrDefault(c => c.Numero == contratoSeleccionado.Numero);

                    if (cocktailSeleccionado != null)
                    {
                        cocktail.checkBoxMusicaAmbiental.IsChecked = cocktailSeleccionado.MusicaAmbiental;

                        if (cocktailSeleccionado.Ambientacion)
                        {
                            cocktail.radioButtonAmbientacionBasica.IsChecked = true;
                        }
                        else
                        {
                            cocktail.radioButtonAmbientacionPersonalizada.IsChecked = true;
                        }
                    }

                    ParentWindow.vtn_opc.Content = cocktail;
                }
                this.Close();
            }

        }


        private void Resetear(object sender, RoutedEventArgs e)
        {
            //this.miTabla.ItemsSource = this.contratos;
        }


    }
}
