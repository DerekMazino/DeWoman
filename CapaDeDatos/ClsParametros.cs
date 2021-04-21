using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDeDatos
{
    public class ClsParametros
    {
        //ATRIBUTOS - CARACTERISTICAS DE UN PARAMETRO
        private String nombre;//NOMBRE DEL CAMPO
        private Object valor;//INFORMACIÓN ALMACENADA DENTRO DEL CAMPO
        private SqlDbType tipoDato;//TIPO DE DATO DE SQL (INT, VARCHAR, DATE, ETC)
        private ParameterDirection direccion;//SI RETORNA O ENVIA INFORMACIÓN
        private Int32 tamaño;//TAMAÑO EN MEMORIA (EJM VARCHAR(50))

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public object Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public SqlDbType TipoDato
        {
            get
            {
                return tipoDato;
            }

            set
            {
                tipoDato = value;
            }
        }

        public ParameterDirection Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
            }
        }

        //PROPIEDADES DE CADA ATRIBUTO

        //CONSTRUCTORES
        //CONSTRUCTOR DE ENTRADA
        public ClsParametros(String objNombre,Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;//DIRECCION ENTRADA
        }
        //CONSTRUCTOR DE SALIDA
        public ClsParametros(String objNombre,Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, Int32 objTamaño)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            Direccion = objDireccion;//DIRECCION SALIDA
        }
    }
}
