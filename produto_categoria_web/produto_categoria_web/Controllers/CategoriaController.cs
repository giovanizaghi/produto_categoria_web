using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using produt_categoria_web.Custom;
using produto_categoria_web.ServiceAPI;
using RestSharp;

namespace produto_categoria_web.Controllers
{
    [Route("categoria")]
    public class CategoriaController : ControllerAPI
    {
        public CategoriaController(ConnectionAPI api) : base(api)
        {
        }

        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Categoria/ObterTodos", Method.GET);

            if (result.Success)
            {
                List<Categoria> produtos = JsonConvert.DeserializeObject<List<Categoria>>(result.Json);

                return View(produtos);
            }
            else
            {
                return View();
            }
        }

        [HttpPost("AdicionarCategoria/{descricao}")]
        public async Task<Result> AdicionarCategoria([FromRoute] string descricao)
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Categoria/Adicionar/{descricao}", Method.POST);

            if (result.Success)
                return result;
            else
                return null;
        }

        [HttpPut]
        public async Task<Result> EditarCategoria([FromBody] Categoria categoria)
        {
            Result result = await API.ExecuteAsync("localhost:44305/", $"api/Categoria/Editar", Method.PUT, categoria);

            if (result.Success)
                return result;
            else
                return null;
        }

        [HttpDelete("ExcluirCategoria/{id}")]
        public async Task<Result> ExcluirCategoria([FromRoute] int id)
        {
            Result result = await API.ExecuteAsync("http://localhost:5000", $"api/Categoria/Excluir/{id}", Method.DELETE);

            if (result.Success)
                return result;
            else
                return null;
        }
    }
}
