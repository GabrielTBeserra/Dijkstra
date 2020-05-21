using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using DIJKSTRA.entity;

namespace DIJKSTRA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um lista de Locations, que salva qual o Nome do evento, A cidade que ocorre, e o pais
            List<Location> ListaDeLocalizacoes = new List<Location>();
            ListaDeLocalizacoes.Add(new Location("Brasil Games show", "Brasil", "Sao Paulo"));
            ListaDeLocalizacoes.Add(new Location("Game XP", "Brasil", "Rio De Janeiro"));
            ListaDeLocalizacoes.Add(new Location("E3", "Los Angeles", "Estados Unidos Da America"));
            ListaDeLocalizacoes.Add(new Location("Comic Com", "San Diego", "Estados Unidos Da America"));
            ListaDeLocalizacoes.Add(new Location("Gamescom", "Colônia", "Alemanha"));
            ListaDeLocalizacoes.Add(new Location("BlizzCon", "Anhareim", "Estados Unidos Da America"));
            ListaDeLocalizacoes.Add(new Location("DreamHack", "Jonkoping", "Suécia"));
            ListaDeLocalizacoes.Add(new Location("Tokyo Game Show", "Tokyo", "Japão"));

            // Instancia a matriz de distancia passando todas as distancias
            double[,] MatrizDeDistancia = new double[,] {
                {0, 359.33, 9911.30, 9742.76, 9799.14, 9879.89, 10626.37, 18554.96 },
                {359.33, 0, 10142.75, 9983.31, 9572.79, 10092.36, 10407.14, 18604.80 },
                {9911.30, 10142.75, 0, 200, 9144.41, 47.9, 8893.70, 8823.31 },
                {9742.76, 9983.31, 200, 0, 9254.32, 155, 8990.60, 8986.97 },
                {9800.33, 9565.75, 9154.68, 9217.52, 0, 9140.97, 1074, 9341.12 },
                {9864.30, 10112.18, 43.1, 153, 9155.30, 0, 8876.69, 8861.44 },
                {10649.31, 10431.32, 8863.98, 8952.92, 1084, 8876.69, 0, 8455.33 },
                {18554.96, 18604.80, 8823.31, 8986.97, 9341.12, 8861.44, 8455.33, 0 }
            };

            // Passa como parametro para o menu, a matriz e a lista de localizacoes
            Menu menu = new Menu(MatrizDeDistancia, ListaDeLocalizacoes);
            menu.MenuPrincipal();
        }
    }
}