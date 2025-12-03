using Godot;
using System;
using State;
using GameStates;

public partial class Game : Node
{

	public iState State;
	public EventBus EventBus = new EventBus();

	public override void _Ready()
	{

		this.State = new MenuState();
	}

	

}
