using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAutenticacaoBasica.Api.Controllers.Data;
using ProjetoAutenticacaoBasica.Api.Controllers.Models.DTOs;

namespace ProjetoAutenticacaoBasica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VoosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CriarVoo(CriarVooDto voo)
        {
           var novoVoo = new Models.Voo
           {
               Codigo = voo.Codigo,
               Origem = voo.Origem,
               Destino = voo.Destino
           };
            _context.Voos.Add(novoVoo);
            await _context.SaveChangesAsync();
            return Ok("Voo criado com sucesso!");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResumoVooDto>>> GetVoos()
        {
            var voos = await _context.Voos.AsNoTracking().OrderBy(v => v.Id).Select(v => new ResumoVooDto
            {
                Id = v.Id,
                Codigo = v.Codigo,
                Trajeto = v.Origem + " -> " + v.Destino
            }).ToListAsync();

            return Ok(voos);

            [HttpGet("codigo/{codigo}")]
            public async Task<ActionResult<VooManifestoDto>> getVooPorCodigo(int codigo)
            {
                var manifesto = await _context.Voos.AsNoTracking()
                    .Where(v => v.Codigo == codigo)
                    .Select(v => new VooManifestoDto
                    {
                        Id = v.Id,
                        Codigo = v.Codigo,
                        Trajeto = v.Origem + "->" + v.Destino,
                        Passageiro = v.Passagens
                    .Select(p => new PassageiroNoVooDto
                    {


                        Nome = p.Passageiro.Nome,
                        Assento = p.Assento


                    })
                    .ToList()
                    }).FirstOrDefaultAsync();


                if (manifesto is null)
                {
                    return NotFound("Voo não encontrado");
                }
                return Ok(manifesto);
            }
        }
    }
        
}
    

