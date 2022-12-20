using System.Runtime.CompilerServices;

namespace StrategyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 10;

            var delay = TimeSpan.FromSeconds(1);

            var writes = new IConsoleWriter[]
            {
                new BlueConsoleWriter(),
                new YellowConsoleWriter(),
                new GreenConsoleWriter(),
                new RedConsoleWriter()
            };

            for(var i = 0; i < count; i++)
            {
                var index = i % writes.Length;

                var writer = writes[index];

                var text = Guid.NewGuid().ToString();

                writer.WriterText(text);

                Thread.Sleep(delay);
            }

            Console.ReadLine();
        }
    }
}
