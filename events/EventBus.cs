using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using Event;

public partial class EventBus : RefCounted
{

    private List<IEventPublisher> Subscribers = new List<IEventPublisher>();

    public void RegisterSubscriber(IEventPublisher sub)
    {
            this.Subscribers.Add(sub);

        GD.Print(this.Subscribers);
    }

    public void Broadcast()
    {
        
    }

}
