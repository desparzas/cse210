public abstract class Shape
{
    private string _color;

  // GetColor
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract float GetArea();    
}


