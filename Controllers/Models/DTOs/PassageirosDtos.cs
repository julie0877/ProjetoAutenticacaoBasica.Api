namespace ProjetoAutenticacaoBasica.Api.Controllers.Models.DTOs
{
   

    public class CriarPassageiroDto
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
    }

    public class PassageiroInfoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

}
