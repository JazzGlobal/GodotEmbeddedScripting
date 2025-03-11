using Godot;

public class WithVector
{
    public static Vector2 CreateVector2(float x, float y)
    {
        return new Vector2(x, y);
    }

    public static Vector2 Vector2Subtract(Vector2 a, Vector2 b)
    {
        return a - b;
    }

    public static Vector2 Vector2Normalize(Vector2 vector2)
    {
        return vector2.Normalized();
    }

    public static Vector2 Vector2Lerp(Vector2 a, Vector2 b, float t)
    {
        return a.Lerp(b, t);
    }

    public static Vector3 CreateVector3(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }
}