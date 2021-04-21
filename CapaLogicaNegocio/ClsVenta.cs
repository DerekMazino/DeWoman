using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsVenta
    {
        ClsManejador M = new ClsManejador();
        private String idUsuario;
        private int idCliente;
        private DateTime fecha;
        private int tipoPago;
        private int totalPagar;
        private int idProducto;
        private int idVenta;
        private int cantidad;

        public string IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
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

        public int TipoPago
        {
            get
            {
                return tipoPago;
            }

            set
            {
                tipoPago = value;
            }
        }

        public int TotalPagar
        {
            get
            {
                return totalPagar;
            }

            set
            {
                totalPagar = value;
            }
        }

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

        public int IdVenta
        {
            get
            {
                return idVenta;
            }

            set
            {
                idVenta = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public String RegistrarVenta()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdUsuario", IdUsuario));
                lst.Add(new ClsParametros("@IdCliente", IdCliente));
                lst.Add(new ClsParametros("@Fecha", Fecha));
                lst.Add(new ClsParametros("@TipPag", TipoPago));
                lst.Add(new ClsParametros("@TotalPagar", TotalPagar));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarVenta", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String RegistrarDetalleVenta()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdProducto", IdProducto));
                lst.Add(new ClsParametros("@IdVenta", IdVenta));
                lst.Add(new ClsParametros("@Cantidad", Cantidad));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarDetalleVenta", ref lst);
                Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
        public String GenerarIdVenta()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            int objIdVenta;
            try
            {
                lst.Add(new ClsParametros("@IdVenta", "", SqlDbType.Int, ParameterDirection.Output, 4));
                M.EjecutarSP("GenerarIdVenta", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }
        public DataTable ListarTipoPago()
        {
            return M.Listado("ListarTipoPago", null);
        }

        public String PagarVentaCredito()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Saldo", TotalPagar));
                lst.Add(new ClsParametros("@IdCliente", IdCliente));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("PagarVentaCredito", ref lst);
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
