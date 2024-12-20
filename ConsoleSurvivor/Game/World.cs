namespace ConsoleSurvivor.Game;

public class World
{
    public Player PlayerInstance { get; set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public World(int width, int height)
    {
        Width = width;
        Height = height;
        Console.WriteLine("World created with size: " + width + "x" + height);
        PlayerInstance = Player.CreatePlayer(10, 10);
    }
    public void Update()
    {
        Console.WriteLine("World updated!");
    }
    
}