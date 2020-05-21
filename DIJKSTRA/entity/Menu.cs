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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|       Feiras de Games Onlines           |");
            Console.WriteLine("|                 Menu                    |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("| 1 ->  Exibir nome dos pontos            |");
            Console.WriteLine("| 2 ->  Exibir matriz                     |");
            Console.WriteLine("| 3 ->  Imprimir iteracao                 |");
            Console.WriteLine("| 4 ->  Imprimir Menor distancia          |");
            Console.WriteLine("| 5 ->  Imprimir Distancia ate os pontos  |");
            Console.WriteLine("| 6 ->  Ajuda                             |");
            Console.WriteLine("| 9 ->  Sair                              |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|_________________________________________|");

            int Opcao = 0;

            // Verifica se a entrada de dados e um numero, caso nao retorna para o menu
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A opcao escolhida nao existe");
                    Console.WriteLine("\nAperte qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
            }

            MenuPrincipal();
        }

        public void ExibirPontos()
        {
            Console.Clear();
            // Imprime todas localidades das feiras, informando o Nome da feira, o pais do envento e qual cidade ele acontece
            Console.WriteLine("Lista das feiras cadastradas\n\n");

            locations.ForEach((item) =>
            {
                Console.WriteLine($"Evento: {item.Nome} | Cidade: {item.Pais} | Pais: {item.Cidade}");
            });


            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }

        public void Ajuda()
        {
            Console.Clear();
            Console.WriteLine("|--------------------- Ajuda ---------------------");
            Console.WriteLine("| O menu de 'Exibir nome dos pontos' exibe na tela, todos as Feiras de suas localizacoes");
            Console.WriteLine("| O menu de 'Exibir matriz' exibe a distancia entre todos os pontos");
            Console.WriteLine("| O menu de 'Imprimir iteracao' imprime o caminho saindo do ponto inicial ate os nos");
            Console.WriteLine("| O menu de 'Imprimir distancia ate os pontos' vai exibir qual a distancia final, a partir do ponto de origem ate aquele determinado ponto");
            Console.WriteLine("| Todas as distancias entre as Feiras, sao medidas em kilometros");
            Console.WriteLine("| Em caso de ocorrer algum erro, o programa ira voltar para o menu, para que se possa repetir o processo");
            Console.WriteLine("| A funcao de imprimir menor distancia, tem como funcao exibir o caminho que gera o menor custo, saindo e um ponto e passando por todos");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("_________________________________________________");

            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }

        public void Iteracao()
        {
            Console.Clear();
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
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }

        public void ImprimiMenorCaminho()
        {

            Console.Clear();
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

            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }

        public void ImprimirDistanciaAteCadaPonto()
        {
            Console.Clear();
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
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }

        public void ImprimeMatriz()
        {
            // Imprime a matriz de distancia
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("############ Matriz de distancias ############");
            Console.ForegroundColor = ConsoleColor.White;

            int _quantidadeDePontos = (int)Math.Sqrt(distancias.Length);


            for (int i = 0; i < _quantidadeDePontos; i++)
            {
                for (int y = 0; y < _quantidadeDePontos; y++)
                {
                    Console.Write($"{distancias[i, y]}Km\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
        }
    }
}