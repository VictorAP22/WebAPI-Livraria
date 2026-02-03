using WebAPI___Livraria.Models;

namespace WebAPI___Livraria.Dto.Livros
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
