using System;
using System.Collections.Generic;
using CapaDeDatos;
using System.Data;
namespace CapaLogicaNegocio
{
    public class ClsUsuario:ClsPersona
    {
        private String usuario;
        private String contraseña;
        private int cargo;


        ClsManejador M = new ClsManejador();

        public string Nusuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public int Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        //Registrar Usuario
        public String RegistrarUsuario()
        {
            String msj="";
            List<ClsParametros> lst= new List<ClsParametros>();
            try
            {
                //Parametros de entrada
                lst.Add(new ClsParametros("@IdUsu", Identificacion));
                lst.Add(new ClsParametros("@Nom", Nombre));
                lst.Add(new ClsParametros("@Ape", Apellido));
                lst.Add(new ClsParametros("@Usu", Nusuario));
                lst.Add(new ClsParametros("@Pass", Contraseña));
                lst.Add(new ClsParametros("@Carg_Id", Cargo));
                //Parametros de salida
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarUsuario", ref lst);//Ejecutar Procedimiento guardado
                msj = lst[6].Valor.ToString();//Recuperar mensaje
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;
        }
        //Metodo para listar Usuarios
        public DataTable listadoUsuario()
        {
            return M.Listado("Listado_Usuarios", null);
        }
        //Metodo para Iniciar Sesión
        public String IniciarSesion()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Usu", Nusuario));
                lst.Add(new ClsParametros("@Pass", Contraseña));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("IniciarSesion",ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;

        }
        public DataTable DevolverDatosSesion(String user, String passwd)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Usu", user));
                return M.Listado("DevolverDatosSesion", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable cargarUsuario(String id)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@IdUsu", id));
                return M.Listado("cargarUsuario",lst);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public String eliminarUsuario(String id) {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@IdUsu", id));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("eliminarUsuarioAd", ref lst);
                return msj = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msj;
        }

        public String ModificarUsuario()
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //Parametros de entrada
                lst.Add(new ClsParametros("@IdUsu", Identificacion));
                lst.Add(new ClsParametros("@Nom", Nombre));
                lst.Add(new ClsParametros("@Ape", Apellido));
                lst.Add(new ClsParametros("@Usu", Nusuario));
                lst.Add(new ClsParametros("@Pass", Contraseña));
                lst.Add(new ClsParametros("@Carg_Id", Cargo));
                //Parametros de salida
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("ModificarUsuario", ref lst);//Ejecutar Procedimiento guardado
                msj = lst[6].Valor.ToString();//Recuperar mensaje
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;
        }

        public DataTable ListarCargo()
        {
            return M.Listado("ListarCargo", null);
        }
    }
}
