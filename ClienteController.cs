using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula01_MVC_ASPNET.Models;

namespace Aula01_MVC_ASPNET.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Teste()
        {
            var cliente = new Cliente() 
            { 
                Nome = "NET", 
                SobreNome = "ASP", 
                DataCadastro = DateTime.Now, 
                Id = 1
            };
                       
            return View("Index", cliente);
        }
        public ActionResult Pesquisa(int id, string nome) // "?" ou "=0" se o usuario fizer pesquisa de parametro invalido, não retornara com erro (apenas não carregara a aplicação)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "Joao", SobreNome = "Pedro", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Jose", SobreNome = "Augusto", DataCadastro = DateTime.Now, Id = 2},
                new Cliente() {Nome = "Antonio", SobreNome = "Carlos", DataCadastro = DateTime.Now, Id = 3},
                new Cliente() {Nome = "Eduardo", SobreNome = "Silva", DataCadastro = DateTime.Now, Id = 4}
            };

            var cliente = listaClientes.Where(c => c.Nome == nome).ToList();

            return View("Lista", cliente);
        }

    }
}