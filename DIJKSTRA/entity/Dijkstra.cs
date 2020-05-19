using System;
using System.Collections.Generic;
using System.Linq;

namespace DIJKSTRA.entity
{
    class Dijkstra
    {
        private double INF = double.MaxValue;
        private List<Location> ListaNomesLugares;
        private double[,] MatrizDistancias;
        private int QuantidadeDeElementos;
        private List<int> ListaMenorCaminho;
        private List<Noh> ListaDeNos;

        public Dijkstra(double[,] matrizDeDistancia, List<Location> listaDeNomes, int origem)
        {
            // Obtem o numero de elementos a partir da raiz quadrada do tamanho da matriz que seria tamanho X tamanho
            this.QuantidadeDeElementos = (int)Math.Sqrt(matrizDeDistancia.Length);
            // Salva uma copia local da lista dos lugares
            this.ListaNomesLugares = listaDeNomes;
            // Instancia uma lista para salvar a posicao dos nos no ordem que sao descobertos
            this.ListaMenorCaminho = new List<int>();
            // Salva uma copia local da matriz de distancias
            this.MatrizDistancias = matrizDeDistancia;
            // Instancia uma lista de Noh para manipulacao das posicoes
            this.ListaDeNos = new List<Noh>();

            // Inicializa todos os nos, definindo a distancia de cada um deles como infinito, e tambem definindo todos como nao visitados
            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                ListaDeNos.Add(new Noh(false, INF));
            }

            // Define que o ponto de origem sua distancia e igual a 0
            ListaDeNos[origem].Distancia = 0;

            CarregarDijkstra();
        }

        // Metodo resposnavel por calcular qual o menor no, que ainda nao foi visitado
        private int CalcularDistanciaMinima()
        {
            double valorMinimo = INF;
            int index = -1;

            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                // Verifica se o No ainda nao foi visitado e tem um numero menor que o infinito
                if (ListaDeNos[i].Visitado == false && ListaDeNos[i].Distancia <= valorMinimo)
                {
                    // O valor minimo passa a ser a distancia do no que esta na posicao
                    valorMinimo = ListaDeNos[i].Distancia;
                    index = i;
                }

                //                Console.WriteLine (ListaNomesLugares[i].Nome);
            }

            // Retorna qual a posicao do noh com menor caminho, que ainda nao foi visitado
            return index;
        }

        private void CarregarDijkstra()
        {
            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                // Salva qual a posicao do no que possui o menor caminho, e que ainda nao foi visitado
                int NohDeDistanciaMinima = CalcularDistanciaMinima();

                //Console.WriteLine ($"{NohDeDistanciaMinima}\n\n");
                // Defini que aquele no retornado, foi visitado
                ListaDeNos[NohDeDistanciaMinima].Visitado = true;
                // Adiciona o no, na lista de menor caminho
                ListaMenorCaminho.Add(NohDeDistanciaMinima);

                for (int y = 0; y < QuantidadeDeElementos; y++)
                {
                    // Verifica se o no ainda nao foi visitado , e que a distancia daquele no, somado com a matriz do no em questao e menor que a distancia daquele no
                    if (!ListaDeNos[y].Visitado && ListaDeNos[NohDeDistanciaMinima].Distancia + MatrizDistancias[NohDeDistanciaMinima, y] < ListaDeNos[y].Distancia && i != y)
                    {
                        // Em caso da matriz ser menor, a nova distancia daquele no passa a ser a distancia antiga, mais a distancia na matriz daquela determinado posicao
                        ListaDeNos[y].Distancia = ListaDeNos[NohDeDistanciaMinima].Distancia + MatrizDistancias[NohDeDistanciaMinima, y];

                        Console.WriteLine(ListaNomesLugares[y].Nome);
                    }
                }
            }
        }

        public void ImprimirResultados()
        {
            Console.WriteLine("No\t\tDistancia");
            for (int i = 0; i < QuantidadeDeElementos; i++)
            {
                Console.WriteLine(i + " \t\t " + ListaDeNos[i].Distancia);
            }
        }

        public void ImprimirMenorCaminho()
        {
            // Imprime o menor caminho, de acordo com a ordem que os nos foram sendo descobertos
            ListaMenorCaminho.ForEach((i) =>
            {
                Console.WriteLine($"Nome: {ListaNomesLugares[i].Nome} | Cidade: {ListaNomesLugares[i].Cidade} | Pais: {ListaNomesLugares[i].Pais} [{i}]");
            });
        }

    }
}