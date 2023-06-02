﻿using System;
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
using OnBreak.BC;
using OnBreak.BD;

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Cocktail.xaml
    /// </summary>
    public partial class Cocktail : Page
    {
        public Cocktail()
        {
            InitializeComponent();
            LeerModalidad();

        }

        public bool ValidarSeleccionModalidad()
        {
            if (comboBoxModalidades.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una modalidad.");
                return false;
            }

            return true;
        }

        public bool ValidarSeleccionAmbientacion()
        {
            if (radioButtonAmbientacionBasica.IsChecked == false && radioButtonAmbientacionPersonalizada.IsChecked == false)
            {
                MessageBox.Show("Debe seleccionar una ambientación.");
                return false;
            }

            return true;
        }

        public void LeerModalidad()
        {
            OnBreak.BC.ModalidadServicio modalidadServicio = new OnBreak.BC.ModalidadServicio();

            var modalidadServicios = modalidadServicio.ReadAll();

            // Filtrar los eventos por idTipoEvento igual a 20
            modalidadServicios = modalidadServicios.Where(m => m.IdTipoEvento == 20).ToList();

            // Crear objeto "Seleccione" y agregarlo al inicio de la lista de modalidad servicio que es un string IdModalidad es un string
            var opcionSeleccioneModalidad = new OnBreak.BC.ModalidadServicio { IdModalidad = "", Nombre = "Seleccione" };
            modalidadServicios.Insert(0, opcionSeleccioneModalidad);

            // Asignar lista filtrada al combobox

            comboBoxModalidades.ItemsSource = modalidadServicios;
            comboBoxModalidades.DisplayMemberPath = "Nombre";
            comboBoxModalidades.SelectedValuePath = "IdModalidad";

            // Seleccionar el objeto "Seleccione"
            comboBoxModalidades.SelectedIndex = 0;
        }

        public OnBreak.BC.ModalidadServicio ObtenerModalidadSeleccionada()
        {
            if (comboBoxModalidades.SelectedItem is OnBreak.BC.ModalidadServicio modalidadServicio)
            {
                return modalidadServicio;
            }

            return null;
        }


        public OnBreak.BC.TipoAmbientacion ObtenerTipoAmbientacionSeleccionada()
        {
            OnBreak.BC.TipoAmbientacion ambientacion = new OnBreak.BC.TipoAmbientacion();
            var ambientaciones = ambientacion.ReadAll();

            var opcionSeleccioneAmbientacion = new OnBreak.BC.TipoAmbientacion { IdTipoAmbientacion = 0, Descripcion = "Seleccione" };
            ambientaciones.Insert(0, opcionSeleccioneAmbientacion);

            if (radioButtonAmbientacionBasica.IsChecked == true)
            {
                var tipoAmbientacionBasica = ambientaciones.FirstOrDefault(a => a.IdTipoAmbientacion == 10);
                return tipoAmbientacionBasica;
            }
            else if (radioButtonAmbientacionPersonalizada.IsChecked == true)
            {
                var tipoAmbientacionPersonalizada = ambientaciones.FirstOrDefault(a => a.IdTipoAmbientacion == 20);
                return tipoAmbientacionPersonalizada;
            }

            // No se seleccionó ninguna opción
            return null;
        }

        public bool ObtenerMusicaAmbiental()
        {
            OnBreak.BC.Cocktail cocktail = new OnBreak.BC.Cocktail();
            bool musicaAmbiental = checkBoxMusicaAmbiental.IsChecked ?? false;
            cocktail.MusicaAmbiental = musicaAmbiental;

            return musicaAmbiental;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBoxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBoxModalidades_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void radioButtonAmbientacionBasica_Checked(object sender, RoutedEventArgs e)
        {
            //EnviarTipoAmbientacion();

        }

        private void radioButtonAmbientacionPersonalizada_Checked(object sender, RoutedEventArgs e)
        {
            //EnviarTipoAmbientacion();

        }

        private void checkBoxMusicaAmbiental_Checked(object sender, RoutedEventArgs e)
        {
            //EnviarDatosCocktail();
        }

        public void comboBoxModalidades_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
