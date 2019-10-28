using System;

namespace KnapsackGA
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int maxWeight = 30;
            int amountOfObjects = 20;
            int generationSize = 4;
            int[] knapSack = new int[amountOfObjects];
            Item[] objects = new Item[amountOfObjects];
            int[][] nextGeneration = new int[generationSize][];
            int[][] population = new int[2*generationSize][];

            //creating the available objects
            for (int i = 0; i < objects.Length; i++)
            {
                //Item myItem = new Item(rnd.Next(1, 11), rnd.Next(1, 100));
                objects[i] = new Item(rnd.Next(1, 11), rnd.Next(1, 100));
                Console.WriteLine("Weight: {0}", objects[i].weight);
                Console.WriteLine("Value: {0}", objects[i].value);
            }

            //creating initial solution
            for (int i = 0; i < nextGeneration.Length; i++)
            {
                for (int j = 0; j < knapSack.Length; j++)
                {
                    knapSack[j] = rnd.Next(0, 2);
                }
                nextGeneration[i] = knapSack;
            }
            



            Console.ReadLine();
        }

        static int calculateValue(int[] knapSack, Item[] objects, int maxWeight)
        {
            int currentValue;
            int currentWeight;
            int totalValue = 0;
            int totalWeight = 0;
            for (int i = 0; i < knapSack.Length; i++)
            {
                if (knapSack[i] == 1 && (totalWeight+objects[i].weight) < maxWeight)
                {
                    totalValue = totalValue + objects[i].value;
                    totalWeight = totalWeight + objects[i].weight;
                }
                else
                {
                    //remove excess objects from knapsack
                }
            }

            return 0;
        }
    }
}
