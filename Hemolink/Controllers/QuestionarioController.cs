using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemolink.Models;
using Hemolink.Data;
using Hemolink.Data.Dtos.Questionario;
namespace Hemolink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionarioController : Controller
    {
        private readonly _DbContext _context;

        public QuestionarioController(_DbContext context)
        {
            _context = context;
        }

        // GET: api/Questionario
        [HttpGet]
        public async Task<ActionResult<List<Questionario>>> Getquestionario()
        {
            if (_context.questionario == null)
            {
                return NotFound();
            }
            return await _context.questionario.ToListAsync();
        }

        // GET: api/Questionario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Questionario>> GetQuestionario(int id)
        {
            if (_context.questionario == null)
            {
                return NotFound();
            }
            var questionario = await _context.questionario.FindAsync(id);

            if (questionario == null)
            {
                return NotFound();
            }

            return questionario;
        }

        // PUT: api/Questionario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutQuestionario(int id, UpdateQuestionarioDto request)
        {
            var doador = await _context.doador.FindAsync(request.Id_Doador);
            if (doador == null)
                return NotFound("Doador not found...");


            var questionario = new Questionario
            {
                IdFormulario = request.IdFormulario,
                Id_Doador = request.Id_Doador,
                DataPreenchimento = DateTime.UtcNow,
                BebidaAlcolica = request.BebidaAlcolica,
                ResfriadoGripado = request.ResfriadoGripado,
                Febre = request.Febre,
                DorPeito = request.DorPeito,
                DoencaCronica = request.DoencaCronica,
                DoencaGrave = request.DoencaGrave,
                ExtracaoDentaria = request.ExtracaoDentaria,
                CirurgiaOdontologica = request.CirurgiaOdontologica,
                RemedioControlado = request.RemedioControlado,
                Vacinou = request.Vacinou,
                RecebeuTransfusao = request.RecebeuTransfusao,
                RecebeuPlasma = request.RecebeuPlasma,
                RecebeuPlaquetas = request.RecebeuPlaquetas,
                Tatuagem = request.Tatuagem,
                Piercing = request.Piercing,
                Acupuntura = request.Acupuntura,
                BioAcidente = request.BioAcidente,
                AnestesiaGeral = request.AnestesiaGeral,
                JaOperado = request.JaOperado,
                TransplanteOrgao = request.TransplanteOrgao,
                ProcedimentoEndoscopico = request.ProcedimentoEndoscopico,
                TesteHiv = request.TesteHiv,
                JaFoiPreso = request.JaFoiPreso,
                ViagemExterior = request.ViagemExterior,
                Desmaio = request.Desmaio,
                Convulsao = request.Convulsao,
                AVC = request.AVC,
                Derrame = request.Derrame,
                Dengue = request.Dengue,
                Zika = request.Zika,
                Chikungunya = request.Chikungunya,
                Diabetes = request.Diabetes,
                Hepatite = request.Hepatite,
                IST = request.IST,
                Asma = request.Asma,
                Bronquite = request.Bronquite,
                Alergia = request.Alergia,
                ChoqueAnafilatico = request.ChoqueAnafilatico,
                Cancer = request.Cancer,
                Tumor = request.Tumor,
                Leucemia = request.Leucemia,
                VacaLouca = request.VacaLouca,
                Ferida = request.Ferida,
                Coceira = request.Coceira,
                DrogasIlicitas = request.DrogasIlicitas,
                SexoSemProtecao = request.SexoSemProtecao,
                SexualmenteAtivo = request.SexualmenteAtivo,
                SexoPago = request.SexoPago,
                ParceirosSexuais = request.ParceirosSexuais,
                RelacaoCasaMassagem = request.RelacaoCasaMassagem,
                RelacaoCasaSwing = request.RelacaoCasaSwing,
                RelacaoCasaProstituicao = request.RelacaoCasaProstituicao,
                SexoEntreHomens = request.SexoEntreHomens,
                RelacaoHomemHomem = request.RelacaoHomemHomem,
                Gravida = request.Gravida,
                Gravidezes = request.Gravidezes,
                Parto = request.Parto,
                Aborto = request.Aborto,
                Amamentando = request.Amamentando,
                Fuma = request.Fuma,
                SuspeitaCovid = request.SuspeitaCovid,
                Observacoes = request.Observacoes,
                Doador = doador
            };

            if (id != questionario.IdFormulario)
            {
                return BadRequest("Id is not the same on the JSON... ");
            }

            _context.Entry(questionario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            if (questionario.SuspeitaCovid || questionario.IST || questionario.Cancer || questionario.Leucemia || questionario.TesteHiv || questionario.Tatuagem || questionario.Piercing)
                return Unauthorized("Você ***NÃO*** pode doar no momento... Tente novamente em 3 meses");

            return Ok(questionario);
        }

        // POST: api/Questionario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Questionario>> PostQuestionario(CreateQuestionarioDto request)
        {
            var doador = await _context.doador.FindAsync(request.Id_Doador);
            if (doador == null)
                return NotFound("Doador not found...");

            var questionario = new Questionario
            {
                Id_Doador = request.Id_Doador,
                DataPreenchimento = DateTime.UtcNow,
                BebidaAlcolica = request.BebidaAlcolica,
                ResfriadoGripado = request.ResfriadoGripado,
                Febre = request.Febre,
                DorPeito = request.DorPeito,
                DoencaCronica = request.DoencaCronica,
                DoencaGrave = request.DoencaGrave,
                ExtracaoDentaria = request.ExtracaoDentaria,
                CirurgiaOdontologica = request.CirurgiaOdontologica,
                RemedioControlado = request.RemedioControlado,
                Vacinou = request.Vacinou,
                RecebeuTransfusao = request.RecebeuTransfusao,
                RecebeuPlasma = request.RecebeuPlasma,
                RecebeuPlaquetas = request.RecebeuPlaquetas,
                Tatuagem = request.Tatuagem,
                Piercing = request.Piercing,
                Acupuntura = request.Acupuntura,
                BioAcidente = request.BioAcidente,
                AnestesiaGeral = request.AnestesiaGeral,
                JaOperado = request.JaOperado,
                TransplanteOrgao = request.TransplanteOrgao,
                ProcedimentoEndoscopico = request.ProcedimentoEndoscopico,
                TesteHiv = request.TesteHiv,
                JaFoiPreso = request.JaFoiPreso,
                ViagemExterior = request.ViagemExterior,
                Desmaio = request.Desmaio,
                Convulsao = request.Convulsao,
                AVC = request.AVC,
                Derrame = request.Derrame,
                Dengue = request.Dengue,
                Zika = request.Zika,
                Chikungunya = request.Chikungunya,
                Diabetes = request.Diabetes,
                Hepatite = request.Hepatite,
                IST = request.IST,
                Asma = request.Asma,
                Bronquite = request.Bronquite,
                Alergia = request.Alergia,
                ChoqueAnafilatico = request.ChoqueAnafilatico,
                Cancer = request.Cancer,
                Tumor = request.Tumor,
                Leucemia = request.Leucemia,
                VacaLouca = request.VacaLouca,
                Ferida = request.Ferida,
                Coceira = request.Coceira,
                DrogasIlicitas = request.DrogasIlicitas,
                SexoSemProtecao = request.SexoSemProtecao,
                SexualmenteAtivo = request.SexualmenteAtivo,
                SexoPago = request.SexoPago,
                ParceirosSexuais = request.ParceirosSexuais,
                RelacaoCasaMassagem = request.RelacaoCasaMassagem,
                RelacaoCasaSwing = request.RelacaoCasaSwing,
                RelacaoCasaProstituicao = request.RelacaoCasaProstituicao,
                SexoEntreHomens = request.SexoEntreHomens,
                RelacaoHomemHomem = request.RelacaoHomemHomem,
                Gravida = request.Gravida,
                Gravidezes = request.Gravidezes,
                Parto = request.Parto,
                Aborto = request.Aborto,
                Amamentando = request.Amamentando,
                Fuma = request.Fuma,
                SuspeitaCovid = request.SuspeitaCovid,
                Observacoes = request.Observacoes,
                Doador = doador
            };

            _context.questionario.Add(questionario);
            await _context.SaveChangesAsync();

            if (questionario.SuspeitaCovid || questionario.IST || questionario.Cancer || questionario.Leucemia || questionario.TesteHiv || questionario.Tatuagem || questionario.Piercing)
                return Unauthorized("Você ***NÃO*** pode doar no momento... Tente novamente em 3 meses");

            return Ok(questionario);
        }

        // DELETE: api/Questionario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteQuestionario(int id)
        {
            if (_context.questionario == null)
            {
                return NotFound();
            }
            var questionario = await _context.questionario.FindAsync(id);
            if (questionario == null)
            {
                return NotFound();
            }

            _context.questionario.Remove(questionario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestionarioExists(int id)
        {
            return (_context.questionario?.Any(e => e.IdFormulario == id)).GetValueOrDefault();
        }
    }
}
