using System;

namespace State
{
    public interface iState
    {
        public void Enter(iStateMachine stateMachine);
        public void Execute();
        public void Exit();

    }    
}
