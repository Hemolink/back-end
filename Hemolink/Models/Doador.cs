using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Hemolink.Models
{
    public class Doador
    {
        [Key]
        public int IdDoador { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }
        
        public string Senha { set; get; }
        [JsonIgnore]
        public Sangue Sangue { set; get; }
        [MaxLength (3)]
        public string SangueId { set; get; }
        [MaxLength (11)]
        public string CPF { get; set; }

        public DateTime UltimaDoacao { set; get; }
        
        [MaxLength (1)]
        public string Sexo { set; get; }   

        public float Peso { set; get; } 

    }
}
