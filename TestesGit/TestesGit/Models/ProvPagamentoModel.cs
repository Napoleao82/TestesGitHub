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
        public string Issue2Com1 { get; set; }
        public string Issue2Com2 { get; set; }
        public string Issue2Com3 { get; set; }
    }
}
