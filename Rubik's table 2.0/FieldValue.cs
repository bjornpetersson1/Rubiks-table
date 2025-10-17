using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public struct Fieldvalue
{
    public char Symbol { get; set; }
    public ConsoleColor MyColor { get; set; }
    public Fieldvalue(ConsoleColor myColor)
    {
        Symbol = '▓';
        MyColor = myColor;
    }
    public ConsoleColor GetColor()
    {
        return MyColor;
    }
    public void Write()
    {
        Console.ForegroundColor = MyColor;
        Console.Write(Symbol);
        Console.ResetColor();
    }
}