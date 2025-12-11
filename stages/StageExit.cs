using Godot;
using Event;
using System;

public partial class StageExit : Area2D, IEventPublisher
{

    [Export(PropertyHint.File, "*.tscn")]
    String DestinationFilePath;

    [Export]
    int ExitIdx;

    public override void _Ready()
    {

        this.BodyShapeEntered += (Rid b_rid, Node2D b, long b_shape_idx, long l_shape_idx) => {OnBodyShapeEntered(b_rid, b, b_shape_idx, l_shape_idx);};

    }

    public void OnBodyShapeEntered(Rid body_rid, Node2D body, long body_shape_idx, long local_shape_idx)
    {
        GD.Print("Stage Exit Reached!");

        ExitStageEvent e = new ExitStageEvent("test", "test");

        this.Publish();

    }

    public void Publish()
    {

        ExitStageEvent e = new ExitStageEvent("test", "test");
        
        GD.Print(e.To);

        GetTree().ChangeSceneToFile(DestinationFilePath);

        

    }

}
