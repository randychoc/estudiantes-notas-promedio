using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ParcialWebApp
{
    /// <summary>
    /// Descripción breve de ServicioWebParcial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebParcial : System.Web.Services.WebService
    {
        string servidor;
        string bd;
        string usuario;
        string password;
        string cadenaConexion;

        public ServicioWebParcial()
        {
            servidor = "localhost";
            bd = "ejercicio3";
            usuario = "root";
            password = "";
            cadenaConexion = "server = " + servidor + "; port=3306; User Id = " + usuario + "; Password = " + password + "; database = " + bd + ";";
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet WSEstudiantes()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = cadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM estudiantes;", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
