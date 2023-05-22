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
    public partial class InicioSesionJefe : Form
    {
        Conexion cn = new Conexion();
        public InicioSesionJefe()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;
            var dt = $"SELECT IDU FROM tjefe WHERE NombreUsuario = '{usuario}' AND Contrasenna = '{contraseña}';";
            DataTable resu = cn.CargarDatos(dt);

            if (resu.Rows.Count > 0)
            {
                ElegirMetodo.IDu = resu.Rows[0]["IDU"].ToString();

                string consulta = $"SELECT * FROM tjefe WHERE NombreUsuario = '{usuario}' AND Contrasenna = '{contraseña}'";
                DataTable resultado = cn.CargarDatos(consulta);

                if (resultado.Rows.Count > 0)
                {
                    // Credenciales válidas
                    MessageBox.Show("Inicio de sesión exitoso", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Realizar acciones adicionales después de iniciar sesión exitosamente

                    // Por ejemplo, mostrar el formulario PDF
                    PDF pdf = new PDF();
                    pdf.ShowDialog();
                }
                else
                {
                    // Credenciales inválidas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Credenciales inválidas
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
