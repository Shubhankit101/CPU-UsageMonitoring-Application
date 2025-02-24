using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("CPU Usage Monitor");
        Console.WriteLine("Press Ctrl+C to stop");

        while (true)
        {
            float cpuUsage = GetCpuUsage();
            Console.WriteLine($"CPU Usage: {cpuUsage}%");
            Thread.Sleep(1000); // Refresh every second
        }
    }

    static float GetCpuUsage()
    {
        try
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "sh",
                    Arguments = "-c \"ps -A -o %cpu | awk '{s+=$1} END {print s}'\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            if (float.TryParse(output.Trim(), out float cpuUsage))
            {
                return cpuUsage;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return 0;
    }
}
