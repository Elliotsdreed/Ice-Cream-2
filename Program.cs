using System;

namespace ellio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] flavourSelection = new string[10, 2];
        string[,] flavourTally = new string[2, 2];

            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter Name");
                    flavourSelection[i, 0] = Console.ReadLine();
                    Console.WriteLine("Select a Flavour between the following options" + Environment.NewLine + "Vanilla" + Environment.NewLine + "Chocolate" + Environment.NewLine + "Strawberry");
                    flavourSelection[i, 1] = Console.ReadLine();
                }
                
                for (int j = 0; j < flavourTally.GetUpperBound(0); j++)
                {
                    string name = flavourTally[j, 0];
                    string flavour = flavourTally[j, 1];
                    Console.WriteLine("Name {0,-12} Flavour {1,-10}", name, flavour);
                    Console.WriteLine("----------------|-------------");
                }

                for (int i = 0; i < flavourSelection.GetUpperBound(0)+1; i++)
                {
                    string name = flavourSelection[i, 0];
                    string flavour = flavourSelection[i, 1];
                    Console.WriteLine("{0,-15} | {1,-10}", name, flavour);
                }
            }    
        }
    }
}
