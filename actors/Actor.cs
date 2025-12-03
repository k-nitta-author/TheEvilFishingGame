using Godot;
using Actor;
using Event;

namespace Actor{

    public partial class Actor: CharacterBody2D, IActor, IEventPublisher
    {
        public Game game { get; private set; }

        public void Publish(IEvent e)
        {
            
        }

        public override void _Ready()
        {
            base._Ready();
            

            this.game = (Game)GetTree().CurrentScene; // Assume the current scene is of type Game

            //this.game.EventBus.RegisterSubscriber(this);
            


        }
    }
    
}