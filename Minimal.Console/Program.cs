using System;
using Minimal.Standard.Library;

namespace Minimal.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new LibraryClass();
            System.Console.WriteLine(lib.Hello());
        }
    }
}
