using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    internal class FiggleWriter
    {
        public void Writer(string message)
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render(message));
        }
    }
}
