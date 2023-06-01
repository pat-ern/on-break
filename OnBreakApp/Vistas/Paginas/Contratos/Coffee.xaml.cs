﻿using System;
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
//using System.Windows.Forms;


namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Coffee.xaml
    /// </summary>
    public partial class Coffee : Page
    {


        public Coffee()
        {
            InitializeComponent();

            // Agrega las opciones al ComboBox
            comboBoxModalidades.Items.Add("Light Break");
            comboBoxModalidades.Items.Add("Journal Break");
            comboBoxModalidades.Items.Add("Day Break");

            //logica para validar fechas
            //DateTime fechaInicio = fechaIni.SelectedDateTime.Value;
            //TimeSpan horaInicio = TimeSpan.Parse(textHoraInicio.Text);
            //DateTime fechaHoraInicio = fechaInicio.Add(horaInicio);

            //DateTime fechaActual = DateTime.Now;
            //DateTime fechaMaxima = fechaActual.AddMonths(10);

            //if (fechaHoraInicio < fechaActual || fechaHoraInicio > fechaMaxima)
            //{
            //    MessageBox.Show("La fecha y hora de inicio del evento no puede ser menor a la fecha y hora actual, ni exceder de 10 meses.");
            //    datePickerFechaInicio.Focus();
            //    return;
            //}

            //boton buscar

        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            //abrir pagina de lista de clientes para poder buscar informacion
            Paginas.Clientes.ListaClientes listaClientes = new Paginas.Clientes.ListaClientes();
            listaClientes.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
