using Godot;
using State;
using System;

// write up the different dialog states; 

public partial class DialogBox : Control, iStateMachine
{

    public iState[] states { get; set; }
    public iState CurrentState { get; set; }

    RichTextLabel DialogBody {get; set;}
    Label CharacterNameLabel {get; set;}


    // TODO: create a custom settings resource which loads from file
    // all config for dialog boxes
    //[Export]
    //Resource DialogBoxSettings {get; set;}

    public enum DialogSpeed {
        SLOW,
        MEDIUM,
        FAST,
        VERY_FAST    
    }

    [Export]
    DialogSpeed CurrentDialogSpeed = DialogSpeed.MEDIUM;


    public override void _Ready()
    {
        this.DialogBody = (RichTextLabel)this.GetNode("PanelContainer/Body");
        this.CharacterNameLabel = (Label)this.GetNode("CharacterNameLabel");

    }


    public void ShowDialog(bool value)
    {
        this.Visible = value;
    }

    public void PlayDialog(string character, string body)
    {
        this.CharacterNameLabel.Text = character;
        
        this.DialogBody.Text = body;

        this.DialogBody.VisibleRatio = 0.0f;
    }

    public override void _PhysicsProcess(double delta)
    {
        
        float newVisibleRatio = (float)Mathf.Lerp(this.DialogBody.VisibleRatio, 1.0d, 0.5d);
        DialogBody.VisibleRatio = newVisibleRatio;
    }


    
}
