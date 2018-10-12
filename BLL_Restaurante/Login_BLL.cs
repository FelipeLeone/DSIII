using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Restaurante;
using BLL_Restaurante;
using DAL_Restaurante;
namespace BLL_Restaurante
{
   public class Login_BLL
    {
        public static string ValidarLogin(Login_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Usuario))
            {
                return "CAMPO USUÁRIO VAZIO!";
            }
            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                return "CAMPO SENHA VAZIO!";
            }
            return Login_DAL.ValidarLogin(obj);
        }
    }
}
