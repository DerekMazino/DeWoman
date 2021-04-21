using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;
namespace CapaLogicaNegocio
{
    public class ClsCargo
    {
        private String nCargo;
        private ClsManejador clsM = new ClsManejador();
        public string NCargo { get => nCargo; set => nCargo = value; }

        public DataTable ListarCargo()
        {
            return clsM.Listado("ListarCargo", null);
        }
    }
}
