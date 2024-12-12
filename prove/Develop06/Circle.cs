// Circle
public class Circle : Shape
{
    private float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return 3.14159f * _radius * _radius;
    }
}