using BibliotecaDeClases;
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
using Vistas.Paginas.Clientes;

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Contratar.xaml
    /// </summary>
    public partial class Contratar
    {
        public Contratar(Cliente cliente)
        {
            InitializeComponent();

            //txtRut.Context = cliente.RutCliente;
        
            //lbl_Rut.Content = cliente.RutCliente;

            //lbl_razonSocial.Content = cliente.RazonSocial;


            txt_Rut.Text = cliente.RutCliente;
            txt_razonSocial.Text = cliente.RazonSocial;


 



        }

        private void btn_coffee_Click(object sender, RoutedEventArgs e)
        {
            //poner la page en el frame
            Paginas.Contratos.Coffee coffee = new Paginas.Contratos.Coffee();
            vtn_opc.Content = coffee;
        }

        private void btn_cocktail_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Cocktail cocktail = new Paginas.Contratos.Cocktail();
            vtn_opc.Content = cocktail;
        }

        private void btn_cena_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Cena cena = new Paginas.Contratos.Cena();
            vtn_opc.Content = cena;
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            //abrir pagina de lista de clientes para poder buscar informacion
            Paginas.Clientes.Lista lista = new Paginas.Clientes.Lista();
            lista.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void txt_Rut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
