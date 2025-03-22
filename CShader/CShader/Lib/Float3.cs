namespace CShader;

public class Float3
{
    public float X, Y, Z;
    
    public float R
    {
        get => X;
        set => X = value;
    }
    public float G
    {
        get => Y;
        set => Y= value;
    }
    public float B
    {
        get => Z;
        set => Z = value;
    }
}