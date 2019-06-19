using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TrainExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"trains_6.csv";
            string maxWidth = "-12";
            var rowText = "{0,Width} {1,Width} {2,Width} {3,Width}".Replace("Width",maxWidth);

            var trainSchedule = new List<string>();
            trainSchedule = File.ReadAllLines(filePath).Distinct().ToList();
    
            foreach (string train in trainSchedule){
                var trainList = train.Split(", ");
                System.Console.WriteLine(rowText, trainList[0], trainList[1], trainList[2], trainList[3]);
            }
        }
    }
}