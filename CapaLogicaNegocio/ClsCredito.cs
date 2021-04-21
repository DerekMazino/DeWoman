using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsCredito
    {
        private int idCliente;
        private DateTime fecha;
        private int montoPagar;
        ClsManejador M = new ClsManejador();
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

        public int MontoPagar
        {
            get
            {
                return montoPagar;
            }

            set
            {
                montoPagar = value;
            }
        }
        public String RegistrarAbonoCredito()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@IdClie", IdCliente));
                lst.Add(new ClsParametros("@Fecha", Fecha));
                lst.Add(new ClsParametros("@MonPag", MontoPagar));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarAbonoCredito", ref lst);
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
