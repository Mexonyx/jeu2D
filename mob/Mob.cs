using Godot;
using System;

public class Mob : RigidBody2D
{
	// Don't forget to rebuild the project so the editor knows about the new export variables.

	[Export]
	public int MinSpeed = 150; // Minimum speed range.

	[Export]
	public int MaxSpeed = 250; // Maximum speed range.
	
	static private Random _random = new Random();

	public override void _Ready(){
		
	var animSprite = GetNode<AnimatedSprite>("AnimatedSprite");
	var mobTypes = animSprite.Frames.GetAnimationNames();
	animSprite.Animation = mobTypes[_random.Next(0, mobTypes.Length)];
	
	}
	
	public void OnVisibilityNotifier2DScreenExited() {
		
		QueueFree();
	}

}



