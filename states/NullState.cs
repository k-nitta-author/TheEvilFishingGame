using Godot;
using State;

namespace State
{
    public class NullState : iState
    {

        public NullState(){}

        public void Enter(iStateMachine stateMachine)
        {
        }

        public void Execute()
        {
        }

        public void Exit()
        {
        }

        public void ParseInput(InputEvent e)
        {
        }
    }
}