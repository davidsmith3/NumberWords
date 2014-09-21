using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberWords.Domain;

namespace NumberWords.ConsoleUI {
    class Program {
        static void Main(string[] args) {
            Generator g = new Generator();
            var result = g.GetWords(12131415);
            foreach (var s in result) {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
