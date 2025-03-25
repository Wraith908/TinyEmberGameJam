using Godot;
using System;

public partial class CharacterMovement : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;
	[Export]
	public int SprintSpeed { get; set; } = 600;
	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		if (Input.IsActionPressed("sprint")) {
			Velocity = inputDirection * SprintSpeed;
		} else {
			Velocity = inputDirection * Speed;
		}
	}
	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
}
