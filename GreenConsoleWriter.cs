using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMethod
{
    public class GreenConsoleWriter : IConsoleWriter
    {
        public void WriterText(string text) 
        { 

            if(string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            Console.ForegroundColor= ConsoleColor.Green;

            Console.WriteLine($">>> GreenConsoleWriter {text}");
        } 
    }
}
