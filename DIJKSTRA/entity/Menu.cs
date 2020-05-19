using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DIJKSTRA.entity
{
    class Menu
    {
        private double[,] distancias;
        private List<Location> locations;

        public Menu(double[,] distancias, List<Location> locations)
        {
            /* 
             * Recebe a matriz de distancia e as localizacoes, com suas devidas informacoes
             * e depois passa para os metodos que precisarem dos dados
             */
            this.distancias = distancias;
            this.locations = locations;
        }

        public void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("################## Menu ################");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#--------------Feiras de Games---------#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("################## Menu ################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#1 -  Exibir nome dos pontos           #");
            Console.WriteLine("#2 -  Exibir matriz                    #");
            Console.WriteLine("#3 -  Imprimir iteracao                #");
            Console.WriteLine("#4 -  Imprimir Menor distancia         #");
            Console.WriteLine("#5 -  Imprimir Distancia ate os pontos #");
            Console.WriteLine("#6 -  Ajuda                            #");
            Console.WriteLine("#9 -  Sai                              #");
            Console.WriteLine("########################################");

            int Opcao = 0;

            // Verifica se o usuario nao inseriu uma string, em caso disso acontecer, ele volta para o Menu Principal
            try
            {
                Opcao = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                MenuPrincipal();
            }

            switch (Opcao)
            {
                case 1:
                    ExibirPontos();
                    break;
                case 2:
                    ImprimeMatriz();
                    break;
                case 3:
                    Iteracao();
                    break;
                case 4:
                    ImprimiMenorCaminho();
                    break;
                case 5:
                    ImprimirDistanciaAteCadaPonto();
                    break;
                case 6:
                    Ajuda();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("teste");
                    break;
            }

            MenuPrincipal();
        }

        public void ExibirPontos()
        {
            // Imprime todas localidades das feiras, informando o Nome da feira, o pais do envento e qual cidade ele acontece
            locations.ForEach((item) =>
            {
                Console.WriteLine($"Evento: {item.Nome} | Cidade: {item.Pais} | Pais: {item.Cidade}");
            });
        }

        public void Ajuda()
        {
            Console.WriteLine("############## Ajuda ##############");
            Console.WriteLine("O menu de 'Exibir nome dos pontos' exibe na tela, todos as Feiras de suas localizacoes");
            Console.WriteLine("O menu de 'Exibir matriz' exibe a distancia entre todos os pontos");
            Console.WriteLine("O menu de 'Imprimir iteracao'");
            Console.WriteLine("");
            Console.WriteLine("Todas as distancias entre as Feiras, sao medidas em kilometros");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("###################################");
        }

        public void Iteracao()
        {
            Console.WriteLine("Informe o ponto de saida: ");

            int PontoDeSaida = 0;

            try
            {
                PontoDeSaida = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ,tente novamente");
                MenuPrincipal();
            }

            if (PontoDeSaida > locations.Count || PontoDeSaida < 0)
            {
                Console.WriteLine("Ponto incorreto, tente novamente!");
                Iteracao();
                return;
            }

            Dijkstra dijkstra = new Dijkstra(distancias, locations, PontoDeSaida);

        }

        public void ImprimiMenorCaminho()
        {
            Console.WriteLine("Informe o ponto de saida: ");

            int PontoDeSaida = 0;

            try
            {
                PontoDeSaida = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ,tente novamente");
                MenuPrincipal();
            }

            if (PontoDeSaida > locations.Count || PontoDeSaida < 0)
            {
                Console.WriteLine("Ponto incorreto, tente novamente!");
                Iteracao();
                return;
            }

            Dijkstra dijkstra = new Dijkstra(distancias, locations, PontoDeSaida);
            dijkstra.ImprimirMenorCaminho();
        }

        public void ImprimirDistanciaAteCadaPonto()
        {
            Console.WriteLine("Informe o ponto de saida: ");

            int PontoDeSaida = 0;

            try
            {
                PontoDeSaida = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ,tente novamente");
                MenuPrincipal();
            }

            if (PontoDeSaida > locations.Count || PontoDeSaida < 0)
            {
                Console.WriteLine("Ponto incorreto, tente novamente!");
                Iteracao();
                return;
            }

            Dijkstra dijkstra = new Dijkstra(distancias, locations, PontoDeSaida);
            dijkstra.ImprimirResultados();
        }

        public void ImprimeMatriz()
        {
            Console.WriteLine("Distancia entre todas as feiras, em KM");

            int _quantidadeDePontos = (int)Math.Sqrt(distancias.Length);

            for (int i = 0; i < _quantidadeDePontos; i++)
            {
                Console.Write($"{locations[i].Nome}\t");
            }

            Console.WriteLine("");

            for (int i = 0; i < _quantidadeDePontos; i++)
            {
                Console.Write($"{locations[i].Nome}\t");
                for (int y = 0; y < _quantidadeDePontos; y++)
                {
                    Console.Write($"\t{distancias[i, y]}Km\t");
                }
                Console.WriteLine("");
            }
        }
    }
}