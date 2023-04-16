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
    /// Lógica de interacción para Index.xaml
    /// </summary>
    public partial class Index 
    {
        public Index()
        {
            InitializeComponent();
        }


        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
           Paginas.Clientes.Lista lista = new Lista();

            this.Close();

            lista.Show();
        }

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {

            Paginas.Clientes.Agregar agregar = new Agregar();
            this.Close();
            agregar.Show();
  



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
