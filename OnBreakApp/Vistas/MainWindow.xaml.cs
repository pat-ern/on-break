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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_contraste_Click(object sender, RoutedEventArgs e)
        {
            // HACER UN CAMBIO EN EL CONTRASTE
            if ((string)btn_contraste.Tag == "false")
            {
                btn_contraste.Tag = "true";
                Background = Brushes.White;
                Foreground = Brushes.Black;
                btn_contraste.Background = Brushes.White;
                btn_adm_cliente.Background = Brushes.Beige;
                btn_adm_contratos.Background = Brushes.Coral;
                btn_contratos.Background = Brushes.CornflowerBlue;
                btn_cliente.Background = Brushes.Cyan;
                btn_contraste.Foreground = Brushes.Black;
                btn_contraste.FontSize = btn_adm_cliente.FontSize = btn_adm_contratos.FontSize = btn_contratos.FontSize = btn_cliente.FontSize = 18;
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.DemiBold;

            }
            else
            {
                btn_contraste.Tag = "false";
                Background = Brushes.Black;
                btn_adm_cliente.Background = btn_adm_contratos.Background = btn_contratos.Background = btn_cliente.Background = Brushes.White;
                btn_contraste.Background = Brushes.White;
                btn_contraste.FontSize = btn_adm_cliente.FontSize = btn_adm_contratos.FontSize = btn_contratos.FontSize = btn_cliente.FontSize = 22;
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.Bold;
            }
        }
    }
}
