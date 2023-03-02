using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Layer.Entity;

namespace Layer.AccessData
{
    public class TiempoAccessData
    {
        public static List<TiempoEntity> Listar()
        {
            var lista = new List<TiempoEntity>();
            string cadenaConexion = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=BD_Tiempo;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Tiempo_Listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drlector = cmd.ExecuteReader();


            while (drlector.Read())
            {
                TiempoEntity oEmpleadoEntity = new TiempoEntity();
                oEmpleadoEntity.idTiempo = Convert.ToInt32(drlector["id"]);
                oEmpleadoEntity.dataLocal = drlector["Data_Local"].ToString().Trim();
                oEmpleadoEntity.dataUTC = drlector["Data_UTC"].ToString().Trim();
                oEmpleadoEntity.icoEstadoCeo = drlector["Estado_Ceo"].ToString().Trim();
                oEmpleadoEntity.icoVento = drlector["Vento"].ToString().Trim();
                oEmpleadoEntity.idConcello = drlector["Id_Concello"].ToString().Trim();
                oEmpleadoEntity.nomeConcello = drlector["Nome_Concello"].ToString().Trim(); 
                oEmpleadoEntity.sensacionTermica = drlector["Senscacion_termica"].ToString().Trim();
                oEmpleadoEntity.temperatura = drlector["Temperatura"].ToString().Trim();
                lista.Add(oEmpleadoEntity);
            }
            return lista;
        }
    }
}
