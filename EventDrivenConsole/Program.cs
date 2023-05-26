// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace EventDrivenConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {

                Process firstProc = new Process();
                firstProc.StartInfo.FileName = "notepad.exe";
                firstProc.EnableRaisingEvents = true;

                firstProc.Start();

                firstProc.WaitForExit();

                //You may want to perform different actions depending on the exit code.
                Console.WriteLine("First process exited: " + firstProc.ExitCode);

                Process secondProc = new Process();
                secondProc.StartInfo.FileName = "mspaint.exe";
                secondProc.Start();

                var p = Process.Start("notepad.exe", new[] { "arg1", "arg2", "arg3" });
                await p.WaitForExitAsync().ConfigureAwait(false);

                secondProc.WaitForExit();

                Console.WriteLine("Second process exited: " + secondProc.ExitCode);


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred!!!: " + ex.Message);
                return;
            }
        }
    }
}
