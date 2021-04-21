using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte
{
    static class Program
    {
        //Variables Cliente
        public static int idCliente;
        public static string cedulaCliente;
        public static string nombreCliente;
        public static string apellidoCliente;
        //Evento entre registrar y actualizar
        public static int Evento;
        public static int EventoCompraVentaFabricacion;

        //Variales para producto
        public static int idProducto;
        public static String nomProducto;
        public static int stockProducto;
        public static int precioProducto;
        //Variables Proveedores
        public static int idProveedor;
        public static String nit;
        public static String razsoc;
        //Variables para Materiales
        public static int idmaterial;
        public static String material;
        public static int stockMaterial;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static String idUsuario;
        public static String nombreUsu;
        public static String tipoUsuario;
        public static int idCargo;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
