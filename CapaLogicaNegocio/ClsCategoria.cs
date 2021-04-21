using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaLogicaNegocio
{
    public class ClsCategoria
    {
        ClsManejador M = new ClsManejador();
        private String categoria;

        public string Categoria
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

        public DataTable ListarCategoria()
        {
            return M.Listado("ListarCategoria", null);
        }

        public String RegistrarCategoria()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Categoria", Categoria));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarCategoria", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
