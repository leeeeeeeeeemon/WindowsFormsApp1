// Baryshev Emil 221
// figure 1
// 14.03.2021
using System;

class Program
{
    static void Main()
    {
        Triangle test = new Triangle(1, 1, 2, 2, 3, 3);
        Console.WriteLine(test.Draw());
    }
}

class Figure
{
    protected int X;
    protected int Y;

    public Figure(int newX, int newY)
    {
        X = newX;
        Y = newY;
    }

    public virtual bool Draw(int newX, int newY)
    {
        return false;
    }
}

class Circle : Figure
{
    int radius;
    public Circle(int newX, int newY, int R) : base(newX, newY)
    {
        radius = R;
    }

    public string Draw()
    {
        return $"Circle radius = {radius},position = ({X},{Y})";
    }
}

class Section : Figure
{
    int X2;
    int Y2;
    public Section(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        X2 = x2;
        Y2 = y2;
    }

    public string Draw()
    {
        return $"Section begin = ({X},{Y}),end = ({X2},{Y2})";
    }
}

class Rectangle : Figure
{
    int X2, X3, X4;
    int Y2, Y3, Y4;
    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1)
    {
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
        X4 = x4;
        Y4 = y4;
    }

    public string Draw()
    {
        return $"Rectangle leftTop = ({X},{Y}),rightTop = ({X2},{Y2}),leftBot = ({X3},{Y3}),rightBor = ({X4},{Y4})";
    }
}

class Triangle : Figure
{
    int X2, X3;
    int Y2, Y3;
    public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
    {
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
    }

    public string Draw()
    {
        return $"Triangle firstVertex = ({X},{Y}), secondVertex = ({X2},{Y2}),thirdVertex = ({X3},{Y3})";
    }
}