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
    /// Interaction logic for Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        RepositorioDeProductos repositorioProductos;
        bool EsNuevo;
        public Productos()
        {
            InitializeComponent();
            repositorioProductos = new RepositorioDeProductos();
            HabilitarBotones(true);
            HabilitarCajas(false);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitada)
        {
            tbxCantidad.Clear();
            tbxDescipcion.Clear();
            tbxNombreCategoria.Clear();
            tbxNombreProducto.Clear();
            tbxPresentacion.Clear();
            tbxPresioCompra.Clear();
            tbxPresioVenta.Clear();
            tbxCantidad.IsEnabled = habilitada;
            tbxDescipcion.IsEnabled = habilitada;
            tbxNombreCategoria.IsEnabled = habilitada;
            tbxNombreProducto.IsEnabled = habilitada;
            tbxPresentacion.IsEnabled = habilitada;
            tbxPresioCompra.IsEnabled = habilitada;
            tbxPresioVenta.IsEnabled = habilitada;
        }

        private void HabilitarBotones(bool habilitado)
        {
            btnAgregarProducto.IsEnabled = habilitado;
            btnEditarProducto.IsEnabled = habilitado;
            btnEliminarProducto.IsEnabled = habilitado;
            btnGuardar.IsEnabled = !habilitado;
            btnRegresar.IsEnabled = habilitado;
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Reguistro paguina = new Reguistro();
            paguina.Show();
            this.Close();
        }
        private void ActualizarTabla()
        {
            dtgProductos.ItemsSource = null;
            dtgProductos.ItemsSource = repositorioProductos.leerProducto();
        }

        private void btnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            EsNuevo = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxDescipcion.Text)|| string.IsNullOrEmpty(tbxNombreCategoria.Text) || string.IsNullOrEmpty(tbxNombreProducto.Text) || string.IsNullOrEmpty(tbxPresentacion.Text) || string.IsNullOrEmpty(tbxPresioCompra.Text) || string.IsNullOrEmpty(tbxPresioVenta.Text))
            {
                MessageBox.Show("Faltan datos por llenar", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            //if(tbxCantidad.Text != "1" || tbxCantidad.Text != "2" || tbxCantidad.Text != "3" || tbxCantidad.Text != "4" || tbxCantidad.Text != "5" || tbxCantidad.Text != "6" || tbxCantidad.Text != "7" || tbxCantidad.Text != "8" || tbxCantidad.Text != "9" || tbxCantidad.Text != "0")
            //{
            //    MessageBox.Show("Solo puedes introducir numeros en: Cantidad ", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            //    return;
            //}

            if (EsNuevo)
            {
                Producto produc = new Producto()
                {
                    cantidad = int.Parse(tbxCantidad.Text),
                    categoria = tbxNombreCategoria.Text,
                    descripcion = tbxDescipcion.Text,
                    nombreDelProducto = tbxNombreProducto.Text,
                    PrecioCompra = float.Parse(tbxPresioCompra.Text),
                    PrecioVenta = float.Parse(tbxPresioVenta.Text),
                    presentacion = tbxPresentacion.Text

                };
                if (repositorioProductos.AgregarProducto(produc))
                {
                    MessageBox.Show("Se ha guardado con Éxito", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto:\n" + produc.nombreDelProducto, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else {

                Producto origial = dtgProductos.SelectedItem as Producto;
                Producto prod = new Producto();

                prod.cantidad = int.Parse(tbxCantidad.Text);
                prod.categoria = tbxNombreCategoria.Text;
                prod.descripcion = tbxDescipcion.Text;
                prod.nombreDelProducto = tbxNombreProducto.Text;
                prod.PrecioCompra = float.Parse(tbxPresioCompra.Text);
                prod.PrecioVenta = float.Parse(tbxPresioVenta.Text);
                prod.presentacion = tbxPresentacion.Text;
                if(repositorioProductos.ModificarProducto(origial,prod))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("El Producto se ha actualizado", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a:\n" + origial.nombreDelProducto, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            if(repositorioProductos.leerProducto().Count==0)
            {
                MessageBox.Show("No tienes ningun Producto\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgProductos.SelectedItem != null)
                {
                    Producto pro = dtgProductos.SelectedItem as Producto;
                    HabilitarCajas(true);
                    tbxCantidad.Text = pro.cantidad.ToString();
                    tbxDescipcion.Text = pro.descripcion;
                    tbxNombreCategoria.Text = pro.categoria;
                    tbxNombreProducto.Text = pro.nombreDelProducto;
                    tbxPresentacion.Text = pro.presentacion;
                    tbxPresioCompra.Text = pro.PrecioCompra.ToString();
                    tbxPresioVenta.Text = pro.PrecioVenta.ToString();
                    HabilitarBotones(false);
                    EsNuevo = false;
                }
                else
                {
                    MessageBox.Show("Error No has seleccionado nada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (repositorioProductos.leerProducto().Count == 0)
            {
                MessageBox.Show("No tienes ningun Producto\npara eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgProductos.SelectedItem != null)
                {
                    Producto a = dtgProductos.SelectedItem as Producto;
                    if (MessageBox.Show("Realmetente deseas eliminar a:\n" + a.nombreDelProducto, "precaución", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        if (repositorioProductos.EliminarProducto(a))
                        {
                            MessageBox.Show("El proucto ha sido removido", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al Producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
