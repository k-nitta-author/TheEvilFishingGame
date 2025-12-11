using Godot;

namespace Actor
{
    public interface IActor
    {
        public Game game{ get; }

        public Vector2 direction {get; set;}
    }
}