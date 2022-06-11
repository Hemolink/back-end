using System.ComponentModel.DataAnnotations;

namespace Hemolink.Models
{
    public class Questionario
    {
        [Key]
        public int IdFormulario { get; set; }
        public Doador Id_Doador { get; set; }
        public DateTime DataPreenchimento { get; set; } = DateTime.Now;
        public bool BebidaAlcolica { get; set; }
        public bool ResfriadoGripado { get; set; }
        public bool Febre { get; set; }
        public bool DorPeito { get; set; }
        public bool DoencaCronica { get; set; }
        public string DoencaGrave { get; set; }
        public bool ExtracaoDentaria { get; set; }
        public bool CirurgiaOdontologica { get; set; }  
        public string RemedioControlado { get; set; }
        public bool Vacinou { get; set; }   
        public bool RecebeuTransfusao { get; set; } 
        public bool RecebeuPlasma { get; set; } 
        public bool RecebeuPlaquetas { get; set; } 
        public bool Tatuagem { get; set; } 
        public bool Piercing { get; set; } 
        public bool Acupuntura { get; set; } 
        public bool BioAcidente { get; set; } 
        public bool AnestesiaGeral { get; set; } 
        public bool JaOperado { get; set; } 
        public bool TransplanteOrgao { get; set; } 
        public bool ProcedimentoEndoscopico { get; set; } 
        public bool TesteHiv { get; set; } 
        public bool JaFoiPreso { get; set; } 
        public bool ViagemExterior { get; set; } 
        public bool Desmaio { get; set; } 
        public bool Convulsao { get; set; } 
        public bool AVC { get; set; } 
        public bool Derrame { get; set; } 
        public bool Dengue { get; set; } 
        public bool Zika{ get; set; } 
        public bool Chikungunya { get; set; } 
        public bool Diabetes { get; set; } 
        public bool Hepatite { get; set; } 
        public bool IST { get; set; } 
        public bool Asma { get; set; } 
        public bool Bronquite { get; set; }
        [MaxLength (100)]
        public string Alergia { get; set; } 
        public bool ChoqueAnafilatico { get; set; } 
        public bool Cancer { get; set; } 
        public bool Tumor { get; set; } 
        public bool Leucemia { get; set; } 
        public bool VacaLouca { get; set; } 
        public bool Ferida { get; set; } 
        public bool Coceira { get; set; } 
        public bool DrogasIlicitas { get; set; } 
        public bool SexoSemProtecao { get; set; } 
        public bool SexualmenteAtivo { get; set; } 
        public bool SexoPago { get; set; } 
        public int ParceirosSexuais { get; set; } 
        public bool RelacaoCasaMassagem{ get; set; } 
        public bool RelacaoCasaSwing { get; set; } 
        public bool RelacaoCasaProstituicao { get; set; } 
        public bool SexoEntreHomens { get; set; } 
        public bool RelacaoHomemHomem { get; set; } 
        public bool Gravida { get; set; } 
        public int Gravidezes { get; set; } 
        public bool Parto { get; set; } 
        public bool Aborto { get; set; } 
        public bool Amamentando { get; set; } 
        public bool Fuma { get; set; } 
        public bool SuspeitaCovid { get; set; }
        [MaxLength (500)]
        public bool Observacoes { get; set; } 





    }
}
