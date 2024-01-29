using System;
using NLog;

internal class Program
{
    private static Logger logger = LogManager.GetCurrentClassLogger();

    private static void Main(string[] args)
    {
        LogManager.Setup().LoadConfigurationFromFile("nlog.config");

        logger.Trace("This is a trace message");
        logger.Debug("This is a debug message");
        logger.Info("This is an info message");
        logger.Warn("This is a warning message");
        logger.Error("This is an error message");
        logger.Fatal("This is a fatal message");

    }
}
