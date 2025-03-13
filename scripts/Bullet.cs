using Godot;

public partial class Bullet : RigidBody2D
{
	public float Damage = 1;
	public float speed = 1f;
	public Vector2 direction;
	private static PackedScene bulletScene = ResourceLoader.Load<PackedScene>("res://scenes//bullet.tscn");

	public static void CreateBullet(float damage, float speed, Vector2 direction, Node2D parent)
	{
		// Instantiate the bullet scene
		var bullet = bulletScene.Instantiate() as Bullet;
		// Set the bullet's properties
		bullet.Damage = damage;
		bullet.speed = speed;
		// Normalize the direction vector
		bullet.direction = direction.Normalized();
		// Explicitly set the velocity of the bullet (without using MoveAndCollide)
		bullet.LinearVelocity = bullet.direction * bullet.speed;  // Apply velocity to bullet directly

		// Add the bullet to the scene as a child of the parent
		parent.AddChild(bullet);
	}
}
