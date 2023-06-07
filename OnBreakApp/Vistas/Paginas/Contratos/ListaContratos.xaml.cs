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

        private List<Contrato> contratos;

        public ListaContratos()
        {
            InitializeComponent();

            var modalidad = new ModalidadServicio().ReadAll();
            var tipoEvento = new TipoEvento().ReadAll();
            var clientes = new Cliente().ReadAll();



            foreach (var modalidades in modalidad)
            {
                MenuItem menuItenModalidad = new MenuItem();
                menuItenModalidad.Header = modalidades.Nombre;
                menuItenModalidad.Click += ModalidadServicio_Click;
                filtroModalidadServicio.Items.Add(menuItenModalidad);
            }

            foreach (var tipoEventos in tipoEvento)
            {
                MenuItem menuItenTipoEvento = new MenuItem();
                menuItenTipoEvento.Header = tipoEventos.Descripcion;
                menuItenTipoEvento.Click += TipoEvento_Click;
                filtroTipoEvento.Items.Add(menuItenTipoEvento);
            }

            // Obtener los clientes originales y asignar modalidadservicio y tipo evento
            contratos = new Contrato().ReadAll().Select(c =>
            {
                c.ModalidadServicio = modalidad.Find(a => a.IdModalidad == c.IdModalidad);
                c.ModalidadServicio.TipoEvento = tipoEvento.Find(a => a.IdTipoEvento == c.ModalidadServicio.IdTipoEvento);
                c.Cliente = clientes.Find(a => a.RutCliente == c.RutCliente);
                return c;
            }).ToList();




            this.tablaContrato.ItemsSource = contratos;






            //for (int i = 0; i < contratos.Count; i++)
            //{
            //    // RESCATAR EL RUT DEL CLIENTE
            //    contratos[i].Cliente = clientes.Find(a => a.RutCliente == contratos[i].RutCliente);
            //    contratos[i].ModalidadServicio = modalidad.Find(a => a.IdModalidad == contratos[i].IdModalidad);
            //    contratos[i].ModalidadServicio.TipoEvento = tipoEvento.Find(a => a.IdTipoEvento == contratos[i].ModalidadServicio.IdTipoEvento);
            //}

            //this.tablaContrato.ItemsSource = contratos;
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void TextBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textoBusqueda = txt_busquedaRut.Text;

            var resultadosRut = from c in contratos
                                where c.Cliente.RutCliente.Contains(textoBusqueda)
                                select c;

            this.tablaContrato.ItemsSource = resultadosRut.ToList();
        }

        private void TextBoxNroContrato_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textoBusqueda = txt_busquedaNroContrato.Text;

            var resultadosRut = from c in contratos
                                where c.Numero.Contains(textoBusqueda)
                                select c;

            this.tablaContrato.ItemsSource = resultadosRut.ToList();
        }

        private void TipoEvento_Click(object sender, RoutedEventArgs e)
        {

            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultados = from c in contratos
                             where c.ModalidadServicio.TipoEvento.Descripcion.Equals((String)valorSeleccionado)
                             select c;

            this.tablaContrato.ItemsSource = resultados.ToList();

        }

        private void ModalidadServicio_Click(object sender, RoutedEventArgs e)
        {

            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultados = from c in contratos
                             where c.ModalidadServicio.Nombre.Equals((String)valorSeleccionado)
                             select c;

            this.tablaContrato.ItemsSource = resultados.ToList();

        }

        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var contratoSeleccionado = tablaContrato.SelectedItem as OnBreak.BC.Contrato;

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
                else if (contratoSeleccionado.ModalidadServicio.TipoEvento.Descripcion == "Cenas")
                {
                    Paginas.Contratos.Cena cena = new Paginas.Contratos.Cena();
                    // Acceder a la entidad Cocktail y rellenar los campos con los datos del contrato seleccionado
                    cena.comboBoxModalidades.SelectedValue = contratoSeleccionado.ModalidadServicio.IdModalidad;
                    var cenas = new OnBreak.BC.Cenas().ReadAll();
                    var cenaSeleccionada = cenas.FirstOrDefault(c => c.Numero == contratoSeleccionado.Numero);
                    if (cenaSeleccionada != null)
                    {
                        if (cenaSeleccionada.IdTipoAmbientacion == 10)
                        {
                            cena.radioButtonAmbientacionBasica.IsChecked = true;
                        }
                        else if (cenaSeleccionada.IdTipoAmbientacion == 20)
                        {
                            cena.radioButtonAmbientacionPersonalizada.IsChecked = true;
                        }
                        cena.checkBoxMusicaAmbiental.IsChecked = cenaSeleccionada.MusicaAmbiental;
                        if (cenaSeleccionada.LocalOnBreak)
                        {
                            cena.radioButtonLocalOnBreak.IsChecked = true;
                            cena.lblValorArriendo.Visibility = Visibility.Visible;
                            cena.textBoxValorArriendo.Visibility = Visibility.Visible;
                            cena.textBoxValorArriendo.Text = cenaSeleccionada.ValorArriendo.ToString();
                            double valorReal = (cenaSeleccionada.ValorArriendo / 5) * 100;
                            cena.textBoxValorArriendo.Text = valorReal.ToString();
                        }
                        else if (cenaSeleccionada.OtroLocalOnBreak)
                        {
                            cena.radioButtonLocalOtro.IsChecked = true;
                            cena.lblValorArriendo.Visibility = Visibility.Collapsed;
                            cena.textBoxValorArriendo.Visibility = Visibility.Collapsed;
                        }
                    }

                    ParentWindow.vtn_opc.Content = cena;
                }
                else if (contratoSeleccionado.ModalidadServicio.TipoEvento.Descripcion == "Coffee Break")
                {
                    Paginas.Contratos.Coffee coffee = new Paginas.Contratos.Coffee();

                    // Acceder a la entidad Coffee y rellenar los campos con los datos del contrato seleccionado
                    coffee.comboBoxModalidades.SelectedValue = contratoSeleccionado.ModalidadServicio.IdModalidad;

                    var coffeeBreakList = new OnBreak.BC.CoffeeBreak().ReadAll();
                    var coffeeBreakSeleccionado = coffeeBreakList.FirstOrDefault(c => c.Numero == contratoSeleccionado.Numero);

                    if (coffeeBreakSeleccionado != null)
                    {
                        // Establecer el valor de checkBoxVegetariana en la instancia de CoffeeBreak seleccionada
                        coffee.checkBoxVegetariana.IsChecked = coffeeBreakSeleccionado.Vegetariana;
                    }

                    ParentWindow.vtn_opc.Content = coffee;
                }
                this.Close();
            }
        }


            private void Resetear(object sender, RoutedEventArgs e)
        {
            this.tablaContrato.ItemsSource = contratos;
        }


    }
}
