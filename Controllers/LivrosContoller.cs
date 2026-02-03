using Microsoft.AspNetCore.Mvc;
using WebAPI___Livraria.Dto.Livros;
using WebAPI___Livraria.Models;
using WebAPI___Livraria.Services.Livros;

namespace WebAPI___Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosContoller : ControllerBase
    {
        
        private readonly ILivrosInterface _livroInterface;
        public LivrosContoller(ILivrosInterface livrosInterface)
        {
            _livroInterface = livrosInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivros()
        {
            var livros = await _livroInterface.ListarLivros();
            return Ok(livros);
        }

        [HttpGet("BuscarLivroPorId")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivrosPorId(int IdLivro)
        {
            var BuscaLivro = await _livroInterface.BuscarLivrosPorId(IdLivro);
            return Ok(BuscaLivro);
        }

        [HttpGet("BuscarLivroPorIdAutor")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorIdAutor(int IdLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(IdLivro);
            return Ok(livro);
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivrosCriacaoDto livrosCriacaoDto)
        {
            var livrosnovos = await _livroInterface.CriarLivro(livrosCriacaoDto);
            return Ok(livrosnovos);
        }

        [HttpPut("EditarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var edicaolivros = await _livroInterface.EditarLivro(livroEdicaoDto);
            return Ok(edicaolivros);
        }

        [HttpDelete("Excluirlivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ExcluirLivro(int IdLivro)
        {
            var Excluirlivro = await _livroInterface.ExcluirLivro(IdLivro);
            return Ok(Excluirlivro);
        }
    }
}
