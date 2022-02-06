using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebComBanco
{
    public class AlunoDAO
    {
        SqlConnection conexao = new
        SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Alunos.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public AlunoDAO()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string salvarAluno(Aluno aluno)
        {
            string resp = "";
            string sql = "";
            int retorno;
            try
            {
                sql = "INSERT INTO dados(rgm, nome, nota1, nota2) VALUES('" + aluno.RGM + "','";
                sql += aluno.Nome + "'," + aluno.Nota1 + ", " + aluno.Nota2 + ")";
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


}