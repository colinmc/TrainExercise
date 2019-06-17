using System;
using System.IO;

namespace TrainExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxSpaces = 12;
            var filePath = @"trains_6.csv";

            var trainScheulde = File.ReadAllLines(filePath);
            foreach (string train in trainScheulde){
                var trainList = train.Split(", ");
                System.Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", trainList[0], trainList[1], trainList[2], trainList[3]);
            }
        }
    }
}
