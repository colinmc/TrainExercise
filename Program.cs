// TrainExercise by Colin M 2019
// The following program takes a CSV file, defined in filePath, and displays it in a table 
// format in alphabetical order by run number. Duplicate rows are removed before sorting and displaying.
// 
// The program assumes that the supplied file is a CSV with 4 columns, where the first row
// is the headers of the column, and that the max length of each column is 12 characters.

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
            // Define the source file, and determine the width of each column
            var filePath = @"trains_6.csv";
            string maxWidth = "-12";
            var rowText = "{0,Width} {1,Width} {2,Width} {3,Width}".Replace("Width",maxWidth);

            // Assigning the source file to a list, and remove duplicate entries
            var trainSchedule = new List<string>();
            trainSchedule = File.ReadAllLines(filePath).Distinct().ToList();

            // Sort the source data by the run number in descending order
            var trains = trainSchedule.Skip(1);
            var sortedTrains = trains.OrderBy(x=>x.Split(", ")[2]);

            // Display the results
            var colHeader = trainSchedule[0].Split(", ");
            System.Console.WriteLine(rowText, colHeader[0],colHeader[1],colHeader[2],colHeader[3]);
            foreach (string train in sortedTrains){
                var trainList = train.Split(", ");
                System.Console.WriteLine(rowText, trainList[0], trainList[1], trainList[2], trainList[3]);
            }
        }
    }
}