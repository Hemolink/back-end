using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Hemolink.Models
{
    public class Agenda
    {
        [Key]
        public int IdAgendamento { get; set; }
        [Required]
        public DateTime Agendamento { get; set; }
        [JsonIgnore]
        public Doador Doador { get; set; }
        [Required]
        public int DoadorId { get; set; } 


    }
}
