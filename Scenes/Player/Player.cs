using Godot;

public partial class Player : CharacterBody3D
{
	[Export] private float speed = 10f;
	[Export] private float gravity = 10f;
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{

		if (Input.IsActionJustPressed("ui_up"))
		{
			Velocity = new Vector3(Velocity.X, Velocity.Y, speed * (float)delta * 100f); 
		}

		ApplyGravity();
		MoveAndSlide();
	}

	private void ApplyGravity()
	{
		Velocity = new Vector3(Velocity.X, -gravity, Velocity.Z);
	}
}
