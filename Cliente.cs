using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula01_MVC_ASPNET.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}