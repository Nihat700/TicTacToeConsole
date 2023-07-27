
string[,] gameBoard =
{
    {"_", "_", "_" },
    {"_", "_", "_" },
    {"_", "_", "_" }
};
bool player = true; // player == false - player1 / player == true /2

Start:
try
{
    ShowGameBoard(gameBoard);

    Console.WriteLine("Choose coordinate: ");

    Console.Write("Coordinate X:");
    int coordinateX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Coordinate Y:");
    int coordinateY = Convert.ToInt32(Console.ReadLine());

    string symbol = player ? "X" : "O";

    player = GameArea(gameBoard, coordinateX, coordinateY, symbol, player);

    while (GameWin(gameBoard))
    {
        ShowGameBoard(gameBoard);
        string winPlayer = player ? "player 2 win" : "player 1 win";
        Console.WriteLine(winPlayer);
        return;
    }

    Console.Clear();

    goto Start;
}
catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine(ex.Message);
    goto Start;
}

bool GameArea(string[,] gameBoard, int x, int y, string symbol, bool play)
{
    if (gameBoard[x, y].Contains("_"))
    {
        gameBoard[x, y] = symbol;
        play = !play;
        return play;
    }
    else
    {
        Console.WriteLine("Agillisan sen indi");
        return play;
    }
}

bool GameWin(string[,] gameBoard)
{
    if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
    {
        Console.WriteLine("You Win!");
        return true;
    }

    return false;
}

void ShowGameBoard(string[,] game)
{
    for (int i = 0; i < game.GetLength(0); i++)
    {
        for (int j = 0; j < game.GetLength(1); j++)
        {
            Console.Write(game[i, j]);
        }
        Console.WriteLine();
    }
}


