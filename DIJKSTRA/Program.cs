using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using DIJKSTRA.entity;

namespace DIJKSTRA {
    class Program {
        static void Main (string[] args) {
            // Instancia a matriz de distancia
            /* double[,] _distancias = new double[,] {
                 {0, 478, 1794, 4145, 7546, 10433, 6039, 10487, 20307, 7602, 7624, 6322},
                 {692, 0, 1316, 3977, 7718, 10887, 5561, 9226, 19829, 6427, 6449, 6154},
                 {1451, 1927, 0, 2845, 7169, 11715, 4754, 8677, 18833, 5295, 5318, 5022},
                 {4009, 4347, 2864, 0, 9716, 16721, 4032, 11229, 15264, 2963, 2986, 2806},
                 {7655, 8131, 7069, 6460, 0, 10022, 12082, 4529, 20558, 7373, 7396, 9974},
                 {8740, 9084, 9538, 12164, 7804, 0, 14389, 3168, 25617, 12432, 12454, 15032},
                 {6326, 6098, 5498, 4280, 10794, 17800, 0, 12307, 13847, 4014, 4036, 2809},
                 {8910, 9255, 7172, 9589, 4659, 4349, 12583, 0, 21060, 7874, 7897, 10475},
                 {21232, 21004, 16903, 14951, 18542, 25547, 15007, 20055, 0, 11887, 11909, 13864},
                 {8340, 8816, 7059, 3708, 8235, 15240, 5455, 9748, 13770, 0, 418, 3185},
                 {7922, 8398, 6641, 3291, 7817, 14822, 5038, 9330, 13352, 655, 0, 2767},
                 {5956, 6295, 4812, 2860, 9332, 16337, 2530, 10844, 13736, 1975, 1998, 0}};*/

            // Adiciona todas localizacoes em uma lista

            List<Location> locations = new List<Location> ();
            locations.Add(new Location("Brasil Games show" , "Brasil" , "Sao Paulo"));
            locations.Add(new Location("Game XP" , "Brasil" , "Rio De Janeiro"));
            locations.Add(new Location("E3","Los Angeles","Estados Unidos Da America"));
            locations.Add(new Location("Comic Com","San Diego","Estados Unidos Da America"));
            locations.Add(new Location("Gamescom", "Colônia", "Alemanha"));
            locations.Add(new Location("BlizzCon", "Anhareim", "Estados Unidos Da America"));
            locations.Add(new Location("DreamHack", "Jonkoping", "Suécia"));
            locations.Add(new Location("Tokyo Game Show", "Tokyo", "Japão"));
            /*
                locations.Add(new Location("Sebo Desculpe a Poeira", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Red Star Sebo Livraria", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo Memória", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo Bela Cintra", "Brasil", "Sao Paulo"));
                locations.Add(new Location("R. Domingos de Morais", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo do Ferreira", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo Perdizes", "Brasil", "Sao Paulo"));
                locations.Add(new Location("CASA PUEBLA SEBO", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo Cesar", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo do Messias", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo José de Alencar", "Brasil", "Sao Paulo"));
                locations.Add(new Location("Sebo Paulistano", "Brasil", "Sao Paulo"));
            */

            double[, ] _distancias = new double[, ] { 
                {0, 359.33, 9911.30, 9742.76, 9799.14, 9879.89, 10626.37, 18554.96 }, 
                {359.33, 0, 10142.75, 9983.31, 9572.79, 10092.36, 10407.14, 18604.80 }, 
                {9911.30, 10142.75, 0, 200, 9144.41, 47.9, 8893.70, 8823.31 }, 
                {9742.76, 9983.31, 200, 0, 9254.32, 155, 8990.60, 8986.97 }, 
                {9800.33, 9565.75, 9154.68, 9217.52, 0, 9140.97, 1074, 9341.12 }, 
                {9864.30, 10112.18, 43.1, 153, 9155.30, 0, 8876.69, 8861.44 }, 
                {10649.31, 10431.32, 8863.98, 8952.92, 1084, 8876.69, 0, 8455.33 }, 
                {18554.96, 18604.80, 8823.31, 8986.97, 9341.12, 8861.44, 8455.33, 0 }
            };

            Menu menu = new Menu (_distancias, locations);
            menu.MenuPrincipal ();
        }
    }
}