// Square
public class Square : Shape
{
    private float _side;

    public Square(float side)
    {
        _side = side;
    }

    public override float GetArea()
    {
        return _side * _side;
    }
}

