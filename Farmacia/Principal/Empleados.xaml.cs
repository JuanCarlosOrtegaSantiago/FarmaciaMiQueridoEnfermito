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
    /// Interaction logic for Empleados.xaml
    /// </summary>
    public partial class Empleados : Window
    {
        RepositorioDeEmpleados repositorioEmpleado;
        bool EsNuevo;
        public Empleados()
        {
            InitializeComponent();
            repositorioEmpleado = new RepositorioDeEmpleados();
            HabilitarBotones(true);
            habilitarCajas(false);
            actualizarTabla();
        }


        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Reguistro pagina = new Reguistro();
            pagina.Show();
            this.Close();
            
        }

        private void habilitarCajas(bool habilitada)
        {
            campos.IsHitTestVisible = habilitada;
            tbxDireccionEmpleado.Clear();
            tbxNombreEmpleado.Clear();
            tbxPuestoEmpleado.Clear();
            tbxTelefonoEmpleado.Clear();
            tbxNombreEmpleado.IsEnabled = habilitada;
            tbxDireccionEmpleado.IsEnabled = habilitada;
            tbxPuestoEmpleado.IsEnabled = habilitada;
            tbxTelefonoEmpleado.IsEnabled = habilitada;
            
        }

        private void HabilitarBotones(bool habilitado)
        {
            btnAgregarEmpleado.IsEnabled = habilitado;
            btnEditarEmpleado.IsEnabled = habilitado;
            btnEliminarEmpleado.IsEnabled = habilitado;
            btnGuardar.IsEnabled = !habilitado;
            btnRegresar.IsEnabled = habilitado;
        }

        private void actualizarTabla()
        {
            dtgEmpleados.ItemsSource = null;
            dtgEmpleados.ItemsSource = repositorioEmpleado.leerTrabajador();
        }

        private void btnAgregarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            habilitarCajas(true);
            HabilitarBotones(false);
            EsNuevo = true;
            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxNombreEmpleado.Text) || string.IsNullOrEmpty(tbxDireccionEmpleado.Text)||string.IsNullOrEmpty(tbxPuestoEmpleado.Text)|| string.IsNullOrEmpty(tbxTelefonoEmpleado.Text))
            {
                MessageBox.Show("Faltan datos por llenar", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (EsNuevo)
            {
                Empleado emple = new Empleado()
                {
                    nombre = tbxNombreEmpleado.Text,
                    direccion = tbxDireccionEmpleado.Text,
                    puesto = tbxPuestoEmpleado.Text,
                    telefono = tbxTelefonoEmpleado.Text
                };
                if (repositorioEmpleado.AgregarTrabajador(emple))
                {
                    MessageBox.Show("Se ha guardado con Éxito", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                    actualizarTabla();
                    HabilitarBotones(true);
                    habilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a:\n"+emple.nombre, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Empleado original = dtgEmpleados.SelectedItem as Empleado;
                Empleado emple = new Empleado();

                emple.nombre = tbxNombreEmpleado.Text;
                emple.direccion = tbxDireccionEmpleado.Text;
                emple.puesto = tbxPuestoEmpleado.Text;
                emple.telefono = tbxTelefonoEmpleado.Text;
                if(repositorioEmpleado.ModificarEmpleado(original, emple))
                {
                    HabilitarBotones(true);
                    habilitarCajas(false);
                    actualizarTabla();
                    MessageBox.Show("El empleado se ha actualizado", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a:\n" + original.nombre, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }

        private void btnEditarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (repositorioEmpleado.leerTrabajador().Count == 0)
            {
                MessageBox.Show("No tienes ningun empleado\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgEmpleados.SelectedItem != null)
                
                {
                    Empleado a= dtgEmpleados.SelectedItem as Empleado;
                    habilitarCajas(true);
                    tbxDireccionEmpleado.Text = a.direccion;
                    tbxNombreEmpleado.Text = a.nombre;
                    tbxPuestoEmpleado.Text = a.puesto;
                    tbxTelefonoEmpleado.Text = a.telefono;
                    HabilitarBotones(false);
                    EsNuevo = false;
                }
                else
                {
                    MessageBox.Show("Error No has seleccionado nada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            
        }

        private void btnEliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (repositorioEmpleado.leerTrabajador().Count == 0)
            {
                MessageBox.Show("No tienes ningun empleado\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgEmpleados.SelectedItem != null)
                
                {
                    Empleado a = dtgEmpleados.SelectedItem as Empleado;

                    if (MessageBox.Show("Realmetente deseas eliminar a:\n" + a.nombre, "precaución", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        if (repositorioEmpleado.EliminarEmpleado(a))
                        {
                            MessageBox.Show("El empleado ha sido removido", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                            actualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al empleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No has seleccionado nada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
