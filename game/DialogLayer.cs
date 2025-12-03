using Godot;
using System;
using System.Dynamic;

public partial class DialogLayer : CanvasLayer
{


    AnimationPlayer anim;
    AudioStreamPlayer soundtrack;
    

    public enum Mode
    {
        ACCEPTING_NO_INPUT,
        ACCEPTING_INPUT,
        TRANSITION,
        WAIT,
        NO_INTRO
    
    }

    [Export]
    public Mode CurrentMode {
        get {return _CurrentMode;}
        set {
            _CurrentMode = value;

            switch (_CurrentMode){

                case Mode.ACCEPTING_NO_INPUT:
                    this.anim.Play("intro_movie");
                    break;
                case Mode.ACCEPTING_INPUT:
                    this.anim.Play("exit_intro_movie");
                    break;
                case Mode.TRANSITION:
                    break;

                case Mode.WAIT:
                    break;
                case Mode.NO_INTRO:
                    

                    this.QueueFree();
                    break;

            }

            }}
    private Mode _CurrentMode;

    [Export]
    public Resource CurrentChapter {get {return currentChapter;} set {currentChapter = value;}}
    private Resource currentChapter;

    public override void _Ready()
    {
        this.anim = (AnimationPlayer)GetNode("AnimationPlayer");
        this.soundtrack = (AudioStreamPlayer)GetNode("Soundtrack");
        

        // should be the default mode
        this.CurrentMode = Mode.ACCEPTING_NO_INPUT;
        //this.CurrentMode = Mode.NO_INTRO;

    }

    public override void _Input(InputEvent @event)
    {

        if (CurrentMode != Mode.WAIT){return;}

        if (@event.IsPressed())
        {
            CurrentMode = Mode.ACCEPTING_INPUT;
        }

        
    }



}
