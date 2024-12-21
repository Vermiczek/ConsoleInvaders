using ConsoleSurvivor.Core;

namespace Core;
using World = ConsoleSurvivor.Game.World;

public struct Options
{
   public (int width, int height) Resolution { get; set; }
   private int Fps { get; set; }
}



public class Game
{
   private Options? Options { get; set; }
   private World _world;
   
   public Game(Options options)
   {
      Options = options;
      _world = new World(options.Resolution.width, options.Resolution.height);
   }
   
   public async void RunGameloop()
   {
      
   }
   
   public async void RunEventLoop()
   {
      
   }
   
   public void Run()
   {
      EventListener.Instance.Listen();
      while(true){
         _world.Update();
         Renderer.Render(_world);
         Logger.Instance.PrintLatestLogs(10);
         Thread.Sleep(1000);
      }
   }
}