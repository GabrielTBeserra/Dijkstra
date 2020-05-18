﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIJKSTRA.entity
{
    class Location
    {
        public Location(string nome, string pais, string cidade)
        {
            Nome = nome;
            Pais = pais;
            Cidade = cidade;
        }

        public String Nome { get; set; }
        public String Pais { get; set; }
        public String Cidade { get; set; }
    }
}
