using System.ComponentModel;
using Actor;
using Godot;
using State;

public partial class RunningState : Resource, iState
{

    public IActor actor;

    [Export]
    double RunningSpeed {get;set;}

    public RunningState(){}

    public void Enter(iStateMachine stateMachine)
    {
    }

    public void Execute()
    {
    }

    public void Exit()
    {
        
    }

    public void ParseInput(InputEvent e)
    {
        throw new System.NotImplementedException();
    }
}