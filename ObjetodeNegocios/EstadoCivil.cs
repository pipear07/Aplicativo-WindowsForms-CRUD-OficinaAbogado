﻿using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ObjetodeNegocios
{
   public class EstadoCivil
    {

        
       #region Propiedades
       Int32 idEstadoCivil;

        public Int32 IdEstadoCivil
        {
            get { return idEstadoCivil; }
            set { idEstadoCivil = value; }
        }
        string TipoEstadoCivil;

        public string TipoEstadoCivil1
        {
            get { return TipoEstadoCivil; }
            set { TipoEstadoCivil = value; }
        }

        #endregion

        #region Constructores
        public EstadoCivil()
        { }
        #endregion

        #region Metodos
        public DataTable Seleccionar()
        {
            DataTable dtTipos = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultarEstadoCivil", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtTipos.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception exi) { }
            finally { objconexion.desconectar(); }
            return dtTipos;
        }


        public void SeleccionarId()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultaridEstadoCivil",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdEstadoCivil", SqlDbType.Int).Value = idEstadoCivil;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idEstadoCivil = Convert.ToByte(dr["IdEstadoCivil"]);
                    TipoEstadoCivil = dr["Estado Civil"].ToString();
                }
                dr.Close();
                objconexion.desconectar();

            }
            catch (Exception exew) { }
            finally { objconexion.desconectar(); }
        }



        public bool Insertar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proInsertarEstadoCivil",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdTiposIdentificacion",
               SqlDbType.SmallInt).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Estado Civil", SqlDbType.VarChar).Value = TipoEstadoCivil;
                cmd.ExecuteNonQuery();
                idEstadoCivil = Convert.ToByte((cmd.Parameters["IdEstadoCivil"].Value).ToString());
                if (idEstadoCivil != 0)
                {
                    resultado = true;
                }
                objconexion.desconectar();
            }
            catch (Exception exqw) { }
            finally { objconexion.desconectar(); }
            return resultado;
        }


        public bool Editar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proActualizarEstadoCivil",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdTiposIdentificacion", SqlDbType.SmallInt).Value = idEstadoCivil;
                cmd.Parameters.Add("Estado Civil", SqlDbType.VarChar).Value = TipoEstadoCivil;
                int intRestultado = 0;
                intRestultado = cmd.ExecuteNonQuery();
                if (intRestultado != 0)
                {
                    resultado = true;
                }
            }
            catch (Exception exwq) { }
            finally { objconexion.desconectar(); }
            return resultado;
        }



        public bool Eliminar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proEliminarEstadoCivil", objconexion.Sqlconection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdEstadoCivil", SqlDbType.SmallInt).Value = idEstadoCivil;
                int intRestultado = 0;
                intRestultado = cmd.ExecuteNonQuery();
                if (intRestultado != 0)
                {
                    resultado = true;
                }
            }
            catch (Exception exqs) { }
            finally { }
            return resultado;
        }


        #endregion
 
   }
}
