public abstract class Shape
{
    public string _color;

    public Shape(string s)
    {
        SetColor(s);
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string s)
    {
        _color = s;
    }
    
    public abstract double GetArea();
}