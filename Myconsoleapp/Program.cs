using Mylibrary;

namespace Myconsoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter mywriter = new MessageWriter();
            mywriter.Writer("Hello Writer");
            MessageWriter fwriter = new MessageWriter();
            fwriter.Writer("Hello Figgle");
        }
    }
}
