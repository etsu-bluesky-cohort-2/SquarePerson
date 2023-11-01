namespace Square;
public class Square
{

    //backing property attribute
    //private double side;
    /*public string Side 
    { 
        get
        {
            return $"{side.ToString()} inches";
        } 

        set
        {
            side = double.Parse(value);
        }

    }*/

    public double Side { get; set; }

    public Square()
    {
        Side = 10;
    }

    public Square(double side)
    {
        Side = side;
    }

    public Square(string side)
    {
        Side = double.Parse(side);
    }
    public double Area()
    {
        return Side * Side;
    }
   
    public double Parameter()
    {
        return 4 * Side;
    }

}