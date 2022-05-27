using System.ComponentModel.DataAnnotations;

namespace Hemolink.Models
{
    public class Agenda
    {
        [Key]
        public int IdAgendamento { get; set; }
        [Required]
        public DateTime Agendamento { get; set; }
        [Required]
        public Doador Id_Doador { get; set; } 


    }
}
