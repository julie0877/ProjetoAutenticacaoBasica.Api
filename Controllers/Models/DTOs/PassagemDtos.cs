namespace ProjetoAutenticacaoBasica.Api.Controllers.Models.DTOs
{
    public class PassagemDtos
    {
    }

    public class EmitirPassagemDto
    {
        public int VooId { get; set; }
        public int PassageiroId { get; set; }
        public int Assento { get; set; }
    }

    public class PassagemDetalhesDto
    {
        public int Id { get; set; }
        public int CodigoVoo { get; set; }
        public string Trajeto { get; set; }
        public string NomePassageiro { get; set; }
        public int Assento { get; set; }
    }
}
