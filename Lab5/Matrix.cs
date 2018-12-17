using System;                // Console
using System.IO;             // FileStream, FileReader

class MatrixMultiply 
{
    static void Main(string[] args) 
    {   
        int [,] a = new int[2,2];
        int [,] b = new int[2,2];
        int [,] result = new int[2,2];

        Console.WriteLine("Please, fill in the matrix: ");
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                a[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix 'a' : ");
        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine(a[i,0] + " " + a[i,1]); 
        }
        
        Console.WriteLine("Please, fill in the matrix: ");
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                b[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix 'b' : ");
        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine(b[i,0] + " " + b[i,1]); 
        }

        Console.WriteLine("Please, fill in the matrix: ");
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                result[i,j] = a[i,j] * b[j,i];
            }
        }

        Console.WriteLine("Matrix 'result' : ");
        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine(result[i,0] + " " + result[i,1]); 
        }
    }

}
