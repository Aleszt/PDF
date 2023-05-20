using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;

namespace LectorPDF
{
    public partial class PDF : Form
    {
        Conexion cn = new Conexion();
        
        public PDF()
        {
            InitializeComponent();

        }



        public void ActualizarTextBox(string rfc, string curp, string nombre, string primerApellido, string segundoApellido, string fechaInicio, string estatus, string fechaCambio, string nombreComercial)
        {

            TextBox[] textBoxes = { textBoxRFC, textBoxCURP, textBoxNombre, textBoxApellido, textBoxSegundoApellido, textBoxFechaInicio, textBoxEstatus, textBoxFechaCambio, textBoxNombreComercial };
            string[] valores = { rfc, curp, nombre, primerApellido, segundoApellido, fechaInicio, estatus, fechaCambio, nombreComercial };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    textBoxes[i].Text = valores[i];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExtraer_Click_1(object sender, EventArgs e)
        {
            FormArrastrar formArrastrar = new FormArrastrar();
            formArrastrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in panel2.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
        }
    }
}