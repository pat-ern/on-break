﻿using BibliotecaDeClases;
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

            //miTabla.Visibility = Visibility.Hidden;
        }


        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
           Paginas.Clientes.Lista lista = new Lista();

            //this.Close();

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

        private void btn_Buscar_Click(object sender, RoutedEventArgs e)
        {

            List<Cliente> customers = new List<Cliente>();

            customers.Add(new Cliente { RutCliente = "16591230-K", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "12854638-7", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "13678945-6", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "19876543-2", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "14123456-7", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "11567890-1", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "16789012-3", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "13245678-9", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "14567890-2", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });
            customers.Add(new Cliente { RutCliente = "17654321-0", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = new ActividadEmpresa(), TipoEmpresa = new TipoEmpresa() });


            string textoBusqueda = txt_busqueda.Text;

            // Consultar la lista de objetos para obtener los resultados de la búsqueda
            var resultados = from c in customers
                             where c.RutCliente.Contains(textoBusqueda)
                             select c;

            // Agregar los resultados al control DataGrid
            miTabla.ItemsSource = resultados.ToList();

            miTabla.Visibility = Visibility.Visible;
        }
    }
}
