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

using BibliotecaDeClases;
using MahApps.Metro.Controls.Dialogs;
using Vistas.Paginas.Clientes;

namespace Vistas.Paginas.Contratos
{

    public partial class AdminContratos
    {

        List<Contrato> contratos = new List<Contrato>();

        Contrato contrato = new Contrato();

        public AdminContratos()
        {
            InitializeComponent();
        }

        public AdminContratos(Contrato contrato) {
            InitializeComponent();

            this.contrato = contrato;

            txt_numero.Text = contrato.Numero;
            txt_cliente.Text = contrato.Cliente.RutCliente;
            txt_tipo_evento.Text = contrato.ModalidadServicio.TipoEvento.Descripcion;
            txt_fecha_inicio.Text = contrato.FechaHoraInicio.ToString();
            txt_fecha_termino.Text = contrato.FechaHoraTermino.ToString();
            txt_asistentes.Text = contrato.Asistentes.ToString();
            txt_personal_adicional.Text = contrato.PersonalAdicional.ToString();
            txt_realizado.Text = contrato.Realizado.ToString();
            txt_valor_total.Text = contrato.ValorTotalContrato.ToString();
        }

        public AdminContratos(List<Contrato> contratos)
        {
            InitializeComponent();
            this.contratos = contratos;
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Listado_contrato lista = new Listado_contrato(contratos);
            this.Close();
            lista.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void btn_buscar_Click_1(object sender, RoutedEventArgs e)
        {
            string textoBusqueda = txt_busqueda.Text;

            var resultados = from c in contratos
                                where c.Numero.Contains(textoBusqueda)
                                select c;

            var contrato = new Contrato();

            for (int i = 0; i < resultados.Count(); i++)
            {
                if (resultados.ElementAt(i).Numero == textoBusqueda)
                {

                    contrato = resultados.ElementAt(i);

                    txt_numero.Text = contrato.Numero;
                    txt_cliente.Text = contrato.Cliente.RutCliente;
                    txt_tipo_evento.Text = contrato.ModalidadServicio.TipoEvento.Descripcion;
                    txt_fecha_inicio.Text = contrato.FechaHoraInicio.ToString();
                    txt_fecha_termino.Text = contrato.FechaHoraTermino.ToString();
                    txt_asistentes.Text = contrato.Asistentes.ToString();
                    txt_personal_adicional.Text = contrato.PersonalAdicional.ToString();
                    txt_realizado.Text = contrato.Realizado.ToString();
                    txt_valor_total.Text = contrato.ValorTotalContrato.ToString();
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
            txt_numero.Text = string.Empty;
            txt_cliente.Text = string.Empty;
            txt_tipo_evento.Text = string.Empty;
            txt_fecha_inicio.Text = string.Empty;
            txt_fecha_termino.Text = string.Empty;
            txt_asistentes.Text = string.Empty;
            txt_personal_adicional.Text = string.Empty;
            txt_realizado.Text = string.Empty;
            txt_valor_total.Text = string.Empty;
        }

        private void txt_numero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_asistentes_TextChanged(object sender, EventArgs e)
        {
            // Si el TextBox está vacío, establece el valor predeterminado en cero
            if (string.IsNullOrEmpty(txt_asistentes.Text))
            {
                txt_asistentes.Text = "0";
            }

            // Verifica que el contenido del TextBox sea un número del 2 en adelante
            if (int.TryParse(txt_asistentes.Text, out int result) && result >= 2)
            {
                // El contenido es un número válido del 2 en adelante, hay que hacer el calculo con la uf
                double costo;
                if (result == 2)
                {
                    costo = 2;
                }
                else if (result == 3)
                {
                    costo = 3;
                }
                else if (result == 4)
                {
                    costo = 3.5;
                }
                else
                {
                    costo = 3.5 + (result - 4) * 0.5;
                }
                // Aqui ya deberia tener el valor para multiplicarlo con la uf!!!
                //reto
            }
            else
            {
                // Si el contenido del TextBox no es un número válido del 2 en adelante, establece el valor en 2
                txt_asistentes.Text = "0";
            }
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

        private void btn_coffee_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Contratos.Coffee coffee = new Paginas.Contratos.Coffee();
            vtn_opc.Content = coffee;
        }
    }
}
