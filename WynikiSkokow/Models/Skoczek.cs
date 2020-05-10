using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WynikiSkokow.Models
{
    public class Skoczek
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public decimal Skok1 { get; set; }
        public decimal Skok2 { get; set; }
        public decimal Punkty { get; set; }
        public int Miejsce { get; set; }
    }
}
