using Godot;
using System;
using Event;
using Actor;

namespace Actor
{

    public partial class Player : Actor
    {

        public override void _Ready()
        {
            base._Ready();

            this.CurrentState = new WalkingState();
            this.CurrentState.Enter(this);

            //this.game.EventBus.RegisterSubscriber(this);

        }


        public override void _PhysicsProcess(double delta)
        {
            
            this.CurrentState.Execute();

        }


    }

}


