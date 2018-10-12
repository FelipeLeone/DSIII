using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using System.Data;
using System.Data.SqlClient;
using DAL_Restaurante;
namespace DAL_Restaurante
{
    public class Login_DAL
    {
        public static string ValidarLogin(Login_DTO obj)
        {
            try
            {
                string script = "SELECT * FROM TB_LOGIN WHERE USUARIO = @USUARIO AND SENHA = @SENHA";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                cm.Parameters.AddWithValue("@USUARIO", obj.Usuario);
                cm.Parameters.AddWithValue("@SENHA", obj.Senha);

                SqlDataReader dados = cm.ExecuteReader();

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        return "sucesso";
                    }
                }
                return "USUÁRIO OU SENHA INVÁLIDOS!";
            }
            catch
            {
                throw new Exception("PROBLEMAS NA CONEXÃO");
            }
        }
        
    }
}
