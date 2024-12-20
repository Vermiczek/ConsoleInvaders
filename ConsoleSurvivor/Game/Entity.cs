namespace ConsoleSurvivor.Game;
public abstract class Entity
{
    public (char character, ConsoleColor color)[,] Body { get; set; }
    public int XPosition { get; set; } 
    public int YPosition { get; set; }
    public int Health { get; set; }
    
    public Entity(int x, int y, (char character, ConsoleColor color)[,] body, int hp)
    {
        this.XPosition = x;
        this.YPosition = y;
        this.Body = body;
        this.Health = hp;
    }
}