using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsDetalleVenta
    {
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public string RefProducto { get; set; }
        public int PrecioVenta { get; set; }
        public int IdProducto { get; set; }

        public ClsDetalleVenta()
        {
            Cantidad = 0;
            RefProducto = "";
            PrecioVenta = 0;
            IdVenta = 0;
            IdProducto = 0;
        }

        public ClsDetalleVenta(int objIdVenta, int objCantidad, string objRefProducto, int objPVenta,
           int objIdProducto)
        {
            IdVenta = objIdVenta;
            Cantidad = objCantidad;
            RefProducto = objRefProducto;
            PrecioVenta = objPVenta;
            IdProducto = objIdProducto;
        }

    }
}
