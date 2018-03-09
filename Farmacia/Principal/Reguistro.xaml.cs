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
using Farmacia.COMMON;

namespace Principal
{
    /// <summary>
    /// Interaction logic for Reguistro.xaml
    /// </summary>
    public partial class Reguistro : Window
    {
        List<Empleado> empleado;
        public Reguistro()
        {
            InitializeComponent();
            empleado = new List<Empleado>();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pagina = new MainWindow();
            pagina.Show();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, RoutedEventArgs e)
        {
            Empleados pagina = new Empleados();
            pagina.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            Cliente pagina = new Cliente();
            pagina.Show();
            this.Close();

        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            Productos paguina = new Productos();
            paguina.Show();
            this.Close();
        }
    }
}
