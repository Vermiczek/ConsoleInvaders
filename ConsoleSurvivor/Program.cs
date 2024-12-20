// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Core.Game game = new Core.Game(new Core.Options { Resolution = (30, 35) });
game.Run();