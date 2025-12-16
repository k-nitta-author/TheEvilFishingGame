using Godot;
using Models;

// TODO: Implement
public partial class DialogService : Resource
{
    
    Dialog dialog = new Dialog();

    // implement loading dialog by character
    public Dialog LoadDialogByCharacter()
    {
        return dialog;
    }

}