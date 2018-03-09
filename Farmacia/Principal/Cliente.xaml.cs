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
    /// Interaction logic for Cliente.xaml
    /// </summary>
    public partial class Cliente : Window
    {
        RepositorioDeClientes repositorioCliente;
        bool EsNuevo;
        public Cliente()
        {
            InitializeComponent();
            repositorioCliente = new RepositorioDeClientes();
            HabilitarBotones(true);
            HabilitarCajas(false);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitada)
        {
            tbxCorreoCliente.Clear();
            tbxDireccionCliente.Clear();
            tbxNombreCliente.Clear();
            tbxRfcCliente.Clear();
            tbxTelefonoCliente.Clear();
            tbxCorreoCliente.IsEnabled = habilitada;
            tbxDireccionCliente.IsEnabled = habilitada;
            tbxNombreCliente.IsEnabled = habilitada;
            tbxRfcCliente.IsEnabled = habilitada;
            tbxTelefonoCliente.IsEnabled = habilitada;
        }

        private void HabilitarBotones(bool Habilidato)
        {
            btnAgregarCliente.IsEnabled = Habilidato;
            btnEditarCliente.IsEnabled = Habilidato;
            btnEliminarCliente.IsEnabled = Habilidato;
            btnGuardar.IsEnabled = !Habilidato;
            btnRegresar.IsEnabled = Habilidato;
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Reguistro pagina = new Reguistro();
            pagina.Show();
            this.Close();
        }

        private void ActualizarTabla()
        {
            dtgClientes.ItemsSource = null;
            dtgClientes.ItemsSource = repositorioCliente.LeerCliente();
        }

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            EsNuevo = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxCorreoCliente.Text) || string.IsNullOrEmpty(tbxDireccionCliente.Text)|| string.IsNullOrEmpty(tbxNombreCliente.Text) || string.IsNullOrEmpty(tbxRfcCliente.Text) || string.IsNullOrEmpty(tbxTelefonoCliente.Text))
            {
                MessageBox.Show("Faltan datos por llenar", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (EsNuevo)
            {
                Clientesclase clien = new Clientesclase()
                {
                    nombre = tbxNombreCliente.Text,
                    correo = tbxCorreoCliente.Text,
                    direccion = tbxDireccionCliente.Text,
                    RFC = tbxRfcCliente.Text,
                    telefono = tbxTelefonoCliente.Text
                };
                if (repositorioCliente.AgregarCliente(clien))
                {
                    MessageBox.Show("Se ha guardado con Éxito", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a:\n" + clien.nombre, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Clientesclase orginal = dtgClientes.SelectedItem as Clientesclase;
                Clientesclase modificado = new Clientesclase();

                modificado.nombre = tbxNombreCliente.Text;
                modificado.direccion = tbxDireccionCliente.Text;
                modificado.correo = tbxCorreoCliente.Text;
                modificado.RFC = tbxRfcCliente.Text;
                modificado.telefono = tbxRfcCliente.Text;

                if (repositorioCliente.ModificarCliente(orginal, modificado))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("El Cliente se ha actualizado", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a:\n" + orginal.nombre, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (repositorioCliente.LeerCliente().Count == 0)
            {
                MessageBox.Show("No tienes ningun Cliente\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgClientes.SelectedItem != null)
                {
                    Clientesclase a = dtgClientes.SelectedItem as Clientesclase;
                    HabilitarCajas(true);
                    tbxCorreoCliente.Text = a.correo;
                    tbxDireccionCliente.Text = a.direccion;
                    tbxNombreCliente.Text = a.nombre;
                    tbxRfcCliente.Text = a.RFC;
                    tbxTelefonoCliente.Text = a.telefono;
                    HabilitarBotones(false);
                    EsNuevo = false;
                }
                else
                {
                    MessageBox.Show("Error No has seleccionado nada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (repositorioCliente.LeerCliente().Count == 0)
            {
                MessageBox.Show("No tienes ningun Cliente\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgClientes.SelectedItem != null)
                {
                    Clientesclase a = dtgClientes.SelectedItem as Clientesclase;
                    if (MessageBox.Show("Realmetente deseas eliminar a:\n" + a.nombre, "precaución", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        if (repositorioCliente.EliminarCliente(a))
                        {
                            MessageBox.Show("El cliente ha sido removido", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al Cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
