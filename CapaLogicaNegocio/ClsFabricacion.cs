using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsFabricacion
    {
        ClsManejador M = new ClsManejador();
        private int idProducto;
        private int idMaterial;
        private int cantidadActualProducto;
        private int cantidadActualMaterial;
        private int cantidadEntradaProductos;
        private int cantidadSalidaMateriales;
        private String referenciaProducto;
        private DateTime fecha;

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int IdMaterial
        {
            get
            {
                return idMaterial;
            }

            set
            {
                idMaterial = value;
            }
        }

        public int CantidadActualProducto
        {
            get
            {
                return cantidadActualProducto;
            }

            set
            {
                cantidadActualProducto = value;
            }
        }

        public int CantidadActualMaterial
        {
            get
            {
                return cantidadActualMaterial;
            }

            set
            {
                cantidadActualMaterial = value;
            }
        }

        public int CantidadEntradaProductos
        {
            get
            {
                return cantidadEntradaProductos;
            }

            set
            {
                cantidadEntradaProductos = value;
            }
        }

        public int CantidadSalidaMateriales
        {
            get
            {
                return cantidadSalidaMateriales;
            }

            set
            {
                cantidadSalidaMateriales = value;
            }
        }

        public string ReferenciaProducto
        {
            get
            {
                return referenciaProducto;
            }

            set
            {
                referenciaProducto = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public String RegistrarPROMAT()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@idPro", IdProducto));
                lst.Add(new ClsParametros("@idMat", IdMaterial));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarPROMAT", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String EntradaDeProductos()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Ref", ReferenciaProducto));
                lst.Add(new ClsParametros("@Cantidad", CantidadActualProducto+CantidadEntradaProductos));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("EntradaDeProductos", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String SalidaMateriales()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdMat", IdMaterial));
                lst.Add(new ClsParametros("@Cantidad", CantidadActualMaterial-CantidadSalidaMateriales));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SalidaMateriales", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String RegistrarSalMat()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@MatId", IdMaterial));
                lst.Add(new ClsParametros("@Fech", Fecha));
                lst.Add(new ClsParametros("@CanMat", CantidadSalidaMateriales));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarSalMat", ref lst);
                Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String RegistrarEntPro()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@ProId", IdProducto));
                lst.Add(new ClsParametros("@Fech", Fecha));
                lst.Add(new ClsParametros("@CanPro", CantidadEntradaProductos));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarEntPro", ref lst);
                Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
