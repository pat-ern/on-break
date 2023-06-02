using System;
using System.Collections.Generic;
using System.Globalization;
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

using OnBreak.BC;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Vistas.Paginas.Clientes;

namespace Vistas.Paginas.Contratos
{

    public partial class AdminContratos : MetroWindow
    {

        public AdminContratos()
        {
            InitializeComponent();
        }

        public AdminContratos(Contrato contrato)
        {
            InitializeComponent();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            ListaContratos listaContratos = new ListaContratos();
            listaContratos.VentanaOrigen = "AdminContratos";
            listaContratos.ParentWindow = this;
            listaContratos.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AsignarFecha(string fechaString, DateTimePicker dateTimePicker)
        {
            string formatoFecha = "dd-MM-yyyy HH:mm:ss";
            DateTime fecha;

            if (DateTime.TryParseExact(fechaString, formatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                // La cadena de fecha se ha convertido correctamente a un objeto DateTime

                // Asigna la fecha al DateTimePicker
                dateTimePicker.SelectedDateTime = fecha;
            }
            else
            {
                // La cadena de fecha no tiene el formato esperado
                // Realiza alguna acción de manejo de errores o muestra un mensaje al usuario
            }
        }


        private void btn_buscar_Click_1(object sender, RoutedEventArgs e)
        {
            ListaContratos listaContratos = new ListaContratos();
            listaContratos.VentanaOrigen = "AdminContratos";
            listaContratos.ParentWindow = this;
            listaContratos.Show();
        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            txt_buscar_rut.Text = string.Empty;
            txt_tipo_evento.Text = string.Empty;
            fechaIni.SelectedDateTime = null;
            fechaFin.SelectedDateTime = null;
            txt_asistentes.Value = null;
            txt_personal_adicional.Value = null;
            //txt_realizado.Text = string.Empty;
            txt_valor_total.Text = string.Empty;
            txt_buscar_nro.Text = string.Empty;
        }
        private void LimpiarValor()
        {
            txt_asistentes.Value = null;
            txt_personal_adicional.Value = null;
        }

        private void SumarCostoAlValorTotal(double costo)
        {
            double uf = 36022.44;
            double valorTotal = Math.Floor(costo * uf);
            txt_valor_total.Text = valorTotal.ToString();
        }

        private double valorTotalActual = 0; // Variable para almacenar el valor actual de txt_valor_total

        private void txt_personal_adicional_ValueChanged(object sender, EventArgs e)
        {
            if (txt_personal_adicional.Value.HasValue)
            {
                if (string.IsNullOrEmpty(txt_tipo_evento.Text))
                {
                    MessageBox.Show("Primero debes seleccionar un tipo de evento.");
                    txt_personal_adicional.Value = null;
                    return; // Sale del método para evitar que continúe la lógica
                }

                //OnBreak.BC.TipoEvento tipoEvento = new OnBreak.BC.TipoEvento();

                int numero_personas = (int)(txt_personal_adicional.Value ?? 0);
                double costo = 0;

                if (txt_tipo_evento.Text == "Coffee Break" || txt_tipo_evento.Text == "Cocktail")
                {
                    if (numero_personas == 2)
                    {
                        costo = 2;
                    }
                    else if (numero_personas == 3)
                    {
                        costo = 3;
                    }
                    else if (numero_personas == 4)
                    {
                        costo = 3.5;
                    }
                    else if (numero_personas > 4)
                    {
                        costo = 3.5 + 0.5 * (numero_personas - 4);
                    }
                }
                else if (txt_tipo_evento.Text == "Cena")  
                {
                    if (numero_personas == 2)
                    {
                        costo = 3;
                    }
                    else if (numero_personas == 3)
                    {
                        costo = 4;
                    }
                    else if (numero_personas == 4)
                    {
                        costo = 5;
                    }
                    else if (numero_personas > 4)
                    {
                        costo = 5 + 0.5 * (numero_personas - 4);
                    }
                }
                SumarCostoAlValorTotal(costo);
            }
        }

        private void txt_asistentes_ValueChanged(object sender, EventArgs e)
        {

            if (txt_asistentes.Value.HasValue)
            {
                if (string.IsNullOrEmpty(txt_tipo_evento.Text))
                {
                    MessageBox.Show("Primero debes seleccionar un tipo de evento.");
                    txt_asistentes.Value = null;
                    return; // Sale del método para evitar que continúe la lógica
                }

                OnBreak.BC.TipoEvento tipoEvento = new OnBreak.BC.TipoEvento();

                int asistentes = (int)(txt_asistentes.Value ?? 0); // Si el valor es nulo, se asigna 0

                double costo = 0;

                if (txt_tipo_evento.Text == "Coffee Break")
                {
                    if (asistentes >= 1 && asistentes <= 20)
                    {
                        costo = 3;
                    }
                    else if (asistentes >= 21 && asistentes <= 50)
                    {
                        costo = 5;
                    }
                    else if (asistentes > 50)
                    {
                        int personasAdicionales = asistentes - 50;
                        costo = 5 + (2 * (personasAdicionales / 20));
                    }
                }
                else if (txt_tipo_evento.Text == "Cocktail")
                {
                    if (asistentes >= 1 && asistentes <= 20)
                    {
                        costo = 4;
                    }
                    else if (asistentes >= 21 && asistentes <= 50)
                    {
                        costo = 6;
                    }
                    else if (asistentes > 50)
                    {
                        int personasAdicionales = asistentes - 50;
                        costo = 6 + (2 * (personasAdicionales / 20));
                    }
                }
                else if (txt_tipo_evento.Text == "Cena")
                {
                    if (asistentes >= 1 && asistentes <= 20)
                    {
                        costo = 1.5 * asistentes;
                    }
                    else if (asistentes >= 21 && asistentes <= 50)
                    {
                        costo = 1.2 * asistentes;
                    }
                    else if (asistentes > 50)
                    {
                        costo = asistentes;
                    }
                }
                SumarCostoAlValorTotal(costo);
            }
        }

        private void btn_cocktail_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Cocktail cocktail = new Paginas.Contratos.Cocktail();
            vtn_opc.Content = cocktail;
            txt_tipo_evento.Text = "Cocktail";
            LimpiarValor();
        }

        private void btn_cena_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Cena cena = new Paginas.Contratos.Cena();
            vtn_opc.Content = cena;
            txt_tipo_evento.Text = "Cena";
            LimpiarValor();
        }

        private void btn_coffee_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Coffee coffee = new Paginas.Contratos.Coffee();
            vtn_opc.Content = coffee;
            txt_tipo_evento.Text = "Coffee Break";
            LimpiarValor();
        }

        private void btn_buscar_Copy_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.VentanaOrigen = "AdminContratos";
            listaClientes.ParentWindow2 = this;
            listaClientes.Show();
        }


        // Este metodo se encarga de obtener el valor de un checkbox
        bool obtenerValorCheckbox(CheckBox checkBox)
        {
            return checkBox.IsChecked ?? true;
        }

        // este metodo genera un numero random para el Numero de Contraro (MODIFICAR, ADAPTARLO AL REQUERIMIENTO)
        string GenerarNumeroRandom()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // aqui valido que el contenido de la ventana sea un objeto de tipo Cocktail
            if (!(vtn_opc.Content is Cocktail cocktail))
            {
                return;
            }
            // este metodo esta declarado en la Pagina Cocktail y se encarga de validar que los campos esten completos.
            if (!cocktail.ValidarSeleccionModalidad())
            {
                MessageBox.Show("Debe seleccionar una modalidad de servicio");
                return;
            }

            // este metodo esta declarado en la Pagina Cocktail y se encarga de validar que los campos esten completos.

            if (!cocktail.ValidarSeleccionAmbientacion())
            {
                MessageBox.Show("Debe seleccionar una ambientación");
                return;
            }

            // este metodo esta declarado en la Pagina Cocktail y se encarga de obtener la modalidad seleccionada en la pagina.
            ModalidadServicio modalidadServicio = cocktail.ObtenerModalidadSeleccionada();

            // este metodo esta declarado en la Pagina Cocktail y se encarga de obtener la ambientacion seleccionada en la pagina.
            TipoAmbientacion tipoAmbientacion = cocktail.ObtenerTipoAmbientacionSeleccionada();

            // este metodo esta declarado en la Pagina Cocktail y se encarga de obtener el valor de la musica ambiental seleccionada en la pagina.
            bool musicaAmbiental = cocktail.ObtenerMusicaAmbiental();

            // este metetdo esta declarado en la Pagina Cocktail y se encarga de obtener el valor de la seleccion de ambientacion cliente seleccionada en la pagina.
            bool tieneAmbientacion = cocktail.ValidarSeleccionAmbientacion();


            // Crear contrato 
            Contrato contrato = new Contrato()
            {
                Numero = GenerarNumeroRandom(),
                Creacion = DateTime.Now,
                Termino = DateTime.Now,
                RutCliente = txt_buscar_rut.Text,
                IdModalidad = modalidadServicio.IdModalidad,
                IdTipoEvento = modalidadServicio.IdTipoEvento,
                FechaHoraInicio = fechaIni.SelectedDateTime.Value,
                FechaHoraTermino = fechaFin.SelectedDateTime.Value,
                Asistentes = (int)(txt_asistentes.Value ?? 0),
                PersonalAdicional = (int)(txt_personal_adicional.Value ?? 0),
                Realizado = obtenerValorCheckbox(checkBox_realizado),
                ValorTotalContrato = double.Parse(txt_valor_total.Text),
                Observaciones = "N/A"
            };

            // Asignar el número de contrato al objeto Cocktail para que se cree en la base de datos
            OnBreak.BC.Cocktail datosCocktail = new OnBreak.BC.Cocktail()
            {
                Numero = contrato.Numero, // Asignar el mismo número de contrato
                IdTipoAmbientacion = tipoAmbientacion.IdTipoAmbientacion, // Asignar el id de la ambientación
                Ambientacion = tieneAmbientacion, // Asignar si tiene ambientación
                MusicaAmbiental = musicaAmbiental, // Asignar si tiene música ambiental
                MusicaCliente = false // Pendiente
            };

            if (contrato.Create() && datosCocktail.Create())
            {
                MessageBox.Show("Contrato y datos de Cocktail creados correctamente");
            }
            else
            {
                MessageBox.Show("No se pudieron crear el contrato y los datos de Cocktail");
            }

        }




        private void checkBox_realizado_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
