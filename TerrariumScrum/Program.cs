﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariumScrum
{
    class Program
    {
        static void Main(string[] args)
        {
            Raster raster = new Raster();
            raster.CreeerRaster();
            raster.ControleerRaster();
            raster.Afbeelden();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk v en <ENTER> om naar de volgende dag te gaan");
            Console.WriteLine("Druk s en <ENTER> om het programma te sluiten");
            var input = Console.ReadLine();
            while (input != "s")
            {
                if (input == "v")
                {
                    raster.Afbeelden();
                    //hier komt methode om de dagelijkse acties uit te voeren
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Druk v en <ENTER> om naar de volgende dag te gaan");
                    Console.WriteLine("Druk s en <ENTER> om het programma te sluiten");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("verkeerde invoer pipo!");
                }
            }
        }
    }
}
