using System;

namespace BAI_Les_2_Huiswerk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] distanceBetweenCities = new int[6, 6] { 
                                                           { 0, 50, 135, 120, 65, 65 }, 
                                                           { 0, 50, 140, 75, 20, 70 }, 
                                                           { 135, 140, 0, 220, 170, 75 }, 
                                                           { 120, 75, 220, 0, 55, 145 },
                                                           { 65, 20, 170, 55, 0, 90},
                                                           { 65, 70, 75, 145, 90, 0} 
            };

            string[] cities = new string[6] { "arnhem",
                                              "amersfoort",
                                              "assen",
                                              "rotterdam",
                                              "utrecht",
                                              "Zwolle" 
            };

            calculateTheLeastDistance(distanceBetweenCities, cities);
        }

        public static void calculateTheLeastDistance(int[,] DistanceBetweenCities, string[] Cities)
        {
            string cityResult = "";
            int smallestDistance = 10000;

            for (int i = 0; i < 6; i++)
            {
                int distance = 0;
                for (int j = 0; j < 6; j++)
                {
                    distance = distance + DistanceBetweenCities[i, j];
                }
                if(distance < smallestDistance)
                {
                    smallestDistance = distance;
                    cityResult = Cities[i];
                }
                Console.WriteLine($"Studenten moeten in totaal {distance*5}km reizen om bij {Cities[i]} te komen");
            }
            Console.WriteLine("");
            Console.WriteLine($"In {cityResult} moet er extra les BAI gegeven worden. Bij elkaar moeten studenten {smallestDistance*5}km reizen");
        }
    }
}
