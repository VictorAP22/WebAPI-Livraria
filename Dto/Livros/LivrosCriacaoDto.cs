using WebAPI___Livraria.Models;

namespace WebAPI___Livraria.Dto.Livros
{
    public class LivrosCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
