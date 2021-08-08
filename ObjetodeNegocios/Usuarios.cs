using System;
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
    public class Usuarios
    {
#region Propiedades
      
        Int32 idUsuario;//usuario

public Int32 IdUsuario
{
  get { return idUsuario; }
  set { idUsuario = value; }
}

      Int32    idContacto;//contacto

public Int32 IdContacto
{
  get { return idContacto; }
  set { idContacto = value; }
}


      Int32        idTipoUsuario;// tipousuario

public Int32 IdTipoUsuario
{
  get { return idTipoUsuario; }
  set { idTipoUsuario = value; }
}


      Int32        idEstadoCivil; //estadocivil

public Int32 IdEstadoCivil
{
  get { return idEstadoCivil; }
  set { idEstadoCivil = value; }
}

String TipoEstadoCivil;

public String TipoEstadoCivil1
{
    get { return TipoEstadoCivil; }
    set { TipoEstadoCivil = value; }
}


         String   NombreP;//nombre

public String NombreP1
{
  get { return NombreP; }
  set { NombreP = value; }
}

        String     NombreS; //segundo nombre

public String NombreS1
{
  get { return NombreS; }
  set { NombreS = value; }
}

       String      ApellidoA; //primer apellido

public String ApellidoA1
{
  get { return ApellidoA; }
  set { ApellidoA = value; }
}
      
        String      ApellidoS; //segundo apellido

public String ApellidoS1
{
  get { return ApellidoS; }
  set { ApellidoS = value; }
}

      String       NumeroIdentificacion; //cedula o nit

public String NumeroIdentificacion1
{
  get { return NumeroIdentificacion; }
  set { NumeroIdentificacion = value; }
}

     String        NombreEmpresa;//empresa

public String NombreEmpresa1
{
  get { return NombreEmpresa; }
  set { NombreEmpresa = value; }
}


       String      Direccion;//direccion

public String Direccion1
{
  get { return Direccion; }
  set { Direccion = value; }
}
#endregion

           #region Constructores
        public Usuarios()
        { }

        public Usuarios(int pIdUsuarios)
        {
             idUsuario = pIdUsuarios;
             SeleccionarId();
        }

        #endregion


         #region Metodos
        public DataTable Seleccionar()
        {

            DataTable dtUsuarios = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proConsultarUsuarios",objconexion.Sqlconection);
            
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtUsuarios.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtUsuarios;
        }

        public DataTable SeleccionarPersonalizado()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proConsultarPersonas", objconexion.Sqlconection);
                SqlCommand cmd2 = new SqlCommand("proConsultarGrupoSanguineo", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                using (IDataReader dr2 = cmd2.ExecuteReader())
                { dtPersonas.Load(dr2); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtPersonas;
        }
        
        
        public void SeleccionarId()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultaridUsuarios", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdUsuario", SqlDbType.Int).Value = idUsuario;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                       idUsuario = Convert.ToInt32(dr["IdUsuario"]); //llamar la normal y el encapsulado; 
                       idEstadoCivil = Convert.ToInt32(dr["idEstadoCivil"]);
                    TipoEstadoCivil1 = dr["Estado Civil"].ToString();
               //       idContacto = Convert.ToInt32(dr["IdContacto"]);
              //      idTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
              //      idEstadoCivil = Convert.ToInt32(dr["IdEstadoCivil"]);                  
                    //   strTipoDocumento = dr["StrTipoDocumento"].ToString();
                       NombreP = dr["Primer Nombre"].ToString();
                       NombreS = dr["Segundo Nombre"].ToString();
                       ApellidoA = dr["Primer Apellido"].ToString();
                       ApellidoS = dr["Segundo Apellido"].ToString();
                       NumeroIdentificacion = dr["Numero de Identidad"].ToString();
                       NombreEmpresa = dr["Empresa"].ToString();
                       Direccion = dr["Direccion"].ToString();
                      
                       
                     
                      
                }

              dr.Close();
              objconexion.desconectar();
            }
            catch (Exception ex) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }



        }

        /* ACABARLO!!!!
        public void SeleccionarCedula()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proPersonasConsultarNumeroDocumento", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento1;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idPersona = Convert.ToInt32(dr["IdPersona"]); //llamar la normal y el encapsulado;
                   // idTipoDocumento = Convert.ToInt16(dr["Tipo"]);
                    //idEstadoCivil = Convert.ToInt16(dr["Estado Civil"]);
                    //strTipoDocumento = dr["StrTipoDocumento"].ToString();
                 //   PNombre = dr["PNombre"].ToString();
                   // SNombre = dr["SNombre"].ToString();
                    //PApellido = dr["PApellido"].ToString();
                    //SApellido = dr["SApellido"].ToString();
                    NumeroDocumento = dr["NumeroDocumento"].ToString();
                    Direccion = dr["Direccion"].ToString();
                    TelefonoMovil = dr["TelefonoMovil"].ToString();
                    TelefonoFijo = dr["TelefonoFijo"].ToString();
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                }
                dr.Close();
                objconexion.desconectar();
            }
            catch (Exception exr) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }
        }
        */

        public DataTable SeleccionarCedula1()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proPersonasConsultarNumeroDocumento", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
             //   cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtPersonas;
        }



        public bool Insertar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proInsertarUsuarios",objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("IdContacto", SqlDbType.Int).Value = 1;//IdContacto;
                cmd.Parameters.Add("IdTipoUsuario", SqlDbType.Int).Value = 1;// IdTipoUsuario;
                cmd.Parameters.Add("IdEstadoCivil", SqlDbType.Int).Value = 1;// IdEstadoCivil;
                cmd.Parameters.Add("NombreP", SqlDbType.VarChar).Value = NombreP1;
                cmd.Parameters.Add("NombreS", SqlDbType.VarChar).Value = NombreS1;
                cmd.Parameters.Add("ApellidoP", SqlDbType.VarChar).Value = ApellidoA1;
                cmd.Parameters.Add("ApellidoS", SqlDbType.VarChar).Value = ApellidoS1;
                 cmd.Parameters.Add("NumeroIdentificacion", SqlDbType.VarChar).Value = NumeroIdentificacion1;
                cmd.Parameters.Add("NombreEmpresa", SqlDbType.VarChar).Value = NombreEmpresa1;
                cmd.Parameters.Add("Direccion", SqlDbType.VarChar).Value = Direccion;
    
                cmd.ExecuteNonQuery();
                
                idUsuario = Convert.ToInt32((cmd.Parameters["IdUsuario"].Value).ToString());
                if (idUsuario != 0)
                {
                    resultado = true;
                    objconexion.desconectar();
                }
                }
                 catch (Exception exe)
                {

                objconexion.desconectar();

            }
            return resultado;
            //}
        }


        public bool Editar()
 {
 bool resultado = false;
 Conexion objconexion = new Conexion();
 try
 {
 objconexion.conectar();
// SqlTransaction ObjTransaccion = objconexion.Sqlconection.BeginTransaction();
     SqlCommand cmd = new SqlCommand("proActualizarUsuarios",objconexion.Sqlconection);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = IdUsuario; //CUIDADO CON EL NOMBRE DE LAS VARIABLES DEL PROCEDIMIENTO ALMACENADO, ME LANZO ERROR EL IDPERSONA Y ES QUE ERA QUE ESTABA MAL ESCRITO EN EL PROCEDIMIENTO COMO IDPERSONA Y ERA LLAMADO COMO IDPERSONAS
 cmd.Parameters.Add("idContacto", SqlDbType.Int).Value = IdContacto;
 cmd.Parameters.Add("idTipoUsuario", SqlDbType.Int).Value = IdTipoUsuario;
 cmd.Parameters.Add("idEstadoCivil", SqlDbType.VarChar).Value = IdEstadoCivil;
 cmd.Parameters.Add("NombreP", SqlDbType.VarChar).Value =  NombreP1;
 cmd.Parameters.Add("NombreS", SqlDbType.VarChar).Value = NombreS1;
 cmd.Parameters.Add("ApellidoP", SqlDbType.VarChar).Value = ApellidoA1;
 cmd.Parameters.Add("ApellidoS", SqlDbType.VarChar).Value = ApellidoS1;
 cmd.Parameters.Add("NumeroIdentificacion", SqlDbType.VarChar).Value = NumeroIdentificacion1;
 cmd.Parameters.Add("NombreEmpresa", SqlDbType.VarChar).Value =NombreEmpresa1;
 cmd.Parameters.Add("Direccion", SqlDbType.DateTime).Value = Direccion1;

 int intRestultado = 0;
 intRestultado = cmd.ExecuteNonQuery();
 if (intRestultado != 0)
 {
     resultado = true;
     objconexion.desconectar();
 }
 }
 catch (Exception exqw)
 {
     objconexion.desconectar();
 }
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
 SqlCommand cmd = new SqlCommand("proEliminarUsuarios",objconexion.Sqlconection);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value =IdUsuario;
 int intRestultado = 0;
 intRestultado = cmd.ExecuteNonQuery();
 if (intRestultado != 0)
 {
 resultado = true;
 }
 }
 catch (Exception ex) { objconexion.desconectar(); }
 finally { objconexion.desconectar(); }
 return resultado;
 }

 }
}


        #endregion

    

