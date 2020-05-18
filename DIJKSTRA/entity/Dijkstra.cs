using System;
using System.Collections.Generic;
using System.Linq;

namespace DIJKSTRA.entity
{
    class Dijkstra
    {
        private double INF = double.MaxValue;
        private List<Location> _listaNomesLugares;
        private double[,] _matrizDistancias;
        private int _quantidadeDeElementos;
        private List<int> _listaMenorCaminho;
        private List<Noh> _listaDeNos;

        public Dijkstra(double[,] matrizDeDistancia, List<Location> listaDeNomes, int origem)
        {
            _quantidadeDeElementos = (int)Math.Sqrt(matrizDeDistancia.Length);
            _listaNomesLugares = listaDeNomes;
            _listaMenorCaminho = new List<int>();
            _matrizDistancias = matrizDeDistancia;
            _listaDeNos = new List<Noh>();

            for (int i = 0; i < _quantidadeDeElementos; i++)
            {
                _listaDeNos.Add(new Noh(false, INF));
                

            }

            _listaDeNos[origem].Distancia = 0;

            CarregarDijkstra();
        }



        private int CalcularDistanciaMinima()
        {
            double valorMinimo = INF;
            int index = -1;

            for (int i = 0; i < _quantidadeDeElementos; i++)
            {
                if (_listaDeNos[i].Visitado == false && _listaDeNos[i].Distancia <= valorMinimo)
                {
                    valorMinimo = _listaDeNos[i].Distancia;
                    index = i;
                    Console.WriteLine(_listaNomesLugares[i].Nome);
                }
            }
            return index;
        }



        private void CarregarDijkstra()
        {
            for (int i = 0; i < _quantidadeDeElementos; i++)
            {
                int DistanciaMinima = CalcularDistanciaMinima();

                Console.WriteLine($"{DistanciaMinima}\n\n");

                _listaDeNos[DistanciaMinima].Visitado = true;
                _listaMenorCaminho.Add(DistanciaMinima);

                for (int y = 0; y < _quantidadeDeElementos; y++)
                {
                    if (!_listaDeNos[y].Visitado && _listaDeNos[DistanciaMinima].Distancia + _matrizDistancias[DistanciaMinima, y] < _listaDeNos[y].Distancia)
                    {
                        _listaDeNos[y].Distancia = _listaDeNos[DistanciaMinima].Distancia + _matrizDistancias[DistanciaMinima, y];
                    }
                }
            }

            ImprimirResultados();
        }
        public void ImprimirResultados()
        {
            Console.WriteLine("Vertex     Distance " + "from Source\n");
            for (int i = 0; i < _quantidadeDeElementos; i++)
            {
                Console.WriteLine(i + " \t\t " + _listaDeNos[i].Distancia);
            }

            _listaMenorCaminho.ForEach((i) => {
                Console.WriteLine(i);
            });
            
        }


    }
}
