using System.IO;

namespace TrainExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = File.ReadAllLines("trains_6.csv");
            foreach (string element in trains){
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine(trains[0][0]);
        }
    }
}
