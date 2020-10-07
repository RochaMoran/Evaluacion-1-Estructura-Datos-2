using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steven_Rocha_Ordenamientos
{
    public partial class Form1 : Form
    {

        int maxClientes, 
            primero = 0,
            ultimo;

        double precio,
               total,
               descuento;

        string idCliente,
               nombreCliente,
               servicio;

        Ordenamientos Cordenamiento;

        public Form1()
        {
            InitializeComponent();
            gpbDatos.Enabled = false;
            gpbMostrar.Visible = false;
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            gpbCantidad.Enabled = true;
            gpbDatos.Enabled = false;
            gpbMostrar.Visible = false;
            dgvDatos.Rows.Clear();
            txtCantidadClientes.Focus();
        }

        private void btnCantidadClientes_Click(object sender, EventArgs e)
        {
            ValidarCantidad();
        }

        private void ValidarCantidad()
        {

            try
            {
                maxClientes = Convert.ToInt32(txtCantidadClientes.Text);

                if (maxClientes <= 0)
                {
                    MessageBox.Show("Datos no validos, el numero de clientes debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Se registraran un total de {maxClientes} clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cordenamiento = new Ordenamientos(maxClientes);
                    ultimo = maxClientes - 1;
                    gpbDatos.Enabled = true;
                    gpbMostrar.Visible = true;
                    gpbCantidad.Enabled = false;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Revisar los datos ingresados previamente, se ha encontrado el siguiente error: \n{error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            LimpiarCampos();
            txtIdentificadorCliente.Focus();
        }

        public void CapturarDatos()
        {
            try
            {
                idCliente = txtIdentificadorCliente.Text;
                nombreCliente = txtNombreCliente.Text;
                precio = Convert.ToDouble(txtPrecioProducto.Text);
                descuento = Convert.ToDouble(txtDescuento.Text);
                total = precio - (precio * descuento / 100);

                if (rbInternet.Checked)
                {
                    servicio = "Internet";
                }
                else if (rbTelefono.Checked)
                {
                    servicio = "Telefonico";
                }
                else if (rbTelevision.Checked)
                {
                    servicio = "Televisión";
                }

                Cordenamiento.LeerDatos(servicio, nombreCliente, total, dgvDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Revisar los datos ingresados previamente, se ha encontrado el siguiente error: \n{error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LimpiarCampos()
        {
            txtDescuento.Clear();
            txtIdentificadorCliente.Clear();
            txtNombreCliente.Clear();
            txtPrecioProducto.Clear();
            rbInternet.Checked = false;
            rbTelefono.Checked = false;
            rbTelevision.Checked = false;
            servicio = "";
        }

        private void cmbOrdenar_TextChanged(object sender, EventArgs e)
        {
            if (cmbOrdenar.Text == "BARAJA")
            {
                Cordenamiento.Baraja(dgvDatos);
            }
            else if (cmbOrdenar.Text == "QUICKSORT")
            {
                Cordenamiento.Quicksort(dgvDatos, primero, ultimo);
            }
        }
    }
}
