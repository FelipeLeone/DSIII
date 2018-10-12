using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using MySql.Data;
//using MySql.Data.MySqlClient;//serve para usar os comandos mysql
using DTO_Restaurante;


namespace DAL_Restaurante
{
    
        //criando classe de conexão para não ficar fazendo os codigos toda hora
        
        public class Conexao
        {
            public static SqlConnection Conectar()//criando metodo publico 
            {
                try //resovle problemas com excessoes tenta se der ecessão cai no catch
                {
                    SqlConnection conn = new SqlConnection
                    (@"Data Source=(localdb)\Projects;Initial Catalog=DB_RESTAURANTE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                    conn.Open();
                    return conn;
                }
                catch(Exception ex)
                {
                    throw new Exception ("Problemas na conexao!\n" + ex.Message);
                }
            }
        }

    }

