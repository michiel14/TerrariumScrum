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

            // Hier komt de fase waarbij de gebruiker de keuze krijgt om naar de volgende dag te gaan of om te stoppen
            // Dit kan eventueel nog in een aparte method geschreven worden
            var antwoord = Console.ReadLine();
            while (antwoord != "s")
            {
                if (antwoord == "v")
                {
                    // Hier komt de method "volgende dag"
                    Console.WriteLine("yeah bitchessss");
                    antwoord = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(@"Druk v voor de volgende dag en s om te stoppen");
                    antwoord = Console.ReadLine();
                }
            }


            Console.ReadLine();
        }

        //static int ControleerHerbivoor(Raster raster)
        //{
        //    var terrarium = raster;
        //    int aantal = 0;
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            if (terrarium[i, j] == "H" && i < 5 && raster[i + 1, j] == "H")
        //            {
        //                Herbivoor nieuweHerbivoor = new Herbivoor();
        //            }
        //        }
        //    }
        //    return aantal;
        //}
    }
}
