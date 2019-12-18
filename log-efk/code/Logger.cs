using System;
using System.IO;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace log_efk
{
    // public enum LogLevel
    // {
    //     Debug,
    //     Info,
    //     Warn,
    //     Error,
    //     Fatal
    // }

    public static class Logger
    {
        private static ILoggerRepository repository;

        public static void Init()
        {
            repository = LogManager.CreateRepository("default");

            var config = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log.config");
            XmlConfigurator.ConfigureAndWatch(repository, config);
        }

        public static void Debug(string message) => LogManager.GetLogger("default", typeof(Logger)).Debug(message);
        public static void Info(string message) => LogManager.GetLogger("default", typeof(Logger)).Info(message);
    }
}