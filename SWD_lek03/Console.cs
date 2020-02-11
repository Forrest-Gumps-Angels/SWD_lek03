using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_lek03_01
{
    class Console : IConsole
    {
        public IBtnHandler _BtnHandler { private get; set; }
        Console()
        {
            _BtnHandler = new StockingController();
        }
        public void getinput()
        {
            var input = System.Console.ReadLine();

            switch(input)
            {
                case "START":
                    _BtnHandler.StartBtnPushed();
                    break;
                case "STOP":
                    _BtnHandler.StopBtnPushed();
                    break;
            }
        }
    }
}
