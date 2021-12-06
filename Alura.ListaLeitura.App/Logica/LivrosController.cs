using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }

        //public static Task Detalhes(HttpContext context)
        //{
        //    int id = Convert.ToInt32(context.GetRouteValue("id"));
        //    var repo = new LivroRepositorioCSV();
        //    var livro = repo.Todos.First(l => l.Id == id);
        //    return context.Response.WriteAsync(livro.Detalhes());
        //}        
        
        //Indicando ao Framework que precisamos de um id pelo argumento de entrada
        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        //public static Task ParaLer(HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();
        //    var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("para-ler");

        //    foreach (var livro in _repo.ParaLer.Livros)
        //    {
        //        conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
        //    }
        //    conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

        //    return context.Response.WriteAsync(conteudoArquivo);
        //}

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            //Colocando dentro da sacola informação, que será usada na view
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            //Colocando dentro da sacola informação, que será usada na view
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            //Colocando dentro da sacola informação, que será usada na view
            ViewBag.Livros = _repo.Lidos.Livros;

            return View("lista");
        }

        //public static Task Teste(HttpContext context)
        //{
        //    return context.Response.WriteAsync("nova funcionalidade implementada!");
        //}

        public string Teste()
        {
            return "nova funcionalidade implementada!";
        }
    }
}
