using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsDetalleCompra
    {
        public int IdCompra { get; set; }
        public int Cantidad { get; set; }
        public string Material { get; set; }
        public int PrecioCompra { get; set; }
        public int IdMaterial { get; set; }

        public ClsDetalleCompra()
        {
            IdCompra = 0;
            Cantidad = 0;
            Material = "";
            PrecioCompra = 0;
            IdMaterial = 0;
        }
        public ClsDetalleCompra(int objIdCompra, int objCantidad, string objMaterial, int objPCompra,
           int objIdMaterial)
        {
            IdCompra = objIdCompra;
            Cantidad = objCantidad;
            Material = objMaterial;
            PrecioCompra = objPCompra;
            IdMaterial = objIdMaterial;
        }
    }
}
