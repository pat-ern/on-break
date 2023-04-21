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

    public partial class Adm_contratos
    {

        List<Contrato> contratos = new List<Contrato>();

        Contrato contrato = new Contrato();

        public Adm_contratos()
        {
            InitializeComponent();
        }

        public Adm_contratos(Contrato contrato) {
            InitializeComponent();

            this.contrato = contrato;

            txt_numero.Text = contrato.Numero;
            txt_creacion.Text = contrato.Creacion.ToString();
            txt_termino.Text = contrato.Termino.ToString();
            txt_cliente.Text = contrato.Cliente.RutCliente;
            txt_tipo_evento.Text = contrato.ModalidadServicio.TipoEvento.Descripcion;
            txt_fecha_inicio.Text = contrato.FechaHoraInicio.ToString();
            txt_fecha_termino.Text = contrato.FechaHoraTermino.ToString();
            txt_asistentes.Text = contrato.Asistentes.ToString();
            txt_personal_adicional.Text = contrato.PersonalAdicional.ToString();
            txt_realizado.Text = contrato.Realizado.ToString();
            txt_valor_total.Text = contrato.ValorTotalContrato.ToString();
        }

        public Adm_contratos(List<Contrato> contratos)
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
                    txt_creacion.Text = contrato.Creacion.ToString();
                    txt_termino.Text = contrato.Termino.ToString();
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
            txt_creacion.Text = string.Empty;
            txt_termino.Text = string.Empty;
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
    }
}
