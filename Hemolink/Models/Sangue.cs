using System.ComponentModel.DataAnnotations;

namespace Hemolink.Models
{
    public class Sangue
    {
        [Key, MaxLength(3)]
        public string tipo { get; set; }
        public float nivel_atual { get; set; }
        public bool prioritario { get; set; }
        public DateTime ultima_atualizacao { get; set; }


    }
}
