﻿namespace ActManager.Infrastructure.Loggers;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
