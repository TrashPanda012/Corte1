using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas;
        private int contador;
        private const int MAX = 30;

        public Registro()
        {
            personas = new Persona[MAX];
            contador = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (contador < MAX)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más elementos", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public Persona ObtenerPersona(int indice)
        {
            if (indice >= 0 && indice < contador)
            {
                return personas[indice];
            }
            return null;
        }

        public int Contador
        {
            get { return contador; }
        }
    }
}
