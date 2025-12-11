using Actor;
using Godot;
using State;

public partial class WalkingState : Resource, iState
{

    public Actor.Actor actor;

    public void Enter(iStateMachine stateMachine)
    {
        
        this.actor = (Actor.Actor)stateMachine;

    }

    public void Execute()
    {
        actor.direction = new Vector2(Input.GetAxis("ui_left", "ui_right"), Input.GetAxis("ui_up", "ui_down")).Normalized();

        actor.Velocity = actor.direction * actor.speed;

        actor.MoveAndSlide();
        
    }

    public void ParseInput(InputEvent e)
    {

        if (e.IsActionPressed("Run"))
        {
            GD.Print("Will Start Running");

            actor.CurrentState = new RunningState();
            actor.CurrentState.Enter(actor);
        }

    }

    public void Exit()
    {
        
    }
}