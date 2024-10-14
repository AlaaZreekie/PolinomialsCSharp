namespace PolynomialLibrary;
public class Term
{
    private uint degree;
    public double Factor { get; set; }
    public uint Degree
    {
        get
        {
            return degree;
        }
        set
        {
            degree = value;
        }
    }
    public double Value(double x){
        return Factor * Math.Pow(x, degree);
    }

    public Term()
    {

    }
    public Term(double factor, uint degree = 0)
    {
        this.Factor = factor;
        this.degree = degree;
    }
    //! or this instead
    // public Term(double factor):this(factor, 0){}
    public static explicit operator Term(double factor)
    {
        return new Term(factor);
    }
}
