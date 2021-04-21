using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
    public class ClsProducto : ClsElemento
    {
        ClsManejador M = new ClsManejador();
        private int precio;
        private int categoria;

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public DataTable ListadoProducto()
        {
            return M.Listado("ListarProducto", null);
        }
        public DataTable CargarImagen(int id)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", id));
            return dt = M.Listado("CargarImagen", lst);
        }
        public DataTable BuscarProducto(String objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", objDatos));
            return dt = M.Listado("Buscar_Producto", lst);
        }

        public String RegistrarProducto(byte[] foto)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Ref", Nombre));
                lst.Add(new ClsParametros("@Pre", Precio));
                lst.Add(new ClsParametros("@Cat", Categoria));
                lst.Add(new ClsParametros("@Stock", Stock));
                lst.Add(new ClsParametros("@Img", foto));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarProducto", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProducto(byte[] foto)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Ref", Nombre));
                lst.Add(new ClsParametros("@Pre", Precio));
                lst.Add(new ClsParametros("@Cat", Categoria));
                lst.Add(new ClsParametros("@Img", foto));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarProducto", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String eliminarProducto(String id)
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@IdPro", id));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("eliminarProducto", ref lst);
                return msj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String SalidaDeProductos()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Ref", Nombre));
                lst.Add(new ClsParametros("@Cantidad", Stock));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SalidaDeProductos", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
        public String RecuperarProductos()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Ref", Nombre));
                lst.Add(new ClsParametros("@Cantidad", Stock));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RecuperarProductos", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
