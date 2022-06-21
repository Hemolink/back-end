using System.ComponentModel.DataAnnotations;

namespace Hemolink.Data.Dtos.Questionario
{
    public class CreateQuestionarioDto
    {
        public int Id_Doador { get; set; }
        public bool BebidaAlcolica { get; set; }
        public bool ResfriadoGripado { get; set; }
        public bool Febre { get; set; }
        public bool DorPeito { get; set; }
        public bool TesteHiv { get; set; }
        public bool SuspeitaCovid { get; set; }
        public bool Desmaio { get; set; }
        public bool Convulsao { get; set; }
        public bool Derrame { get; set; }
        public bool Dengue { get; set; }
        public bool IST { get; set; }
        public bool Zika { get; set; }
        public bool Cancer { get; set; }
        public bool DrogasIlicitas { get; set; }
        public bool Fuma { get; set; }
        public bool SexoSemProtecao { get; set; }
        public bool Gravida { get; set; } 
        public bool SexoPago { get; set; }
        public bool SexoEntreHomens { get; set; }
        public bool Parto { get; set; }
        public bool Amamentando { get; set; }

    }
}
