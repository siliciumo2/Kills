using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process[] notepads = Process.GetProcessesByName("notepad");

        foreach (Process notepad in notepads)
        {
            notepad.Kill();
            notepad.Kill();
            notepad.Kill();
            Console.WriteLine("блокнот закрыт");
        }
    }
}