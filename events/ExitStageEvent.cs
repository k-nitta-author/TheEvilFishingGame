using Event;

namespace Event{

    public class ExitStageEvent : IEvent
    {

        public string From {get; set;}
        public string To {get; set;}
        public int EventId { get; set; }

        public ExitStageEvent(string from, string to){
            this.From = from;
            this.To = to;
        }

        
    }
    
}