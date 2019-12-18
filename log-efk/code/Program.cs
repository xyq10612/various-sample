using System;
using log4net;

namespace log_efk
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Init();

            Logger.Info("test info");
            Logger.Debug("test debug");
        }
    }
}
