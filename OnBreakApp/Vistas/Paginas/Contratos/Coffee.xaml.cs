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
            Paginas.Clientes.Lista lista = new Paginas.Clientes.Lista();
            lista.Show();
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
            }
            else
            {
                // Si el contenido del TextBox no es un número válido del 2 en adelante, establece el valor en 2
                txt_asistentes.Text = "0";
            }
        }

    }
}
