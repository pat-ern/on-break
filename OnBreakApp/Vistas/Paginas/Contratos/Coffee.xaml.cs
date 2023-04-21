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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Coffee.xaml
    /// </summary>
    public partial class Coffee : Page
    {
        //Declarar variable valor para calcular el valor total
        private int valor;

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

        }

    }
}
