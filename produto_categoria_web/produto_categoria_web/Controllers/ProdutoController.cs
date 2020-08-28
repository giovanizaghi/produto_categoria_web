using Dominio;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using produt_categoria_web.Custom;
using produto_categoria_web.ServiceAPI;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace produto_categoria_web.Controllers
{
    [Route("produto")]
    public class ProdutoController : ControllerAPI
    {
        public ProdutoController(ConnectionAPI api) : base(api)
        {
        }

        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Produto/ObterTodos", Method.GET);

            Result resultCategorias = await API.ExecuteAsync("http://localhost:5000", $"api/Categoria/ObterTodos", Method.GET);

            if (resultCategorias.Success)
            {
                var categorias = JsonConvert.DeserializeObject<List<Categoria>>(resultCategorias.Json);
                ViewBag.Categorias = categorias;
            }

            if (result.Success)
            {
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(result.Json);

                return View(produtos);
            }
            else
            {
                return View();
            }
        }

        [HttpPost("adicionarProduto")]
        public async Task<JsonResult> AdicionarProduto([FromForm] ProdutoPostDto produto)
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Produto/Adicionar", Method.POST, produto);

            if (result.Success)
                return Json(new { success = true });
            else
                return Json(new { success = false, message = result.Message });
        }

        [HttpPut("editarProduto")]
        public async Task<Result> EditarProduto([FromForm] Produto produto)
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Produto/Editar", Method.PUT, produto);

            if (result.Success)
                return result;
            else
                return null;
        }

        [HttpDelete("excluirProduto/{id}")]
        public async Task<Result> ExcluirProduto([FromRoute] int id)
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Produto/Excluir/{id}", Method.DELETE);

            if (result.Success)
                return result;
            else
                return null;
        }
    }
}
