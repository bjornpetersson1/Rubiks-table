using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public static class Field
{
    public static Fieldvalue Top { get; set; }
    public static Fieldvalue Mid { get; set; }
    public static Fieldvalue Bottom { get; set; }
    public static Fieldvalue Left { get; set; }
    public static Fieldvalue Right { get; set; }

    static Field()
    {
        Top = new Fieldvalue(ConsoleColor.White);
        Mid = new Fieldvalue(ConsoleColor.Red);
        Bottom = new Fieldvalue(ConsoleColor.Blue);
        Left = new Fieldvalue(ConsoleColor.Green);
        Right = new Fieldvalue(ConsoleColor.Yellow);
    }
    
}
