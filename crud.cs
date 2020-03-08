using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace asp4
{
    public class crud
    {
        //declaracion de variables para crear la conexion a la base de datos y la creacion 
        //de el CRUD.

        SqlConnection con = new SqlConnection("Data Source=192.168.0.5;Initial Catalog=asp4; User ID=sa; Password = fer123; Application Name=asp4");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;
        public SqlDataReader dr;
        //verificamos que la conexion a la base de datos sea exitosa
        //en caso contrario mandamos un mensaje de error
        public void Conectar()
        {
            try
            {
                con.Open();
                //  MessageBox.Show("conexion exitosa");
            }
            catch (Exception error)
            {

                // MessageBox.Show(" ah ocurrido un eror en la conexion " + error);
            }
            finally
            {
                con.Close();
            }
        }
        public void desconectar()
        {
            con.Close();
        }
        public bool Gestion(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Cerrar()
        {
            con.Close();
        }
        public void LlenarGrid(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public void consultarTex(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
        }
    }
}