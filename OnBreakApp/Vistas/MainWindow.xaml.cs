using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System;
using System.Collections;
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
using Vistas.Paginas.Clientes;
using Vistas.Paginas.Contratos;

namespace Vistas
{

    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbrirVentanaHija(MetroWindow ventanaHija)
        {
            this.Close();
            ventanaHija.Show();
        }

        // ADMIN CLIENTES
        private void abrir_admin_clientes(object sender, RoutedEventArgs e)
        {
            AdminClientes adminClientes = new AdminClientes();
            AbrirVentanaHija(adminClientes);
        }

        // LISTA CLIENTES
        private void abrir_lista_clientes(object sender, RoutedEventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            AbrirVentanaHija(listaClientes);
        }

        // ADMIN CONTRATOS
        private void abrir_admin_contratos(object sender, RoutedEventArgs e)
        {
            AdminContratos adminContratos = new AdminContratos();
            AbrirVentanaHija(adminContratos);
        }

        // LISTA CONTRATOS
        private void abrir_lista_contratos(object sender, RoutedEventArgs e)
        {
            ListaContratos listaContratos = new ListaContratos();
            AbrirVentanaHija(listaContratos);
        }

        private void btn_contraste_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btn_contraste.Tag == "false")
            {
                btn_contraste.Tag = "true";
                grid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#34274D"));
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = Brushes.White;
                btn_admin_clientes.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_admin_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_lista_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_lista_clientes.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_contraste.FontWeight = btn_admin_clientes.FontWeight = btn_admin_contratos.FontWeight = btn_lista_contratos.FontWeight = btn_lista_clientes.FontWeight = FontWeights.DemiBold;
            }
            else
            {
                btn_contraste.Tag = "false";
                grid.Background = Brushes.Black;
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = Brushes.Black;
                btn_admin_clientes.Background = btn_admin_contratos.Background = btn_lista_contratos.Background = btn_lista_clientes.Background = Brushes.White;
                btn_admin_clientes.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_admin_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_lista_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_lista_clientes.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_contraste.BorderThickness = btn_admin_clientes.BorderThickness = btn_admin_contratos.BorderThickness = btn_lista_contratos.BorderThickness = btn_lista_clientes.BorderThickness = new Thickness(5);
                btn_contraste.FontWeight = btn_admin_clientes.FontWeight = btn_admin_contratos.FontWeight = btn_lista_contratos.FontWeight = btn_lista_clientes.FontWeight = FontWeights.Bold;
            }
        }


    }
}
