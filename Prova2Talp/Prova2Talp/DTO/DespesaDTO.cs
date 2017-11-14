using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2Talp.DTO
{
    public class DespesaDTO
    {
        public int idDespesa { get; set; }
        public string nomeDespesa { get; set; }
        public double valorDespesa { get; set; }
        public int idTipoDespesa { get; set; }
        public string descDespesa { get; set; }
    }
}