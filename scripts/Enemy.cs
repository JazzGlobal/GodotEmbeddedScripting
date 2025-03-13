using Godot;
using NLua;

public partial class Enemy : Node2D
{
	private Lua lua;
	private string script = "res://scripts/lua/Enemy.lua";
	private LuaFunction InitializeState;
	private LuaFunction ProcessState;
	public override void _Ready()
	{
		lua = new LuaBuilder()
			.WithVector2()
			.Build();

		lua["Enemy"] = this;
		lua.DoFile(ProjectSettings.GlobalizePath(script));
		InitializeState = lua.GetFunction("InitializeState");
		ProcessState = lua.GetFunction("ProcessState");

		InitializeState.Call();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ProcessState.Call(delta);
	}

	public void PrintHello()
	{
		GD.Print("Hello from C#");
	}

	public void FireBullet(int directionX, int directionY)
	{
		// GD.Print("FireBullet");
		Bullet.CreateBullet(1, 1, new Vector2(directionX, directionY), this);
	}
}
