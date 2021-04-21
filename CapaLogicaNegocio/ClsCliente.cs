using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaLogicaNegocio
{
    public class ClsCliente:ClsEmpresa
    {
        ClsManejador M = new ClsManejador();
        private String empresa;
        private int saldo;

        public int Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public DataTable ListadoClientes()
        {
            return M.Listado("ListarClientes", null);
        }

        public DataTable BuscarCliente(String objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", objDatos));
            return dt = M.Listado("Buscar_Cliente", lst);
        }

        public String RegistrarCliente()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nit", Identificacion));
                lst.Add(new ClsParametros("@Apellidos", Apellido));
                lst.Add(new ClsParametros("@Nombres", Nombre));
                lst.Add(new ClsParametros("@Empresa", Empresa));
                lst.Add(new ClsParametros("@Direccion", Direccion));
                lst.Add(new ClsParametros("@Telefono", Telefono));
                lst.Add(new ClsParametros("@Saldo", Saldo));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarCliente", ref lst);
                Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarCliente()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nit", Identificacion));
                lst.Add(new ClsParametros("@Apellidos", Apellido));
                lst.Add(new ClsParametros("@Nombres", Nombre));
                lst.Add(new ClsParametros("@Empresa", Empresa));
                lst.Add(new ClsParametros("@Direccion", Direccion));
                lst.Add(new ClsParametros("@Telefono", Telefono));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarCliente", ref lst);
                Mensaje = lst[6].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String eliminarCliente(String nit)
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Nit", nit));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("eliminarCliente", ref lst);
                return msj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
