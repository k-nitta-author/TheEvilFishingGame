using Godot;
using System;
using Event;
using Actor;

namespace Actor
{

    public partial class Player : Actor 
    {
        Vector2 direction;

        [Export]
        float max_speed;

        private float speed;


        public override void _Ready()
        {
            base._Ready();

            this.speed = this.max_speed;

            this.game.EventBus.RegisterSubscriber(this);

        }


        public override void _PhysicsProcess(double delta)
        {
            
            this.direction = new Vector2(Input.GetAxis("ui_left", "ui_right"), Input.GetAxis("ui_up", "ui_down")).Normalized();

            this.Velocity = this.direction * this.speed;

            this.MoveAndSlide();

        }


    }

}


