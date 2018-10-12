using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using DAL_Restaurante;


namespace BLL_Restaurante
{
     public class Cadastro_BLL
    {
        public static string ValidarCadastro(Cadastro_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                return "CAMPO NOME VAZIO!";
            }
             try
            {
                int.Parse(obj.Numero);
            }
            catch
            {
                return "Campo numero deve ser um numero inteitro!";
            }
        //return "sucesso";
        return Cadastro_DAL.Cadastrar(obj);
        }
         
    }
}
