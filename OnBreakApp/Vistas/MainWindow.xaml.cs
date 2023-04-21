using BibliotecaDeClases;
using ControlzEx.Theming;
using MahApps.Metro.Controls;
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


namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_adm_cliente_Click(object sender, RoutedEventArgs e)
        {
            // ABRIR LA VISTA DE ADMINISTRACION DE CLIENTES

            var cliente = new Cliente();
            Paginas.Clientes.Index index = new Paginas.Clientes.Index(cliente);
            this.Close();
            index.Show();
        }

        private void btn_cliente_Click(object sender, RoutedEventArgs e)
        {
            // ABRIR LA VISTA DE LISTA DE CLIENTES
            Paginas.Clientes.Lista lista = new Paginas.Clientes.Lista();
            this.Close();
            lista.Show();
        }

        private void btn_crear_contratos_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            Paginas.Contratos.Contratar contratar = new Paginas.Contratos.Contratar(cliente);
            this.Close();
            contratar.Show();
        }

        private void btn_contratos_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Listado_contrato listado = new Paginas.Contratos.Listado_contrato();
            this.Close();
            listado.Show();
        }

        private void btn_contraste_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btn_contraste.Tag == "false")
            {
                btn_contraste.Tag = "true";
                grid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#34274D"));
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = lbl_crear_contratos.Foreground = Brushes.White;
                btn_adm_cliente.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_adm_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_cliente.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_crear_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC53FB5"));
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = btn_crear_contratos.FontWeight = FontWeights.DemiBold;
            }
            else
            {
                btn_contraste.Tag = "false";
                grid.Background = Brushes.Black;
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = lbl_crear_contratos.Foreground = Brushes.Black;
                btn_adm_cliente.Background = btn_adm_contratos.Background = btn_contratos.Background = btn_cliente.Background = btn_crear_contratos.Background = Brushes.White;
                btn_adm_cliente.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_adm_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_cliente.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_crear_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC53FB5"));
                btn_contraste.BorderThickness = btn_adm_cliente.BorderThickness = btn_adm_contratos.BorderThickness = btn_contratos.BorderThickness = btn_cliente.BorderThickness = btn_crear_contratos.BorderThickness = new Thickness(5);
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = btn_crear_contratos.FontWeight = FontWeights.Bold;
            }
        }

        private void btn_adm_contratos_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Adm_contratos adm_Contratos = new Paginas.Contratos.Adm_contratos();
            this.Close();
            adm_Contratos.Show();
        }
    }
}
