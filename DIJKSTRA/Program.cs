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
            // Instancia a matriz de distancia
            double[,] _distancias = new double[,] {
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
                {5956, 6295, 4812, 2860, 9332, 16337, 2530, 10844, 13736, 1975, 1998, 0}};


            // Adiciona todas localizacoes em uma lista
            List<Location> locations = new List<Location>();
            locations.Add(new Location("Sebo Desculpe a Poeira", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Red Star Sebo Livraria", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo Memória", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo Bela Cintra", "Brasil", "Sao Paulo"));
            locations.Add(new Location("R. Domingos de Morais, 2182 - Santa Cruz, São Paulo - SP, 04036-000", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo do Ferreira", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo Perdizes", "Brasil", "Sao Paulo"));
            locations.Add(new Location("CASA PUEBLA SEBO", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo Cesar", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo do Messias", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo José de Alencar", "Brasil", "Sao Paulo"));
            locations.Add(new Location("Sebo Paulistano", "Brasil", "Sao Paulo"));


            Menu menu = new Menu(_distancias, locations);
            menu.MenuPrincipal();
        }
    }
}
