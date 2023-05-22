using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorPDF
{
    
    public partial class ElegirMetodo : Form
    {
        public static string IDu = "0";
        public static string IDe = "0";
        public ElegirMetodo()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            InicioSesionEmpleado inicio = new InicioSesionEmpleado();
            inicio.ShowDialog();
        }

        private void btnJefe_Click(object sender, EventArgs e)
        {
            InicioSesionJefe inicio = new InicioSesionJefe();
            inicio.ShowDialog();
        }

        private void ElegirMetodo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
