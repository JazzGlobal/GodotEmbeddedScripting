using NLua;

public class LuaBuilder
{
    private readonly Lua _lua;

    public LuaBuilder()
    {
        _lua = new Lua();
        _lua.LoadCLRPackage();
        _lua.DoString("import ('Godot')");
        _lua.RegisterFunction("GDPrint", typeof(WithGDPrint).GetMethod("GDPrint"));
    }

    public Lua Build()
    {
        return _lua;
    }

    public LuaBuilder WithVector2()
    {
        _lua.RegisterFunction("CreateVector2", typeof(WithVector).GetMethod("CreateVector2"));
        _lua.RegisterFunction("Vector2Subtract", typeof(WithVector).GetMethod("Vector2Subtract"));
        _lua.RegisterFunction("Vector2Normalize", typeof(WithVector).GetMethod("Vector2Normalize"));
        _lua.RegisterFunction("Vector2Lerp", typeof(WithVector).GetMethod("Vector2Lerp"));
        return this;
    }

    public LuaBuilder WithVector3()
    {
        _lua.RegisterFunction("CreateVector3", typeof(WithVector).GetMethod("CreateVector3"));
        return this;
    }
}