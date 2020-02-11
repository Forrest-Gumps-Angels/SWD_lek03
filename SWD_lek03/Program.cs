using System;

namespace SWD_lek03
{
    class Program
    {
        static void Main(string[] args)
        {
            SWD_lek03_01.IConsole c = new SWD_lek03_01.Console();
            while(true)
            {
                c.getinput();
            }
        }
    }
}
