using Zoo_Management_System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Animal> zoo = new List<Animal>
        {
            new Lion("Simba", 5, true),
            new Parrot("Polly", 2, "Hello"),

            new Snake("Nagini", 3, true)
        };

        foreach (var animal in zoo)
        {
            animal.MakeSound();
        }
    }
}