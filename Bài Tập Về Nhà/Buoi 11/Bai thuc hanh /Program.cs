using System;
using System.Collections.Generic;

namespace dotnet_IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}