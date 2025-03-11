extends Node2D

var lua = LuaState.new();

# Called when the node enters the scene tree for the first time.
func _ready():
	lua.open_libraries();
		


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var x = lua.do_file("res://scripts/lua/enemy.lua", )
