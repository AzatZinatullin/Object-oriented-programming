
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails 
{
    static void Main(string[] args) 
    {   
        string fileName = args[0];
        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream); 
        long len = new System.IO.FileInfo(fileName).Length - 10;
        Console.WriteLine(len);

        char [] contents = new char[len];

        for(int i = 0; i<len; i++)
        {
            contents[i] = (char)reader.Read(); 
        }

        Summarize(contents);
        reader.Close();
        
        
        //TODO: Add code here

        // Console.WriteLine(args.Length);
        // foreach(string arg in args)
        // {
        //     Console.WriteLine(arg);
        // }
    }

    static void Summarize(char [] contents)
    {
        int vowel = 0;
        int notVowel = 0;
        int caret = 1;

        foreach(char content in contents)
        {
            Console.Write(content);
            if("AEIOUaeiou".IndexOf(content)!=-1)
            {
                vowel++;
            }
            else if("\n".IndexOf(content)!=-1)
            {
                caret++;
            }
            else
            {
                notVowel++;
            }
        }

        Console.WriteLine("\n" + "Kol-vo strok: " + caret + "\n" + "Vowel: " + vowel + "\n" + "Not vowel: " + notVowel);
    }
}
