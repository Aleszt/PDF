using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorPDF
{
    class Conexion
    {
        private MySqlConnection sql_con;

        public static MySqlConnection cs_sql_con;
        private MySqlCommand sql_cmd;
        public Conexion()
        {
            cs_sql_con = sql_con;
        }

        public void Conectarse()
        {

            sql_con = new MySqlConnection("datasource=127.0.0.1;port=6666;username=root;password=;database=bdlectorpdf;");
        }

        public int EjecutarConsulta(string consulta, bool ignorar = false, bool regresarID = false)
        {
            int resultado = 0;
            Conectarse();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = consulta;
            resultado = sql_cmd.ExecuteNonQuery();
            sql_con.Close();

            if (regresarID)
            {
                resultado = Convert.ToInt32(sql_cmd.LastInsertedId);
            }

            return resultado;
        }


        public DataTable CargarDatos(string consulta)
        {
            DataTable db = new DataTable();
            Conectarse();
            //sql_con.Close(); // close the connection before executing the query
            sql_con.Open();
            MySqlCommand com = new MySqlCommand(consulta, sql_con);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            adap.Fill(db);
            sql_con.Close();
            return db;
        }
    }
}
