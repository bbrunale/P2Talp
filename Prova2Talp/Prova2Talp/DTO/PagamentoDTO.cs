using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2Talp.DTO
{
    public class PagamentoDTO
    {
        public int idForma { get; set; }
        public string nomeForma { get; set; }
        public int diasCompensacao { get; set; }
        public double tarifaServico { get; set; }
    }
}