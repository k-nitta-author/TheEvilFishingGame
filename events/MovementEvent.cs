using System.Security.Cryptography;
using Godot;

namespace Event{
    public partial class MovementEventStart : RefCounted, IEvent 
    {

        public Vector2 StartPoint { get; private set; }
        public int EventId { get; set; }

        public MovementEventStart(Vector2 startPoint)
        {
            this.StartPoint= startPoint;
        }
    }

    public partial class MovementEventStop : RefCounted, IEvent 
    {

        public Vector2 StopPoint { get; private set; }
        public int EventId { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public MovementEventStop(Vector2 startPoint)
        {
            this.StopPoint= startPoint;
        }
    }
}