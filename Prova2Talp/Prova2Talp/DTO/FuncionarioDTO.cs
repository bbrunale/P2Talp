using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2Talp.DTO
{
    public class FuncionarioDTO
    {
        public int idFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string EmailFuncionario { get; set; }
        public string cpfFuncionario { get; set; }
        public string senhaFuncionario { get; set; }
    }
}