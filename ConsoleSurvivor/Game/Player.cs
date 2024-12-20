namespace ConsoleSurvivor.Game;

public class Player : Entity
{
    private Player(int x, int y, (char character, ConsoleColor color)[,] body) : base(x, y, body, 100)
    {
        Body = body;
    }

    public static Player CreatePlayer(int x, int y)
    {
        var body = new (char character, ConsoleColor color)[,]
        {
            { (' ', ConsoleColor.Red), ('x', ConsoleColor.Red), (' ', ConsoleColor.Red) },
            { ('x', ConsoleColor.Red), (' ', ConsoleColor.Red), ('x', ConsoleColor.Red) }
        };
        return new Player(x, y, body);
    }
}