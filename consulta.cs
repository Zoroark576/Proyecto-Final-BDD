using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_Base_de_Datos
{
    public partial class consulta : Form
    {
        public consulta(List<String> personajesSeleccionados)
        {
            InitializeComponent();
            if (personajesSeleccionados.Count > 0)
            {
                foreach (String personaje in personajesSeleccionados)
                {
                    tBPersonajesSeleccionados.Text += personaje + ",";
                }
                tBPersonajesSeleccionados.Text = tBPersonajesSeleccionados.Text.Substring(0, tBPersonajesSeleccionados.Text.Length - 1);
            }
            else
            {
                tBPersonajesSeleccionados.Text = "No hay personajes seleccionados";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            escogeTusPersonajes esc = new escogeTusPersonajes();
            this.Hide();
            esc.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tag = tBTag.Text;
            String region = tBRegion.Text;
            String posicion = tBPosicion.Text;
            String edad = tBEdad.Text;
            String personajesSeleccionados = tBPersonajesSeleccionados.Text;

            String comparacionPos = "";
            if (rBPosIgual.Checked == true)
            {
                comparacionPos = "Igual";
            } else if (rBPosMenor.Checked == true)
            {
                comparacionPos = "Menor";
            }
            else if (rBPosMayor.Checked == true)
            {
                comparacionPos = "Mayor";
            }

            String comparacionEdad = "";
            if (rBEdadIgual.Checked == true)
            {
                comparacionEdad = "Igual";
            }
            else if (rBEdadMenor.Checked == true)
            {
                comparacionEdad = "Menor";
            }
            else if (rBEdadMayor.Checked == true)
            {
                comparacionEdad = "Mayor";
            }

          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tBTag.Clear();
            tBRegion.Clear();
            tBPosicion.Clear();
            tBEdad.Clear();
            tBPersonajesSeleccionados.Clear();

            rBPosIgual.Checked = true;
            rBPosMenor.Checked = false;
            rBPosMayor.Checked = false;

            rBEdadIgual.Checked = true;
            rBEdadMenor.Checked = false;
            rBEdadMayor.Checked = false;
        }
    }
}
