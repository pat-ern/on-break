﻿using System;
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

using BibliotecaDeClases;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Vistas.Paginas.Clientes;

namespace Vistas.Paginas.Contratos
{

    public partial class AdminContratos
    {

        //List<Contrato> contratos = new List<Contrato>();

        //Contrato contrato = new Contrato();

        public AdminContratos() {
            InitializeComponent();

            //this.contrato = contrato;

            txt_buscar_rut.Text = contrato.Cliente.RutCliente;
            txt_tipo_evento.Text = contrato.ModalidadServicio.TipoEvento.Descripcion;
            string fecha_inicio = contrato.FechaHoraInicio.ToString();
            string fecha_termino = contrato.FechaHoraTermino.ToString();
            txt_asistentes.Value = Convert.ToInt32(contrato.Asistentes);
            txt_personal_adicional.Value = Convert.ToInt32(contrato.PersonalAdicional);
            txt_realizado.Text = contrato.Realizado.ToString();
            txt_valor_total.Text = contrato.ValorTotalContrato.ToString();
        }


        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Listado_contrato lista = new Listado_contrato();
            this.Close();
            lista.Show();
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


        private async void btn_buscar_Click_1(object sender, RoutedEventArgs e)
        {
            string textoBusqueda = txt_buscar_nro.Text;

            //var resultados = from c in contratos
            //                    where c.Numero.Contains(textoBusqueda)
            //                    select c;

            //var contrato = new Contrato();

            //for (int i = 0; i < resultados.Count(); i++)
            //{
            //    if (resultados.ElementAt(i).Numero == textoBusqueda)
            //    {

            //        contrato = resultados.ElementAt(i);

                    txt_buscar_rut.Text = contrato.Cliente.RutCliente;
                    txt_tipo_evento.Text = contrato.ModalidadServicio.TipoEvento.Descripcion;
                    string fecha_inicio = contrato.FechaHoraInicio.ToString();
                    string fecha_termino = contrato.FechaHoraTermino.ToString();
                    txt_asistentes.Value = Convert.ToInt32(contrato.Asistentes);
                    txt_personal_adicional.Value = Convert.ToInt32(contrato.PersonalAdicional);
                    txt_realizado.Text = contrato.Realizado.ToString();
                    txt_valor_total.Text = contrato.ValorTotalContrato.ToString();

                    AsignarFecha(fecha_inicio, fechaIni);
                    AsignarFecha(fecha_termino, fechaFin);


                    if (txt_tipo_evento.Text == "Cocktail")
                    {
                        Paginas.Contratos.Cocktail cocktail = new Paginas.Contratos.Cocktail();
                        vtn_opc.Content = cocktail;
                    }
                    else if (txt_tipo_evento.Text == "Cena")
                    {
                        Paginas.Contratos.Cena cena = new Paginas.Contratos.Cena();
                        vtn_opc.Content = cena;
                    }
                    else if (txt_tipo_evento.Text == "Coffee Break")
                    {
                        Paginas.Contratos.Coffee coffee = new Paginas.Contratos.Coffee();
                        vtn_opc.Content = coffee;
                    }

                }
                else
                {
                    await this.ShowMessageAsync("Advertencia", "Debe ingresar un numero válido.");
                }
                break;
            }

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
            txt_realizado.Text = string.Empty;
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

                string tipoEvento = txt_tipo_evento.Text;
                int numero_personas = (int)(txt_personal_adicional.Value ?? 0);
                double costo = 0;

                if (tipoEvento == "Coffee Break" || tipoEvento == "Cocktail")
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
                else if (tipoEvento == "Cena")
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

                string tipoEvento = txt_tipo_evento.Text;
                int asistentes = (int)(txt_asistentes.Value ?? 0); // Si el valor es nulo, se asigna 0

                double costo = 0;

                if (tipoEvento == "Coffee Break")
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
                else if (tipoEvento == "Cocktail")
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
                else if (tipoEvento == "Cena")
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
    }
}
