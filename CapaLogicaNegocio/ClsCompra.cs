using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;
namespace CapaLogicaNegocio
{
    public class ClsCompra
    {
        ClsManejador M = new ClsManejador();
        private String idUsuario;
        private String idProveedor;
        private DateTime fecha;
        private int totalPagar;
        private int idMaterial;
        private int idCompra;
        private int cantidad;
        private int valorMaterial;

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

        public string IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
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

        public int IdCompra
        {
            get
            {
                return idCompra;
            }

            set
            {
                idCompra = value;
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

        public int ValorMaterial
        {
            get
            {
                return valorMaterial;
            }

            set
            {
                valorMaterial = value;
            }
        }
        public String GenerarIdCompra()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            int objIdVenta;
            try
            {
                lst.Add(new ClsParametros("@IdCom", "", SqlDbType.Int, ParameterDirection.Output, 4));
                M.EjecutarSP("GenerarIdCompraC", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }

        public String RegistrarCompra()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdUsuario", IdUsuario));
                lst.Add(new ClsParametros("@IdProveedor", idProveedor));
                lst.Add(new ClsParametros("@Fecha", Fecha));
                lst.Add(new ClsParametros("@TotalPagar", TotalPagar));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarCompra", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String RegistrarDetalleCompra()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdMaterial", IdMaterial));
                lst.Add(new ClsParametros("@IdCompra", IdCompra));
                lst.Add(new ClsParametros("@Cantidad", Cantidad));
                lst.Add(new ClsParametros("@valorMaterial", ValorMaterial));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarDetalleCompra", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
