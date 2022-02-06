using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace veiculos
{
    public class CarroDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\veiculo.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public CarroDAO()
        {
            conexao.Open();
        }
        public String salvarCarro(Caro caro)
        {
            string resp = "";
            string sql = "";
            int retorno;
            try
            {
                sql = "INSERT INTO carros (desc_veiculos,val_veiculos,flex_veiculos) VALUES('" + caro.desc_veiculos + "','" + caro.val_veiculos + "','" + caro.flex_veiculos + "')";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    return "OK";
                }
                else
                {
                    return "Falha"+sql;
                }
            }catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            return resp;
        }
        public String AtualiazaCaro(Caro caro)
        {
            string resp = "";
            string sql = "";
            int retorno;
            try
            {
                sql = "UPDATE carros SET val_veiculos='" + caro.val_veiculos + "',flex_veiculos = '"+ caro.flex_veiculos + "' WHERE desc_veiculos = '"+ caro.desc_veiculos + "'";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    return "OK";
                }
                else
                {
                    return "Falha" + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            return resp;
        }
        public String ExcluirCaro(Caro caro)
        {
            string resp = "";
            string sql = "";
            int retorno;
            try
            {
                sql = "DELETE FROM carros WHERE desc_veiculos = '"+ caro.desc_veiculos + "'";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if(retorno > 0)
                {
                    return "OK";
                }
                else
                {
                    return "Falha" + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            return resp;
        }
    }
}