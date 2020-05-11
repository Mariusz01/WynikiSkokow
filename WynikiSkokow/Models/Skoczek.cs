using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WynikiSkokow.Models
{
    public class Skoczek
    {
        public int ID { get; set; }
        [Display(Name = "Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        [Display(Name = "Skok 1")]
        public decimal Skok1 { get; set; }
        [Display(Name = "Skok 2")]
        public decimal Skok2 { get; set; }
        public decimal Punkty { get; set; }
        public int Miejsce { get; set; }
    }
}
