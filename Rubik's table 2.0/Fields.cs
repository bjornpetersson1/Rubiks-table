using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

struct Fields
{
    public Fieldvalue Top { get; set; }
    public Fieldvalue Mid { get; set; }
    public Fieldvalue Bottom { get; set; }
    public Fieldvalue Left { get; set; }
    public Fieldvalue Right { get; set; }
    public Fields()
    {
        Top = new Fieldvalue(ConsoleColor.White);
        Mid = new Fieldvalue(ConsoleColor.Red);
        Bottom = new Fieldvalue(ConsoleColor.Blue);
        Left = new Fieldvalue(ConsoleColor.Green);
        Right = new Fieldvalue(ConsoleColor.Yellow);
    }
}
