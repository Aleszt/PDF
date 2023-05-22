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

        private void PDF_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void PDF_FormClosing(object sender, FormClosingEventArgs e)
        {
            ElegirMetodo.IDu = "0";
            ElegirMetodo.IDe = "0";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar si los datos ya existen en la base de datos
            string consultaExistencia = $"SELECT COUNT(*) FROM tdatospdf WHERE IDU = '{ElegirMetodo.IDu}' AND IDE = '{ElegirMetodo.IDe}'";
            int existe = Convert.ToInt32(cn.CargarDatos(consultaExistencia).Rows[0][0]);

            if (existe == 0)
            {
                // Insertar los datos en la base de datos
                string consulta = $"INSERT INTO tdatospdf (IDU, IDE, RFC, CURP, Nombre, PrimerApellido, SegundoApellido, FechaInicio, Estatus, FechaCambio, NombreComercial, Referencia) VALUES ('{ElegirMetodo.IDu}', '{ElegirMetodo.IDe}', '{textBoxRFC.Text}', '{textBoxCURP.Text}', '{textBoxNombre.Text}', '{textBoxApellido.Text}', '{textBoxSegundoApellido.Text}', '{textBoxFechaInicio.Text}', '{textBoxEstatus.Text}', '{textBoxFechaCambio.Text}', '{textBoxNombreComercial.Text}','{txtNReferencia.Text}')";
                int resultado = cn.EjecutarConsulta(consulta);
            }
        }
    }
}