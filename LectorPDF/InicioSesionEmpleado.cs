using System;
using System.Data;
using System.Windows.Forms;

namespace LectorPDF
{
    public partial class InicioSesionEmpleado : Form
    {
        Conexion cn = new Conexion();

        public InicioSesionEmpleado()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text;

                string consulta = $"SELECT * FROM templeado WHERE NombreUsuario = '{usuario}' AND Contrasenna = '{contraseña}'";
            using (var dt = cn.CargarDatos($"SELECT IDE FROM templeado WHERE NombreUsuario = '{usuario}' AND Contrasenna = '{contraseña}'"))
            {
                ElegirMetodo.IDe = dt.Rows[0]["IDE"].ToString();
            }
            DataTable resultado = cn.CargarDatos(consulta);

                if (resultado.Rows.Count > 0)
                {
                    // Credenciales válidas
                    MessageBox.Show("Inicio de sesión exitoso", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);



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

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Verificar que se hayan ingresado valores válidos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña válidos.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construir la consulta SQL para insertar los datos del nuevo empleado
            string consulta = $"INSERT INTO templeado (NombreUsuario, Contrasenna) VALUES ('{usuario}', '{contraseña}')";

            // Ejecutar la consulta para registrar los datos del nuevo empleado
            int resultado = cn.EjecutarConsulta(consulta);

            if (resultado > 0)
            {
                // Registro exitoso
                MessageBox.Show("Registro exitoso. Ahora puedes iniciar sesión con tus nuevas credenciales.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto después del registro
                txtUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;
            }
            else
            {
                // Error en el registro
                MessageBox.Show("Error al registrar los datos. Inténtalo nuevamente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
