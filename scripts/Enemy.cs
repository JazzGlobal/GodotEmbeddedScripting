using Godot;
using NLua;

public partial class Enemy : Node2D
{
	[Export]
	public string Name { get; set; } = "";

	private Lua lua;
	private string script = "res://scripts/lua/Enemy.lua";
	public override void _Ready()
	{
		lua = new LuaBuilder()
			.WithVector2()
			.Build();

		lua["Enemy"] = this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		lua["DELTA"] = delta;
		lua.DoFile(ProjectSettings.GlobalizePath(script));
	}

	public void GDPrint(string message)
	{
		GD.Print(message);
	}
}
