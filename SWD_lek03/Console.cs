using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_lek03_01
{
    class Console
    {
        public IBtnHandler _BtnHandler{ private get; set; }
        Console()
        {
            _BtnHandler = new StockingController();
        }
        public static void getinput()
        {

        }
    }
}
