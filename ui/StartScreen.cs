using Godot;
using System;

public partial class StartScreen : Control
{

    enum States {

        DEMO,
        CHARACTER,
        SETTINGS
        
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsPressed())
        {
            GetTree().ChangeSceneToFile("res://game/Game.tscn");
        }
    }


    private void SetUpCharacter()
    {
        
    }


    
}
