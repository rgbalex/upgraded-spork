using System.Diagnostics;

namespace upgraded_spork.Server;


public class ProcessModel
{
    public string StandardOutput { get; }

    public ProcessModel()
    {
        using (Process process = new Process())
        {
            process.StartInfo.FileName = "ipconfig.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            // Synchronously read the standard output of the spawned process.
            StreamReader reader = process.StandardOutput;
            StandardOutput = reader.ReadToEnd();

            // Write the redirected output to this application's window.
            //Console.WriteLine(StandardOutput);

            process.WaitForExit();
        }
    }
}