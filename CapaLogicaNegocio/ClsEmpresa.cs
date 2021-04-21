using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsEmpresa:ClsPersona
    {
        ClsManejador M = new ClsManejador();
        private String direccion;
        private long telefono;

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public long Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public DataTable ListadoProveedor()
        {
            return M.Listado("ListarProveedores", null);
        }

        public DataTable BuscarProveedor(String objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", objDatos));
            return dt = M.Listado("Buscar_Proveedor", lst);
        }

        public String RegistrarProveedor()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nit", Identificacion));
                lst.Add(new ClsParametros("@RazSoc", Nombre));
                lst.Add(new ClsParametros("@Direccion", Direccion));
                lst.Add(new ClsParametros("@Telefono", Telefono));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarProveedor", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProveedor()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nit", Identificacion));
                lst.Add(new ClsParametros("@RazSoc", Nombre));
                lst.Add(new ClsParametros("@Direccion", Direccion));
                lst.Add(new ClsParametros("@Telefono", Telefono));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarProveedor", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String eliminarProveedor(String nit)
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Nit", nit));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("eliminarProveedor", ref lst);
                return msj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
