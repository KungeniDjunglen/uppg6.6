using System;
class Program
{
    static void StorSmåBokstav(string text)
    {
        string[] ord = text.Split(' ');
        for (int i = 0; i < ord.Length; i++)
        {
            if(i % 2 == 0)
            {
                Console.Write(ord[i].ToLower());
            }
            else
            {
                Console.Write(ord[i].ToUpper());
            }
            Console.Write(" ");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv en mening:");
        StorSmåBokstav(Console.ReadLine());
    }
}