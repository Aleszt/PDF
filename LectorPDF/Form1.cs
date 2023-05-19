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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExtraerDatosPDF(string rutaPDF)
        {
            // Leer el archivo PDF
            using (PdfReader reader = new PdfReader(rutaPDF))
            {
                // Recorrer las páginas del PDF
                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                {
                    // Extraer el texto de la página actual
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNumber);

                    // Filtrar la información deseada
                    string rfc = FiltrarInformacion(text, "RFC: ([A-Z0-9]+)");
                    string curp = FiltrarInformacion(text, "CURP: ([A-Z0-9]+)");
                    string nombre = FiltrarInformacion(text, "Nombre \\(s\\): ([A-Za-z ]+)");
                    string apellido = ObtenerApellidoCompleto(text, "Primer Apellido: ([A-Za-zÑ-ñ]+)");
                    var Lista = apellido.Split(' ');
                    string fechaInicio = FiltrarInformacion(text, "Fecha inicio de operaciones: ([0-9A-Z ]+)");
                    string estatus = FiltrarInformacion(text, "Estatus en el padrón: ([A-Za-z ]+)");
                    string fechaCambio = FiltrarInformacion(text, "Fecha de último cambio de estado: ([0-9A-Z ]+)");
                    string nombreComercial = FiltrarInformacion(text, "Nombre Comercial: ([A-Za-zÑ-ñ ]+)");

                    // Mostrar la información en los TextBox correspondientes
                    textBoxRFC.Text += rfc + Environment.NewLine;
                    textBoxCURP.Text += curp + Environment.NewLine;
                    textBoxNombre.Text += nombre + Environment.NewLine;
                    textBoxApellido.Text += Lista.Length >= 2 ? Lista[0] : string.Empty + Environment.NewLine;
                    textBoxSegundoApellido.Text += Lista.Length >= 2 ? Lista[1] : string.Empty + Environment.NewLine;
                    textBoxFechaInicio.Text += fechaInicio + Environment.NewLine;
                    textBoxEstatus.Text += estatus + Environment.NewLine;
                    textBoxFechaCambio.Text += fechaCambio + Environment.NewLine;
                    textBoxNombreComercial.Text += nombreComercial + Environment.NewLine;
                }
            }
        }

        private string ObtenerApellidoCompleto(string texto, string patron)
        {
            string resultado = string.Empty;

            Match match = Regex.Match(texto, patron);
            if (match.Success)
            {
                int indice = match.Index + match.Length; // Obtener el índice después del patrón encontrado
                string[] lineas = texto.Substring(indice).Split('\n'); // Dividir el texto restante en líneas

                if (lineas.Length >= 2) // Asegurarse de que haya al menos dos líneas
                {
                    resultado = match.Groups[1].Value + " " + lineas[1].Trim(); // Concatenar el valor encontrado y el siguiente renglón sin espacios extras
                }
            }

            return resultado;
        }

        private string FiltrarInformacion(string texto, string patron)
        {
            string resultado = string.Empty;

            Match match = Regex.Match(texto, patron);
            if (match.Success)
            {
                resultado = match.Groups[1].Value;
            }

            return resultado;
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            string rutaPDF = @"C:\Users\Alejandro\Documents\SAT HOUSE.pdf";
            ExtraerDatosPDF(rutaPDF);

            MessageBox.Show("Datos extraídos del PDF");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
