namespace ProjetoAutenticacaoBasica.Api.Controllers.Models
{
    public class Passageiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public ICollection<Passagem> Passagens { get; set; } = new List<Passagem>();
    }
}
