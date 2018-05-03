using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestesGit.Models
{
    public class ProvPagamentoModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Issue1Com3 { get; set; }
        public string Issue1Com4 { get; set; }
        public string Issue1Com5 { get; set; }
        public string Issue1Com6 { get; set; }
    }
}
