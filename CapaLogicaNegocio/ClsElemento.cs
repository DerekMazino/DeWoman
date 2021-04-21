using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsElemento
    {
        ClsManejador M = new ClsManejador();

        private String material;
        private int stock;

        public string Nombre
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public DataTable ListadoMateriales()
        {
            return M.Listado("ListarMateriales", null);
        }

        public DataTable BuscarMateruial(String objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", objDatos));
            return dt = M.Listado("Buscar_Material", lst);
        }

        public String RegistrarMaterial()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@NomMat", Nombre));
                lst.Add(new ClsParametros("@Stock", Stock));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarMaterial", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarMaterial(String id)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdMat", id));
                lst.Add(new ClsParametros("@NomMat", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarMaterial", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String eliminarMaterial(String id)
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@IdMat", id));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("eliminarMaterial", ref lst);
                return msj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
