using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public class Move
{
    public int[] Placement { get; set; }
    private ConsoleKey[] ScrambleOptions { get; set; }
    private Random random;
    public Move()
    {
        Placement = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        ScrambleOptions = new ConsoleKey[] { ConsoleKey.W, ConsoleKey.UpArrow, ConsoleKey.A, ConsoleKey.LeftArrow, ConsoleKey.S, ConsoleKey.DownArrow, ConsoleKey.D, ConsoleKey.RightArrow };
        random = new Random();
    }
    public ConsoleKey Scramble()
    {
        int nextMove = random.Next(7);
        return ScrambleOptions[nextMove];
    }
    public void MakeMove(ConsoleKey userInput)
    {
        switch(userInput)
        {
            case ConsoleKey.W:
                int hold = Placement[0];
                Placement[0] = Placement[2];
                Placement[2] = Placement[8];
                Placement[8] = Placement[10];
                Placement[10] = Placement[16];
                Placement[16] = Placement[18];
                Placement[18] = hold;
                break;
            case ConsoleKey.UpArrow:
                hold = Placement[1];
                Placement[1] = Placement[3];
                Placement[3] = Placement[9];
                Placement[9] = Placement[11];
                Placement[11] = Placement[17];
                Placement[17] = Placement[19];
                Placement[19] = hold;
                break;
            case ConsoleKey.LeftArrow:
                hold = Placement[6];
                Placement[6] = Placement[7];
                Placement[7] = Placement[10];
                Placement[10] = Placement[11];
                Placement[11] = Placement[14];
                Placement[14] = Placement[15];
                Placement[15] = hold;
                break;
            case ConsoleKey.A:
                hold = Placement[4];
                Placement[4] = Placement[5];
                Placement[5] = Placement[8];
                Placement[8] = Placement[9];
                Placement[9] = Placement[12];
                Placement[12] = Placement[13];
                Placement[13] = hold;
                break;
            case ConsoleKey.D:
                hold = Placement[13];
                Placement[13] = Placement[12];
                Placement[12] = Placement[9];
                Placement[9] = Placement[8];
                Placement[8] = Placement[5];
                Placement[5] = Placement[4];
                Placement[4] = hold;
                break;
            case ConsoleKey.RightArrow:
                hold = Placement[15];
                Placement[15] = Placement[14];
                Placement[14] = Placement[11];
                Placement[11] = Placement[10];
                Placement[10] = Placement[7];
                Placement[7] = Placement[6];
                Placement[6] = hold;
                break;
            case ConsoleKey.DownArrow:
                hold = Placement[19];
                Placement[19] = Placement[17];
                Placement[17] = Placement[11];
                Placement[11] = Placement[9];
                Placement[9] = Placement[3];
                Placement[3] = Placement[1];
                Placement[1] = hold;
                break;
            case ConsoleKey.S:
                hold = Placement[18];
                Placement[18] = Placement[16];
                Placement[16] = Placement[10];
                Placement[10] = Placement[8];
                Placement[8] = Placement[2];
                Placement[2] = Placement[0];
                Placement[0] = hold;
                break;
            default:
                break;
        }
    }
}
