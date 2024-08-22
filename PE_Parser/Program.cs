using System;
using System.IO;

namespace PE_Parser;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Please supply at least one valid PE file");
            Environment.Exit(1);
        }

        Misc.LoadFile(args.Length, args);
    }
}

