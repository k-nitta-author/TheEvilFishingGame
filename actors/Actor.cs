using Godot;
using Actor;
using Event;
using State;

namespace Actor{

    public partial class Actor: CharacterBody2D, IActor, iStateMachine, IEventPublisher
    {
        public Game game { get; private set; }
        public iState[] states { get; set; }
        public iState CurrentState { get; set; }

        public Vector2 direction {get; set;}

        [Export]
        public float max_speed;

        public float speed;


        public void Publish()
        {
            
        }

        public override void _Ready()
        {
            base._Ready();

            this.speed = this.max_speed;

            if (GetTree().CurrentScene.GetType() == typeof(Game))
            {
                this.game = (Game)GetTree().CurrentScene;
                this.game.EventBus.RegisterSubscriber(this);
            }
            else
            {
                GD.Print("TEST");
            }

        }


        public override void _Input(InputEvent @event)
        {
            this.CurrentState.ParseInput(@event);
        }
    }
    
}