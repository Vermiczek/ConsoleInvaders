using System.Threading.Tasks;
using Core;

namespace ConsoleSurvivor.Core;


public struct Timestamp
{
    public int Day { get; set; }
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }
    public int Millisecond { get; set; }
}
public struct Event
{
   public Timestamp Timestamp { get; set; }
   public string UserEvent { get; set; }
}
public class EventListener
{
    private static EventListener? _instance;
    public static EventListener Instance => _instance ??= new EventListener();

    public List<Event> Events { get; set; } = new List<Event>();

    public async void Listen()
    {
        while (true)
        {
            var keyInfo = Console.ReadKey(intercept: true);
            var newEvent = new Event
            {
                Timestamp = new Timestamp
                {
                    Day = DateTime.Now.Day,
                    Hour = DateTime.Now.Hour,
                    Minute = DateTime.Now.Minute,
                    Second = DateTime.Now.Second,
                    Millisecond = DateTime.Now.Millisecond
                },
                UserEvent = keyInfo.Key.ToString()
            };
            Events.Add(newEvent); 
            Logger.Instance.AddLog($"User event happened: {newEvent.UserEvent}");
            await Task.Delay(100);
        }
    }
}