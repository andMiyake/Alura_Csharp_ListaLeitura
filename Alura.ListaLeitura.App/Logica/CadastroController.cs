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
    public class CadastroController
    {
        //public static Task Incluir(HttpContext context)
        //{
        //    var livro = new Livro()
        //    {
        //        Titulo = context.Request.Form["titulo"].First(),
        //        Autor = context.Request.Form["autor"].First(),
        //    };

        //    var repo = new LivroRepositorioCSV();
        //    repo.Incluir(livro);
        //    return context.Response.WriteAsync("O livro foi cadastrado com sucesso.");
        //}

        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "O livro foi cadastrado com sucesso.";
        }

        //public string ExibeFormulario(HttpContext context)
        //{
        //    var html = HtmlUtils.CarregaArquivoHTML("formulario");
        //    return html;
        //}

        public IActionResult ExibeFormulario()
        {
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }

        //public static Task NovoLivro(HttpContext context)
        //{
        //    var livro = new Livro()
        //    {
        //        Titulo = Convert.ToString(context.GetRouteValue("nome")),
        //        Autor = Convert.ToString(context.GetRouteValue("autor"))
        //    };

        //    var repo = new LivroRepositorioCSV();
        //    repo.Incluir(livro);
        //    return context.Response.WriteAsync("O livro foi cadastrado com sucesso.");
        //}

        //Rota retirada porque já existia uma que realiza a mesma lógica
        //public string NovoLivro(Livro livro)
        //{
        //    var repo = new LivroRepositorioCSV();
        //    repo.Incluir(livro);
        //    return "O livro foi cadastrado com sucesso.";
        //}
    }
}
