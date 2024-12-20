using System;
using System.Collections.Generic;
using System.IO;

namespace Core;

public class LogEntry
{
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }

    public LogEntry(string message)
    {
        Message = message;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{Timestamp:HH:mm:ss}] {Message}";
    }
}

public class Logger
{   
    private static Logger? _instance;
    public static Logger Instance => _instance ??= new Logger();
    private readonly List<LogEntry> _allLogs;

    public Logger()
    {
        _allLogs = new List<LogEntry>();
    }

    public LogEntry[] AllLogs => _allLogs.ToArray();

    public void AddLog(string message)
    {
        var logEntry = new LogEntry(message);
        _allLogs.Add(logEntry);
    }

    public void PrintLatestLogs(int logLength)
    {
        int start = _allLogs.Count > logLength ? _allLogs.Count - logLength : 0;
        for (int i = start; i < _allLogs.Count; i++)
        {
            Console.WriteLine(_allLogs[i]);
        }
    }

    public void SaveAllLogsToFile(string filePath)
    {
        var logStrings = new List<string>();
        foreach (var log in _allLogs)
        {
            logStrings.Add(log.ToString());
        }
        File.WriteAllLines(filePath, logStrings);
    }
}