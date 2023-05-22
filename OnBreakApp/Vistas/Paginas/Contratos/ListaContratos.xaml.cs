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
    public partial class Listado_contrato
    {

        //List<Contrato> contratos = new List<Contrato>();

        //List<Cliente> customers = new List<Cliente>();

        //ActividadEmpresa actEmp1 = new ActividadEmpresa() { IdActividadEmpresa = 1, Descripcion = "Prestamos y financiamiento" };
        //ActividadEmpresa actEmp2 = new ActividadEmpresa() { IdActividadEmpresa = 2, Descripcion = "Produccion de alimentos" };
        //ActividadEmpresa actEmp3 = new ActividadEmpresa() { IdActividadEmpresa = 3, Descripcion = "Logistica y cadena de suministros" };
        //ActividadEmpresa actEmp4 = new ActividadEmpresa() { IdActividadEmpresa = 4, Descripcion = "Asesoramiento financiero" };
        //ActividadEmpresa actEmp5 = new ActividadEmpresa() { IdActividadEmpresa = 5, Descripcion = "Marketing y publicidad" };

        //TipoEmpresa tipEmp1 = new TipoEmpresa() { IdTipoEmpresa = 1, Descripcion = "Sociedad Anonima" };
        //TipoEmpresa tipEmp2 = new TipoEmpresa() { IdTipoEmpresa = 2, Descripcion = "Sociedad Limitada" };
        //TipoEmpresa tipEmp3 = new TipoEmpresa() { IdTipoEmpresa = 3, Descripcion = "Sociedad Anonima Cerrada" };
        //TipoEmpresa tipEmp4 = new TipoEmpresa() { IdTipoEmpresa = 4, Descripcion = "Sociedad en Participacion" };
        //TipoEmpresa tipEmp5 = new TipoEmpresa() { IdTipoEmpresa = 5, Descripcion = "Sociedad en Comandita" };

        public Listado_contrato()
        {
            InitializeComponent();
            //this.contratos = contratos;

            //// Tipos de eventos
            //TipoEvento coffeeBreak = new TipoEvento() { IdTipoEvento = 01, Descripcion = "Coffee Break" };
            //TipoEvento cocktail = new TipoEvento() { IdTipoEvento = 02, Descripcion = "Cocktail" };
            //TipoEvento cenas = new TipoEvento() { IdTipoEvento = 03, Descripcion = "Cenas" };

            //// Modalidades de servicio
            //ModalidadServicio lightBreak = new ModalidadServicio() { IdModalidad = "01LB", TipoEvento = coffeeBreak, Nombre = "Light Break", ValorBase = 3, PersonalBase = 2 };
            //ModalidadServicio journalBreak = new ModalidadServicio() { IdModalidad = "02JB", TipoEvento = coffeeBreak, Nombre = "Journal Break", ValorBase = 8, PersonalBase = 6 };
            //ModalidadServicio dayBreak = new ModalidadServicio() { IdModalidad = "03DB", TipoEvento = coffeeBreak, Nombre = "Day Break", ValorBase = 12, PersonalBase = 6 };

            //this.miTabla.ItemsSource = this.contratos;

            //string[] tipoEventoItems = new string[] { coffeeBreak.Descripcion, cocktail.Descripcion, cenas.Descripcion };
            //filtroTipoEvento.ItemsSource = tipoEventoItems;

            //string[] modalidadServicioItems = new string[] { lightBreak.Nombre, journalBreak.Nombre, dayBreak.Nombre };
            //filtroModalidadServicio.ItemsSource = modalidadServicioItems;

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

            //var contratoSeleccionado = miTabla.SelectedItem as Contrato;

            //if (contratoSeleccionado != null)
            //{
            //    AdminContratos adminContratos = new AdminContratos(contratoSeleccionado);
            //    this.Close();
            //    adminContratos.Show();
            //}

        }

        private void Resetear(object sender, RoutedEventArgs e)
        {
            //this.miTabla.ItemsSource = this.contratos;
        }


    }
}
