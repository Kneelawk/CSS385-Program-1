using Godot;
using System;

public partial class Menu : CanvasLayer
{
    private AnimationPlayer _anim;

    public override void _Ready()
    {
        _anim = GetNode<AnimationPlayer>("AnimationPlayer");
        _anim.Play("RESET");
    }

    public override void _Process(double delta)
    {
        if (!Input.IsActionJustPressed("Escape")) return;

        if (GetTree().Paused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    private void Pause()
    {
        GetTree().Paused = true;
        _anim.Play("pause");
    }

    private void Resume()
    {
        GetTree().Paused = false;
        _anim.PlayBackwards("pause");
    }

    public void _on_continue_pressed()
    {
        Resume();
    }

    public void _on_quit_pressed()
    {
        GetTree().Quit();
    }
}