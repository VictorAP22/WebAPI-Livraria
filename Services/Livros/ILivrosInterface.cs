using WebAPI___Livraria.Dto.Livros;
using WebAPI___Livraria.Models;

namespace WebAPI___Livraria.Services.Livros
{
    public interface ILivrosInterface
    {

        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivrosPorId(int IdLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int IdLivro);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivrosCriacaoDto livrosCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int IdLivro);
    }
}
