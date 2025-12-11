using System.Collections.Generic;

namespace State{
    public interface iStateMachine
    {
        
        iState[] states {get; set;}
        iState CurrentState {get; set;}
    }
}
