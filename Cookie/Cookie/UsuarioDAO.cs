using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cookie
{
    public class UsuarioDAO//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True
    {
        SqlConnection conexao = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security = True");
        SqlCommand cmd;
        public string salvarUsuario(Usuario usuario)
        {
            string resp = "";
            string sql = "";
            int retorno;
            try
            {
                conexao.Open();
                sql = "INSERT INTO usuarios(login, senha) VALUES('" + usuario.Login + "','" + usuario.Senha + "')";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    return "OK";
                }
                else
                {
                    return "Falha ao inserir o registro: " + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + " SQL: " + sql;
            }
            return resp;
        }
    }