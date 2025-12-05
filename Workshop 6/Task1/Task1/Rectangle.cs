public class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    //for area
    public double GetArea()
    {
        return length * breadth;
    } 

    //for perimeter
    public double GetPerimeter()
    {
        return 2 * (length + breadth);
    } 

    //for details
    public string ShowDetails()
    {
       return $"Length: {length}, Breadth: {breadth}";

    } 
}

