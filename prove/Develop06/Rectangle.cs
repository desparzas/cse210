// Rectangle
public class Rectangle : Shape
{
    private float _length;
    private float _width;

    public Rectangle(float length, float width)
    {
        _length = length;
        _width = width;
    }

    public override float GetArea()
    {
        return _length * _width;
    }
}

