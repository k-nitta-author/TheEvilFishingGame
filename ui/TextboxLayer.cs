using Godot;
using State;
using System;
using UI;

public partial class TextboxLayer : CanvasLayer, IUILayer
{
    public bool IsActive { get; set; }
    public iState[] states { get; set; }
    public iState CurrentState { get; set; }

    private DialogBox dialogBox {get; set;}


    public override void _Ready()
    {
        this.dialogBox = (DialogBox)GetNode("Control/DialogBox");

    }



}
