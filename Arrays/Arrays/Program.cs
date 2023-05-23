using System;

namespace Arrays
{
    class program
    {
        static void Main(string[] args)
        {
            string[] coffeTypes;
            float[] coffeValues;

            coffeTypes = new string[] { "Expresso", "Large", "Filter", "Latte" };
            coffeValues = new float[] { 1.2f, 1.5f, 3.5f, 5.0f };
            
            for (int i = 0; i < coffeTypes.Length; i++)
            {
                Console.WriteLine(coffeTypes[i] + " Coffe $" + coffeValues[i]);
            }
        }
    }
}