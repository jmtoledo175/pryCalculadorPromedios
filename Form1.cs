using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadorPromedios
{
    public partial class fmrCalculadorPromedio : Form
    {
        public fmrCalculadorPromedio()
        {
            InitializeComponent();
        }
        private List<string> alumnos = new List<string>();
        private List<double> promedios = new List<double>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtAlumno.Text;
            int numero1 = Convert.ToInt32(txtNota1.Text);
            int numero2 = Convert.ToInt32(txtNota2.Text);

      

            if( txtAlumno.Text != "" && txtNota1.Text != "" && txtNota2.Text != "")
            {
                double promedio = (numero1 + numero2) / 2.0;
                lblResultado.Text = "El promedio de " + nombre +" es " + promedio.ToString();

                alumnos.Add(nombre);
                promedios.Add(promedio);

            }
            else
            {
                MessageBox.Show("Por favor, ingrese notas válidas.");
            }


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnPromedioClase_Click(object sender, EventArgs e)
        {

            if (promedios.Count > 0)
            {
                
                double promedioGeneral = 0;
                foreach (double promedio in promedios)
                {
                    promedioGeneral += promedio;
                }
                promedioGeneral /= promedios.Count;

                
               lblResultado.Text = "Promedio general de todos los alumnos: " + promedioGeneral;
            }
            else
            {
                MessageBox.Show("No hay promedios registrados.");
            }

        }
    }
}
