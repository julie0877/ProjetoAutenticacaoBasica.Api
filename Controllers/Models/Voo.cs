namespace ProjetoAutenticacaoBasica.Api.Controllers.Models
{
    public class Voo
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }

        public ICollection<Passagem> Passagens { get; set; } = new List<Passagem>();

    }
}
