using System.ComponentModel.DataAnnotations;

namespace Hemolink.Data.Dtos.Doador
{
    public class LoginDto
    {
        public int IdDoador { get; set; }
        public string Senha { set; get; }

    }
}
