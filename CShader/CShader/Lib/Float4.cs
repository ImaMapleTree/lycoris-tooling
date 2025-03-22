namespace CShader;

public struct Float4
{
    public float X, Y, Z, W;
    
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
    public float A
    {
        get => W;
        set => W = value;
    }
}