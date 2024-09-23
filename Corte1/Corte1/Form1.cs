using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;
        private Operacion operacion;
        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();
            CargarCiudades();
        }

        private void CargarCiudades()
        {
            cbCiudades.Items.Add("Managua");
            cbCiudades.Items.Add("Masaya");
            cbCiudades.Items.Add("Granada");
            cbCiudades.Items.Add("Boaco");
            cbCiudades.Items.Add("Carazo");
            cbCiudades.Items.Add("Chinandega");
            cbCiudades.Items.Add("Chontales");
            cbCiudades.Items.Add("Estelí");
            cbCiudades.Items.Add("Jinotega");
            cbCiudades.Items.Add("León");
            cbCiudades.Items.Add("Madriz");
            cbCiudades.Items.Add("Matagalpa");
            cbCiudades.Items.Add("Nueva Segovia");
            cbCiudades.Items.Add("Rivas");
            cbCiudades.Items.Add("Rio San Juan");
        }
        private void LimpiarFormulario()
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            cbCiudades.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Now;
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            DateTime fechaNacimiento = dtpBirthday.Value;
            string ciudad = cbCiudades.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(ciudad))
            {
                MessageBox.Show("Los campos no deben quedar en blanco");
                return;
            }

            Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            registro.AgregarPersona(nuevaPersona);
            MessageBox.Show("Persona agregada correctamente.");
            LimpiarFormulario();
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            if (registro.Contador > 0)
            {
                Persona ultimaPersona = registro.ObtenerPersona(registro.Contador - 1);
                int edad = operacion.CalcularEdad(ultimaPersona);
                string mensaje = $"Edad: {edad} años, {operacion.EsMayorDeEdad(ultimaPersona)}";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Debe agregar a alguien para calcular la edad.");
            }
        }
    }
}
