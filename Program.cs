using System;

namespace Multiplication_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Arrays:");
            int [,] multiArray = new int[10,10];
            for(int i=0; i<10; i++)
            {
                int theValue = i+1;
                multiArray[i,0] = theValue;
                int theNum = theValue;
                for(int j=1; j<10; j++)
                {
                    theNum= theNum+theValue;
                    multiArray[i,j] = theNum;
                }
            }
            // Print the contents of our multiarray
            for(int k=0; k<10; k++)
            {
                Console.Write("[");
                for(int l=0; l<10; l++)
                {
                    Console.Write(multiArray[k,l]+",");
                }
                Console.Write("]\n");
            }
        }
    }
}
