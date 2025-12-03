using Godot;
using State;

namespace UI
{
    public interface IUILayer: iStateMachine
    {
        
        bool IsActive { get; set; }

        

    }    
}