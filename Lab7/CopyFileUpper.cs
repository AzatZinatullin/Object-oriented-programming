
using System;
using System.IO;
    /// <summary>
    ///    Class to create an upper case copy of a file
    /// </summary>
    public class CopyFileUpper
    {
		public static void Main()
		{
			string sFrom;
            string sTo;
            StreamReader srFrom;
            StreamWriter swTo;
            Console.WriteLine("Enter, the input file name: ");
            sFrom = Console.ReadLine();
            Console.WriteLine("Enter, the output file name: ");
            sTo = Console.ReadLine();
            try
            {
                srFrom = new StreamReader(sFrom); //= new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);
                while(srFrom.Peek()!=-1)
                {
                    string sBuffer = srFrom.ReadLine();
                    swTo.WriteLine(sBuffer.ToUpper());
                }
                srFrom.Close();
                swTo.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
		}       
    }
