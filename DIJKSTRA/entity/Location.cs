using System;
using System.Collections.Generic;
using System.Text;

namespace DIJKSTRA.entity {
    class Location {
        

        public String Nome { get; set; }
        public String Pais { get; set; }
        public String Cidade { get; set; }
        public Location(string nome, string cidade, string pais)
        {
            Nome = nome;
            Pais = pais;
            Cidade = cidade;
        }
    }
}