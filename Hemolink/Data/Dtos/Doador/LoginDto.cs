using System.ComponentModel.DataAnnotations;

namespace Hemolink.Data.Dtos.Doador
{
    public class LoginDto
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Senha { set; get; }

    }
}
