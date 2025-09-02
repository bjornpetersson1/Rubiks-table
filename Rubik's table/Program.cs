int matrixSize = 4;
int[] mid;
int[] top;
int[] bottom;
int[] right;
int[] left;
mid = new int[matrixSize];
top = new int[matrixSize];
bottom = new int[matrixSize];
right = new int[matrixSize];
left = new int[matrixSize];
string aButton = "A";
string bButton = "B";
string cButton = "C";
string dButton = "D";
string eButton = "E";
string fButton = "F";
string gButton = "G";
string hButton = "H";
Random random = new Random();
static void printField(int[] top, int[] left, int[] mid, int[] right, int[] bottom, string aButton, string bButton, string cButton, string dButton, string eButton, string fButton, string gButton, string hButton)
{
    Console.Clear();
    Console.WriteLine("|.|.|.|" + aButton + "|" + bButton + "|.|.|.|");
    Console.WriteLine("|.|.|.|" + top[0] + "|" + top[1] + "|.|.|.|");
    Console.WriteLine("|.|.|.|" + top[2] + "|" + top[3] + "|.|.|.|");
    Console.WriteLine("|" + cButton + "|" + left[0] + "|" + left[1] + "|" + mid[0] + "|" + mid[1] + "|" + right[0] + "|" + right[1] + "|" + eButton + "|");
    Console.WriteLine("|" + dButton + "|" + left[2] + "|" + left[3] + "|" + mid[2] + "|" + mid[3] + "|" + right[2] + "|" + right[3] + "|" + fButton + "|");
    Console.WriteLine("|.|.|.|" + bottom[0] + "|" + bottom[1] + "|.|.|.|");
    Console.WriteLine("|.|.|.|" + bottom[2] + "|" + bottom[3] + "|.|.|.|");
    Console.WriteLine("|.|.|.|" + gButton + "|" + hButton + "|.|.|.|");
}
static void aMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = top[0];
    top[0] = top[2];
    top[2] = mid[0];
    mid[0] = mid[2];
    mid[2] = bottom[0];
    bottom[0] = bottom[2];
    bottom[2] = hold;


}
static void bMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = top[1];
    top[1] = top[3];
    top[3] = mid[1];
    mid[1] = mid[3];
    mid[3] = bottom[1];
    bottom[1] = bottom[3];
    bottom[3] = hold;
}
static void cMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = left[0];
    left[0] = left[1];
    left[1] = mid[0];
    mid[0] = mid[1];
    mid[1] = right[0];
    right[0] = right[1];
    right[1] = hold;
}
static void dMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = left[2];
    left[2] = left[3];
    left[3] = mid[2];
    mid[2] = mid[3];
    mid[3] = right[2];
    right[2] = right[3];
    right[3] = hold;
}
static void eMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = right[1];
    right[1] = right[0];
    right[0] = mid[1];
    mid[1] = mid[0];
    mid[0] = left[1];
    left[1] = left[0];
    left[0] = hold;
}
static void fMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = right[3];
    right[3] = right[2];
    right[2] = mid[3];
    mid[3] = mid[2];
    mid[2] = left[3];
    left[3] = left[2];
    left[2] = hold;
}
static void gMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = bottom[2];
    bottom[2] = bottom[0];
    bottom[0] = mid[2];
    mid[2] = mid[0];
    mid[0] = top[2];
    top[2] = top[0];
    top[0] = hold;
}
static void hMove(int[] top, int[] left, int[] mid, int[] right, int[] bottom)
{
    int hold = bottom[3];
    bottom[3] = bottom[1];
    bottom[1] = mid[3];
    mid[3] = mid[1];
    mid[1] = top[3];
    top[3] = top[1];
    top[1] = hold;
}
string quit = "Q";
while (quit != "N")
{
    int moves = 1;
    for (int i = 0; i < 4; i++)
    {
        mid[i] = 3;
        top[i] = 1;
        bottom[i] = 5;
        right[i] = 4;
        left[i] = 2;
    }
    printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
    Console.Write("Depth of scramble: ");
    int scramble = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < scramble; i++)
    {
        int scrambleMove = random.Next(1, 9);
        if (scrambleMove == 1)
        {
            aMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 2)
        {
            bMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 3)
        {
            cMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 4)
        {
            dMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 5)
        {
            eMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 6)
        {
            fMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 7)
        {
            gMove(top, left, mid, right, bottom);
        }
        if (scrambleMove == 8)
        {
            hMove(top, left, mid, right, bottom);
        }
        Console.Clear();
        printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        Console.WriteLine("Please wait while scrambling");
        Thread.Sleep(200);
    }
    printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
    Console.Write("Your move: ");
    string move = Console.ReadLine()!;
    while (move != "Q")
    {
        if (move == "A")
        {
            aButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            aButton = "A";
            aMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "B")
        {
            bButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            bButton = "B";
            bMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "C")
        {
            cButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            cButton = "C";
            cMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "D")
        {
            dButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            dButton = "D";
            dMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "E")
        {
            eButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            eButton = "E";
            eMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "F")
        {
            fButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            fButton = "F";
            fMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "G")
        {
            gButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            gButton = "G";
            gMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (move == "H")
        {
            hButton = "#";
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            Thread.Sleep(400);
            hButton = "H";
            hMove(top, left, mid, right, bottom);
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
        }
        if (top[0] == 1 && top[1] == 1 && top[2] == 1 && top[3] == 1 && mid[0] == 3 && mid[1] == 3 && mid[2] == 3 && mid[3] == 3 && left[0] == 2 && left[1] == 2 && left[2] == 2 && left[3] == 2 && right[0] == 4 && right[1] == 4 && right[2] == 4 && right[3] == 4 && bottom[0] == 5 && bottom[1] == 5 && bottom[2] == 5 && bottom[3] == 5)
        {
            printField(top, left, mid, right, bottom, aButton, bButton, cButton, dButton, eButton, fButton, gButton, hButton);
            int score = ((scramble * 3) - moves) * scramble;
            Console.WriteLine("you won.");
            Console.WriteLine("difficult level: " + scramble);
            Console.WriteLine("your score is: " + score);
            break;
        }
        else
        {
            moves++;
            Console.Write("Your move: ");
            move = Console.ReadLine()!;
        }
    }
    Console.Write("Play again? Y/N: ");
    quit = Console.ReadLine()!;
}
