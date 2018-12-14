using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CARROS.Models
{
    public class Carro
    {
        public int id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }

    }
}
