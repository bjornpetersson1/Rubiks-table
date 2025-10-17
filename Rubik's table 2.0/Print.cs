using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_table_2._0;

public class Print 
{
    public Dictionary<int, Action> FieldsPlacement;
    public Print()
    {
        FieldsPlacement = new Dictionary<int, Action>()
        {
            {1, () => Field.Top.Write() },
            {2, () => Field.Top.Write() },
            {3, () => Field.Top.Write() },
            {4, () => Field.Top.Write() },
            {5, () => Field.Left.Write() },
            {6, () => Field.Left.Write() },
            {7, () => Field.Left.Write() },
            {8, () => Field.Left.Write() },
            {9, () => Field.Mid.Write() },
            {10, () => Field.Mid.Write() },
            {11, () => Field.Mid.Write() },
            {12, () => Field.Mid.Write() },
            {13, () => Field.Right.Write() },
            {14, () => Field.Right.Write() },
            {15, () => Field.Right.Write() },
            {16, () => Field.Right.Write() },
            {17, () => Field.Bottom.Write() },
            {18, () => Field.Bottom.Write() },
            {19, () => Field.Bottom.Write() },
            {20, () => Field.Bottom.Write() },
        };
    }
    public void Write(int[] placement)
    {
        Console.SetCursorPosition(8, 3);
        for (int i = 1; i <= 20; i++)
        {
            FieldsPlacement[placement[i-1]]();
            switch (i)
            {
                case 2:
                    Console.SetCursorPosition(8, 4);
                    break;
                case 4:
                    Console.SetCursorPosition(6, 5);
                    break;
                case 6:
                    Console.SetCursorPosition(6, 6);
                    break;
                case 8:
                    Console.SetCursorPosition(8, 5);
                    break;
                case 10:
                    Console.SetCursorPosition(8, 6);
                    break;
                case 12:
                    Console.SetCursorPosition(10, 5);
                    break;
                case 14:
                    Console.SetCursorPosition(10, 6);
                    break;
                case 16:
                    Console.SetCursorPosition(8, 7);
                    break;
                case 18:
                    Console.SetCursorPosition(8, 8);
                    break;
            }
        }
    }
        private static Dictionary<int, Fieldvalue> FieldLookup = new()
    {
        {1, Field.Top}, {2, Field.Top}, {3, Field.Top}, {4, Field.Top},
        {5, Field.Left}, {6, Field.Left}, {7, Field.Left}, {8, Field.Left},
        {9, Field.Mid}, {10, Field.Mid}, {11, Field.Mid}, {12, Field.Mid},
        {13, Field.Right}, {14, Field.Right}, {15, Field.Right}, {16, Field.Right},
        {17, Field.Bottom}, {18, Field.Bottom}, {19, Field.Bottom}, {20, Field.Bottom},
    };
    public static bool IsSolved(int[] placement)
    {
        for (int i = 0; i < placement.Length; i++)
        {
            var currentField = FieldLookup[placement[i]];
            ConsoleColor expectedColor;

            if (i >= 0 && i <= 3)
                expectedColor = Field.Top.GetColor();
            else if (i >= 4 && i <= 7)
                expectedColor = Field.Left.GetColor();
            else if (i >= 8 && i <= 11)
                expectedColor = Field.Mid.GetColor();
            else if (i >= 12 && i <= 15)
                expectedColor = Field.Right.GetColor();
            else if (i >= 16 && i <= 19)
                expectedColor = Field.Bottom.GetColor();
            else
                return false;

            if (currentField.GetColor() != expectedColor)
                return false;
        }

        return true;
    }
}
