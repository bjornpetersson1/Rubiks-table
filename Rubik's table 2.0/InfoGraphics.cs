using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public static class InfoGraphics
{
    public static int moves = 0;
    public static void PrintStatistics()
    {
        Console.SetCursorPosition(6, 10);
        Console.ForegroundColor = ConsoleColor.DarkRed;
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
