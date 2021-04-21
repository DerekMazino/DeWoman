using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    static class ClsSeguridad
    {

        public static String Encriptar(String password) {
            String resultado = String.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            resultado = Convert.ToBase64String(encryted);
            return resultado;
        }

        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

    }
}
