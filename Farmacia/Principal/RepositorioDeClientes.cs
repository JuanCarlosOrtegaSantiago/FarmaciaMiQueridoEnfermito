using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.COMMON;

namespace Principal
{
    public class RepositorioDeClientes
    {
        ManejadorDeArchivos manejadorClientes;
        List<Clientesclase> cliente;
        public RepositorioDeClientes()
        {
            manejadorClientes = new ManejadorDeArchivos("Clientes.BD");
            cliente = new List<Clientesclase>();
        }

        public bool AgregarCliente(Clientesclase client)
        {
            cliente.Add(client);
            bool resultado = ActualizarArchivo();
            cliente = LeerCliente();
            return resultado;
        }
        public bool EliminarCliente(Clientesclase client)
        {
            Clientesclase temporal = new Clientesclase();
            foreach (var item in cliente)
            {
                if (item.telefono == client.telefono)
                {
                    temporal = item;
                }
            }

            cliente.Remove(temporal);
            bool resultado = ActualizarArchivo();
            cliente = LeerCliente();
            return resultado;
        }

        public bool ModificarCliente(Clientesclase original, Clientesclase editado)
        {
            Clientesclase temporal = new Clientesclase();
            foreach (var item in cliente)
            {
                if (original.telefono == item.telefono)
                {
                    temporal = item;
                }
            }
            temporal.nombre = editado.nombre;
            temporal.telefono = editado.telefono;
            temporal.direccion = editado.direccion;
            temporal.correo = editado.correo;
            temporal.RFC = editado.RFC;
            bool resultado = ActualizarArchivo();
            cliente = LeerCliente();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Clientesclase item in cliente)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}\n", item.nombre, item.telefono, item.direccion, item.correo,item.RFC);
            }
            return manejadorClientes.Guardar(datos);
        }

        public List<Clientesclase> LeerCliente()
        {
            string datos = manejadorClientes.Leer();
            if (datos != null)
            {
                List<Clientesclase> Client = new List<Clientesclase>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length-1; i++)
                {
                    string[] campos = lineas[i].Split('|');

                    Clientesclase comprador = new Clientesclase()
                    {
                        nombre = campos[0],
                        telefono = campos[1],
                        direccion = campos[2],
                        correo=campos[3],
                        RFC=campos[4]

                    };
                    Client.Add(comprador);
                }
                cliente = Client;
                return Client;
            }
            else
            {
                return null;
            }
        }

    }
}
