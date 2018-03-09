using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.COMMON;

namespace Principal
{
    public class RepositorioDeEmpleados
    {
        ManejadorDeArchivos archivosEmpleados;
        List<Empleado> trabajador;
        public RepositorioDeEmpleados()
        {
            archivosEmpleados = new ManejadorDeArchivos("Empleados.BD");
            trabajador = new List<Empleado>();
        }
        public bool AgregarTrabajador(Empleado empleado)
        {
            trabajador.Add(empleado);
            bool resultado = ActualizarArchivo();
            trabajador = leerTrabajador();
            return resultado;
        }
        public bool EliminarEmpleado(Empleado empleado)
        {
            Empleado temp = new Empleado();
            foreach (var item in trabajador)
            {
                if(item.telefono== empleado.telefono)
                {
                    temp = item;
                }
            }

            trabajador.Remove(temp);
            bool resultado= ActualizarArchivo();
            trabajador = leerTrabajador();
            return resultado;
        }

        public bool ModificarEmpleado(Empleado original, Empleado editado)
        {
            Empleado temp = new Empleado();
            foreach (var item in trabajador)
            {
                if (original.telefono == item.telefono)
                {
                    temp = item;
                }
            }
            temp.nombre = editado.nombre;
            temp.puesto = editado.puesto;
            temp.telefono = editado.telefono;
            temp.direccion = editado.direccion;
            bool resultado = ActualizarArchivo();
            trabajador = leerTrabajador();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Empleado item in trabajador)
            {
                datos += string.Format("{0}|{1}|{2}|{3}\n",item.nombre,item.puesto,item.telefono,item.direccion);
            }
            return archivosEmpleados.Guardar(datos);
        }

        public List<Empleado> leerTrabajador()
        {
            string datos = archivosEmpleados.Leer();
            if (datos != null)
            {
                List<Empleado> emple = new List<Empleado>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length-1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Empleado empleado = new Empleado()
                    {
                        nombre = campos[0],
                        puesto = campos[1],
                        telefono = campos[2],
                        direccion = campos[3]

                    };
                    emple.Add(empleado);
                }
                trabajador = emple;
                return emple;
            }
            else
            {
                return null;
            }
        }
    }
}
