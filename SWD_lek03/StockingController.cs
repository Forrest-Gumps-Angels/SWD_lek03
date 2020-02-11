using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_lek03_01
{
    class StockingController : IBtnHandler
    {
        public ICompressionCtrl CompressionController { private get; set; }

        StockingController()
        {
            CompressionController = new Compressor();
        }
        public void StartBtnPushed()
        {
            CompressionController.Compress();
        }
        public void StopBtnPushed()
        {
            CompressionController.Decompress();
        }
    }
}
