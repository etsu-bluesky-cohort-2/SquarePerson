public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle()
    {
        Length = 10;
        Width = 10;
    }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

/* THIS ONE CAN"T BE DONE BECAUSE THE METHOD SIGNATURE IS Rectangle(double, double) and we already have a double doulbe in line 12
    public Rectangle(double width, double length)
    {

    }
*/
    public Rectangle(double width)
    {
       //if we don't assign length, then length will be zero.
        Length = 0;
        Width = width;
    }

/*This can't be done because we already jave a signature of Rectangle(double)
    public Rectangle(double length)
    {
        
    }
*/
}