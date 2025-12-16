using Godot;
using System;
using State;
using GameStates;
using Service;
using Event;
using System.Linq;

public partial class Game : Node, iStateMachine, IEventSubscriber
{
	public iState State;
	public EventBus EventBus = new EventBus();

	[Export]
	public CurrencyService currencyService {get; set;} = new CurrencyService();

	[Export]
	public SavegameService savegameService {get; set;} = new SavegameService();

	[Export]
	public AudioService audioService {get; set;} = new AudioService();

	[Export]
	public EventBusService eventBusService {get; set;} = new EventBusService();

	[Export]
	public ConfigService configService {get; set;} = new ConfigService();

	[Export]
	public StatsService statsService {get; set;} = new StatsService();

	[Export]
	public InventoryService inventoryService {get; set;} = new InventoryService();

	[Export]
	public DialogService dialogService {get; set;} = new DialogService();

	[Export]
	public FishService fishService {get; set;} = new FishService();

    public iState[] states { get; set; }

    public iState CurrentState { get; set; }

    public override void _Ready()
	{

	}

}
