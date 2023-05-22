using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;

namespace LectorPDF
{
    public partial class FormArrastrar : Form
    {
        Conexion cn = new Conexion();
        public FormArrastrar()
        {
            
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += FormArrastrar_DragEnter;
            this.DragDrop += FormArrastrar_DragDrop;
        }

        private void FormArrastrar_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FormArrastrar_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                // Procesar los archivos PDF arrastrados
                foreach (string file in files)
                {
                    // Obtener los datos del PDF
                    ExtraerDatosPDF(file);
                }
            }
        }

        public void ExtraerDatosPDF(string rutaPDF)
        {
            // Leer el archivo PDF y extraer los datos
            using (PdfReader reader = new PdfReader(rutaPDF))
            {
                int contadore = 0;
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
                    string papellido = Lista[0];
                    string sapellido = Lista.Length >= 2 ? Lista[1] : string.Empty;
                    if (contadore==0)
                    {
                       string prov = $"INSERT INTO tdatospdf(IDU, IDE, RFC, CURP, Nombre, PrimerApellido, SegundoApellido, FechaInicio, Estatus, FechaCambio, NombreComercial) VALUES('{ElegirMetodo.IDu}', '{ElegirMetodo.IDe}', '{rfc}', '{curp}', '{nombre}', '{papellido}', '{sapellido}', '{fechaCambio}', '{estatus}', '{fechaCambio}', '{nombreComercial}')";
                        DataTable resultado = cn.CargarDatos(prov);
                        contadore++;

                    }

                    // Mostrar la información en los TextBox del formulario principal (Form1)
                    PDF form1 = Application.OpenForms.OfType<PDF>().FirstOrDefault();
                    if (form1 != null)
                    {
                        form1.ActualizarTextBox(rfc, curp, nombre, Lista[0], Lista.Length >= 2 ? Lista[1] : string.Empty, fechaInicio, estatus, fechaCambio, nombreComercial);
                    }
                    
                    this.Close();
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

        private void FormArrastrar_Load(object sender, EventArgs e)
        {

        }
    }

}
