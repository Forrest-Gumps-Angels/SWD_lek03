using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWD_lek03_01
{
    class Compressor : ICompressionCtrl
    {
        public void Compress()
        {
            System.Console.WriteLine("Initiating compression");
            Task.Delay(5000).Wait();
            System.Console.WriteLine("Compression complete");
        }

        public void Decompress()
        {
            System.Console.WriteLine("Initiating decompression");
            Task.Delay(2000).Wait();
            System.Console.WriteLine("Decompression complete");
        }
    }
}
