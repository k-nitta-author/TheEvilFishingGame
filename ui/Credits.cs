using Godot;
using System;
using System.Diagnostics.Contracts;
using System.Dynamic;

public partial class Credits : Control
{

    public enum Mode
    {
        Scrolling,
        ConsiderExit,
        Complete
    }

    [Export]
    public Mode CurrentMode {get {return _CurrentMode;} set {setCurrentMode(value);}}
    private Mode _CurrentMode = Mode.Scrolling;
    private string pathToStartScreen = "res://ui/StartScreen.tscn";

    private Timer timer; 

    public override void _Ready()
    {
        base._Ready();

        this.timer = (Timer)GetNode("Timer");

    }

    private void setCurrentMode(Mode value)
    {
        _CurrentMode = value;

        switch (CurrentMode)
        {
            case Mode.Scrolling:
                break;

            case Mode.ConsiderExit:
                break;

            case Mode.Complete:

                this.timer.WaitTime = 3.0;
                this.timer.Start();

                break;

        }
        
    }


    public void SwapToStartScreen()
    {
        GetTree().ChangeSceneToFile(pathToStartScreen);
    }
    
}
