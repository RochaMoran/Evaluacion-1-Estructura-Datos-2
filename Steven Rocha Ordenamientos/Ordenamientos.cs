using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steven_Rocha_Ordenamientos
{
    class Ordenamientos
    {
        public struct Datos
        {
            public string nombreServicio;
            public string nombreCliente;
            public double total;
        }

        int maximo,
            index = 0;  

        Datos[] dato;

        public Ordenamientos(int max)
        {
            maximo = max;
            dato = new Datos[maximo];
        }
        public void LeerDatos(string servicio, string nombreCliente, double totalParam, DataGridView dgvDatos)
        {
            if (index < maximo)
            {
                dato[index].nombreServicio = servicio;
                dato[index].nombreCliente = nombreCliente;
                dato[index].total = totalParam;
                dgvDatos.Rows.Add(dato[index].nombreServicio, dato[index].nombreCliente, dato[index].total);
                index++;
            }
            else
            {
                MessageBox.Show("Ya no hay registros disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Baraja(DataGridView dgvDatos)
        {
            int i, j;
            double axu;
            string axuNombreCliente,
                   axuServicio;

            //Ciclo que servira para recorrer el array por completo
            for (i = 1; i < maximo; i++)
            {
                //Variable la cual almacenara el valor del array position[2]
                axu = dato[i].total;
                axuNombreCliente = dato[i].nombreCliente;
                axuServicio = dato[i].nombreServicio;

                //Para manejar la posicion n-1 con respecto al array
                j = i - 1;

                //Ciclo el cual position[2]= position[1] si el primero es mayor que el segundo
                while (j >= 0 && dato[j].total > axu)
                {
                    //Cambiamos de posicion el valor menor a la izquierda y el mayor a la derecha
                    dato[j + 1].total = dato[j].total;
                    dato[j + 1].nombreServicio = dato[j].nombreServicio;
                    dato[j + 1].nombreCliente = dato[j].nombreCliente;
                    j--;
                }

                //Sino agregamos el valor mayor a la derecha
                dato[j + 1].total = axu;
                dato[j + 1].nombreCliente = axuNombreCliente;
                dato[j + 1].nombreServicio = axuServicio;
            }

            dgvDatos.Rows.Clear();

            for (i = 0; i < maximo; i++)
            {
                dgvDatos.Rows.Add(dato[i].nombreServicio, dato[i].nombreCliente, dato[i].total);
            }
        }
        public void Quicksort(DataGridView dgvDatos, int primero, int ultimo)
        {
              int  centro = (primero + ultimo) / 2,
                i = primero,
                j = ultimo;

            double pivote = dato[centro].total;

            do
            {
                while (dato[i].total < pivote) i++;
                while (dato[j].total > pivote) j--;

                if (i <= j)
                {
                    double axu;
                    string axuNombreCliente,
                            axuServicio;

                    axuNombreCliente = dato[i].nombreCliente;
                    axuServicio = dato[i].nombreServicio;
                    axu = dato[i].total;

                    dato[i].nombreCliente = dato[j].nombreCliente;
                    dato[i].nombreServicio = dato[j].nombreServicio;
                    dato[i].total = dato[j].total;

                    dato[j].nombreCliente = axuNombreCliente;
                    dato[j].nombreServicio = axuServicio;
                    dato[j].total = axu;
                    i++; j--;
                }

            } while (i <= j);

            if (primero < ultimo)
            {
                Quicksort(dgvDatos, primero, j);
            }

            if (i < ultimo)
            {
                Quicksort(dgvDatos, i, ultimo);
            }

            dgvDatos.Rows.Clear();

            for (i = 0; i < maximo; i++)
            {
                dgvDatos.Rows.Add(dato[i].nombreServicio, dato[i].nombreCliente, dato[i].total);
            }
        }
    }
}
