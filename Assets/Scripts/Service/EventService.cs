public class EventService
{
    private static EventService instance;
    public static EventService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EventService();
            }
            return instance;
        }
    }

    public EventController OnLightSwitchToggled { get; private set; }
    public EventController<int> OnKeyPickedUp { get; private set; }
    public EventController OnLightsOffByGhostEvent { get; private set; }

    public EventController PlayerEscapedEvent { get; private set; }
    public EventController PlayerDeathEvent { get; private set; }

    public EventController OnRatRush { get; private set; }
    public EventController OnSkullDrop { get; private set; }
    
    public EventController<int> OnPotionDrink { get; private set; } 
    public EventService()
    {
        OnLightSwitchToggled = new EventController();
        OnKeyPickedUp = new EventController<int>();
        OnLightsOffByGhostEvent = new EventController();
        OnRatRush = new EventController();
        OnSkullDrop = new EventController();
        OnPotionDrink = new EventController<int>();
        
        PlayerEscapedEvent = new EventController();
        PlayerDeathEvent = new EventController();
        
    }
}
