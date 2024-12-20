using ConsoleSurvivor.Game;
using System.Text;

namespace Core;



public static class Renderer
{
    public static void Render(World world)
    {
        Console.Clear();

        char[,] screenBuffer = new char[world.Height, world.Width];
        for (int i = 0; i < world.Height; i++)
        {
            for (int j = 0; j < world.Width; j++)
            {
                screenBuffer[i, j] = ' ';
            }
        }

        for (int i = 0; i < world.PlayerInstance.Body.GetLength(0); i++)
        {
            for (int j = 0; j < world.PlayerInstance.Body.GetLength(1); j++)
            {
                screenBuffer[world.PlayerInstance.XPosition + i, world.PlayerInstance.YPosition + j] =
                    world.PlayerInstance.Body[i, j].character;
            }
        }

        StringBuilder output = new StringBuilder();
        for (int i = 0; i < world.Height; i++)
        {
            for (int j = 0; j < world.Width; j++)
            {
                output.Append(screenBuffer[i, j]);
            }
            output.AppendLine();
        }

        // Write the entire output to the console in one go
        Console.Write(output.ToString());
    }
}