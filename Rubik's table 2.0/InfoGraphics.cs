using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public static class InfoGraphics
{
    public static int moves = 0;
    public static int PrintWelcomeAndStart()
    {
        int writingSpeed = 50;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        string title = "RUBIK'S TABLE";
        string info = "use WASD and arrow keys to move";
        string instruction = "please enter desired scramble depth: ";
        Console.SetCursorPosition(3, 1);
        foreach (var s in title)
        {
            Console.Write(s);
            Thread.Sleep(writingSpeed);
        }
        Console.SetCursorPosition(2, 10);
        foreach (var s in info)
        {
            Console.Write(s);
            Thread.Sleep(writingSpeed);
        }
        Console.SetCursorPosition(0, 11);
        foreach (var s in instruction)
        {
            Console.Write(s);
            Thread.Sleep(writingSpeed);
        }
        Console.CursorVisible = true;
        return int.Parse(Console.ReadLine());
    }
    public static void PrintStatistics()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(6, 10);
        Console.Write($"moves: {moves}");
        Console.ResetColor();
        moves++;
    }
    public static void PrintYouWon()
    {
        
        Console.SetCursorPosition(0, 10);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"you won, congratulations");
        Console.SetCursorPosition(4, 11);
        Console.Write($"you made {moves} moves");
        Console.ResetColor();
    }
    public static void EraseRow(int row)
    {
        Console.SetCursorPosition(0, row);
        Console.Write(new string(' ', Console.BufferWidth));
    }
}
