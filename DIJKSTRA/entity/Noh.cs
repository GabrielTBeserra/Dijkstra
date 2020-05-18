using System;
using System.Collections.Generic;
using System.Text;

namespace DIJKSTRA.entity
{
    class Noh
    {
        public bool Visitado { get; set; }
        public double Distancia { get; set; }
        public Noh(bool visitado, double distancia)
        {
            Visitado = visitado;
            Distancia = distancia;
        }
    }
}
