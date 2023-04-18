using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace Vistas.Paginas.Clientes
{
    /// <summary>
    /// Lógica de interacción para Agregar.xaml
    /// </summary>
    public partial class Agregar
    {
        public Agregar()
        {
            InitializeComponent();

            string[] actividadEmpresaItems = new string[] { "Item 1", "Item 2", "Item 3" };
            cbx_actividadEmpresa.ItemsSource = actividadEmpresaItems;


            string[] tipoEmpresaItems = new string[] { "Item 1", "Item 2", "Item 3" };
            cbx_tipoEmpresa.ItemsSource = tipoEmpresaItems;
        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Clientes.Index lista = new Index();

            this.Close();

            lista.Show();

        }
    }
}
