using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cookie
{
    public string ValidaUsuario(Usuario usuario)
    {
        SqlConnection conexao = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security = True");
        SqlCommand cmd;

        string resp = "";
        string sql = "";
        try
        {
            conexao.Open();
            SqlDataReader dr;
            sql = "SELECT id FROM usuarios WHERE login='" + usuario.Login + "' AND senha='" + usuario.Senha + "'";
            cmd = new SqlCommand(sql, conexao);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                resp = dr["id"].ToString();
            }
            else
            {
                resp = "ERRO";
            }
            dr.Close();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            resp = "ERRO: " + ex.ToString() + " SQL: " + sql;
        }
        return resp;
    }
}
}