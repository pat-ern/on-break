
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
using Vistas.Paginas.Contratos;
using OnBreak.BC;

namespace Vistas.Paginas.Clientes
{
    /// <summary>
    /// Lógica de interacción para Lista.xaml
    /// </summary>
    public partial class ListaClientes
    {
        //List<Cliente> clientes = new List<Cliente>();

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



        public ListaClientes()
        {
            InitializeComponent();


            var clientes = new Cliente().ReadAll();
            var actEmp = new ActividadEmpresa().ReadAll();
            var tipEmp = new TipoEmpresa().ReadAll();


            // Agregar los resultados al control DataGrid
            for (int i = 0; i < clientes.Count; i++)
            {
                clientes[i].ActividadEmpresa = actEmp.Find(a => a.IdActividadEmpresa == clientes[i].IdActividadEmpresa);
                clientes[i].TipoEmpresa = tipEmp.Find(t => t.IdTipoEmpresa == clientes[i].IdTipoEmpresa);
            }

            this.miTabla.ItemsSource = clientes;


        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            var clientes = new Cliente().ReadAll();

            string textoBusqueda = txt_busquedaRut.Text;

            // Consultar la lista de objetos para obtener los resultados de la búsqueda
            var resultadosRut = from c in clientes
                                where c.RutCliente.Contains(textoBusqueda)
                                select c;

            // Agregar los resultados al control DataGrid
            this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void ActividadEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //Obtener el valor seleccionado del DropDownButton

            //var clientes = new Cliente().ReadAll();

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultadosAct = from c in clientes
            //                    where c.ActividadEmpresa.Descripcion.Equals((String)valorSeleccionado)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosAct.ToList();

        }

        private void TipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //var clientes = new Cliente().ReadAll();

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultadosTip = from c in clientes
            //                    where c.TipoEmpresa.Descripcion.Equals((String)valorSeleccionado)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosTip.ToList();

        }

        private void Resetear(object sender, RoutedEventArgs e)
        {
            //this.miTabla.ItemsSource = this.clientes;
        }

        private void txt_busquedaRut_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {


        }

        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //var clienteSeleccionado = miTabla.SelectedItem as Cliente;

            //if (clienteSeleccionado != null)
            //{
            //    AdminClientes lista = new AdminClientes(clienteSeleccionado);
            //    this.Close();
            //    lista.Show();
            //}

        }
    }
}
