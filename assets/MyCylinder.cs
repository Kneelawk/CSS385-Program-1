using Godot;
using System;

public partial class MyCylinder : CsgCylinder3D
{
    private double _time;
    
    public override void _Process(double delta)
    {
        _time += delta;
        Position = new Vector3(0, (float) Math.Sin(_time), 0);
    }

    public override void _Ready()
    {
        Position = new Vector3(0, 0, 0);
    }
}
