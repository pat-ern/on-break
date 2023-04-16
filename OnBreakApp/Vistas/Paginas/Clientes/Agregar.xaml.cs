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
        }

        private void txt_Rut(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_razonSocial(object sender, TextChangedEventArgs e)
        {

        }


        private void Txt_nombreContacto(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Index index = new Index();
            this.Close();
            index.Show();

        }






        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}
    }
}
