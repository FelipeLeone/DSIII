using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using System.Data;
using System.Data.SqlClient;
using DAL_Restaurante;
//using MySql.Data;
//using MySql.Data.MySqlClient;

namespace DAL_Restaurante
{
    public class Cadastro_DAL
    {
        public static string Cadastrar(Cadastro_DTO obj)
        {
            try
            {


                string sql = "INSERT INTO FUNCIONARIO (NOME, RG, CPF, ENDERECO, NUMERO," +
                    "BAIRRO, CIDADE, BANCO, AGENCIA, CONTA, TEL) VALUES" +
                    "(@Nome, @RG, @CPF, @Endereco, @numero, @Bairro, @Cidade," +
                    "@Banco, @Agencia, @Conta, @Tel)";

                SqlCommand cm = new SqlCommand(sql, Conexao.Conectar());

                cm.Parameters.AddWithValue("@Nome", obj.Nome);
                cm.Parameters.AddWithValue("@RG", obj.RG);
                cm.Parameters.AddWithValue("@CPF", obj.CPF);
                cm.Parameters.AddWithValue("@Endereco", obj.Endereco);
                cm.Parameters.AddWithValue("@numero", obj.Numero);
                cm.Parameters.AddWithValue("@Bairro", obj.Bairro);
                cm.Parameters.AddWithValue("@Cidade", obj.Cidade);
                cm.Parameters.AddWithValue("@Banco", obj.Banco);
                cm.Parameters.AddWithValue("@Agencia", obj.Agencia);
                cm.Parameters.AddWithValue("@Conta", obj.Conta);
                cm.Parameters.AddWithValue("@Tel", obj.Telefone);
                SqlDataReader dados = cm.ExecuteReader();


                cm.ExecuteNonQuery();
                return "Cadastro com sucesso";


            }
            catch (Exception abacate)
            {
                throw new Exception("Problemas na conexão!" + abacate.Message);
            }
            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }


            }


        }
    }
}
