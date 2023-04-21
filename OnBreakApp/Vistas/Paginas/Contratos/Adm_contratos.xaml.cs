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

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Adm_contratos.xaml
    /// </summary>
    public partial class Adm_contratos
    {
        public Adm_contratos()
        {
            InitializeComponent();
        }

        public Adm_contratos(Contrato contrato) {
            InitializeComponent();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
