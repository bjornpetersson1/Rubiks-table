using Rubik_s_table_2._0;
while(true)
{
    InfoGraphics.Erase(10);
    InfoGraphics.Erase(11);
    InfoGraphics.moves = 0;
    var printer = new Print();
    var move = new Move();
    Console.CursorVisible = false;
    for (global::System.Int32 i = 0; i < 2; i++)
    {
        move.MakeMove(move.Scramble());
        printer.Write(move.Placement);
        Thread.Sleep(200);
    }
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
