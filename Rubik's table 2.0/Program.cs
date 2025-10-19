using Rubik_s_table_2._0;


Console.CursorVisible = false;
var printer = new Print();
var move = new Move();
printer.Write(move.Placement);
int scrambleDepth = InfoGraphics.PrintWelcomeAndStart();
for (global::System.Int32 i = 0; i < scrambleDepth; i++)
{
    move.MakeMove(move.Scramble());
    printer.Write(move.Placement);
    Thread.Sleep(200);
}
while(true)
{
    InfoGraphics.EraseRow(10);
    InfoGraphics.EraseRow(11);
    InfoGraphics.moves = 0;
    Console.CursorVisible = false;
    while (true)
    {    
        printer.Write(move.Placement);
        InfoGraphics.PrintStatistics();
        ConsoleKeyInfo userMove = Console.ReadKey(true);
        move.MakeMove(userMove.Key);
        if (Print.IsSolved(move.Placement))
        {
            printer.Write(move.Placement);
            InfoGraphics.PrintYouWon();
            Console.ReadLine();
            break;
        }
    }
}
