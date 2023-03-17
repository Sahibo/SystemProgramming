using System.Diagnostics;

namespace SystemHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }


        static Process Run()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"notepad.exe";
            return process;
        }

        static void Task1()
        {
            Process process = new Process();
            process = Run();

            process.Start();
            process.WaitForExit();

            if (process.HasExited)
            {
                Console.WriteLine("The process has been ended");
            }
        }

        static void Task2()
        {
            Process process = new Process();

            process = Run();
            process.Start();
            Console.WriteLine("1 - Wait for the end of the process" +
                              "2 - Kill the process");

            string? choose = Console.ReadLine();
            process.Start();

            if (choose == "1")
            {
                if (process.HasExited)
                    Console.WriteLine("The process has been ended");
            }

            if (choose == "2")
                process.Kill();
        }

    }
}