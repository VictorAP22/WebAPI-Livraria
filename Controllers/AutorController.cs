using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI___Livraria.Dto.Autor;
using WebAPI___Livraria.Models;
using WebAPI___Livraria.Services.Autor;

namespace WebAPI___Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorinterface) 
        { 
            _autorInterface = autorinterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()  
        { 
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

        [HttpGet("BuscarAutorPorId")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor)
        {
            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);
        }

        [HttpGet("BuscarAutorPorIdLivro")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorIdLivro(int idLivro)
        {
            var livro = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(livro);
        }

        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> CriaCriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            var autoresnovos = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autoresnovos);
        }

        [HttpPut("EditarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> EditarAutor(AutorEdicaoDto autorEdicaoDto)
        {
            var edicaoautor = await _autorInterface.EditarAutor(autorEdicaoDto);
            return Ok(edicaoautor);
        }

        [HttpDelete("ExcluirAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ExcluirAutor(int idAutor)
        {
            var Excluirautor = await _autorInterface.ExcluirAutor(idAutor);
            return Ok(Excluirautor);
        }





    }

    
}
