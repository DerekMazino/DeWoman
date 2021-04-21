using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDeDatos
{
    public class ClsManejador
    {
        private String cadena = "Server=DESKTOP-68N1VPN\\SQLEXPRESS ;DataBase=DeWomanBD ;Integrated Security=True";
        public SqlConnection conexion;

        //Metodo para Crear Conexion
        void crearConexion()
        {
            conexion = new SqlConnection(cadena);
        }

        //Metodo para abrir la conexion
        public void Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        //Metodo para cerrar la conexion
        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        //Constructor de la Clase
        public ClsManejador()
        {
            crearConexion();
        }

        //Metodo para ejecutar SP (Ejecutar procedimientos almacenados de tipo Insert, Update y Delete)
        public void EjecutarSP(String NombreSP,ref List<ClsParametros>lst)//La lista generica tiene todos los elementos de la clase parametros
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP,conexion);
                cmd.CommandType = CommandType.StoredProcedure;//Tipo: Procedimientos Almacenados
                if (lst != null)//Verificar si la lista no esta vacia
                {
                    for (int i = 0; i < lst.Count; i++)//Recorrer la lista
                    {
                        //Verificar si la direccion es de tipo entrada
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        //Verificar si la direccion es de tipo salida
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction=ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();//Ejecutar el comando
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
        }
        //Metodo para consultas (SELECT)
        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();//Es una tala tenmporal que contiene un conjunto de datos
            SqlDataAdapter da;//Permite pasar la imformación al datatable
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP,conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//Indicar que es de salida
                if(lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);//Llenar el datatable
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }
    }
}
