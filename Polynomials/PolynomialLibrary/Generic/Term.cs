namespace PolynomialLibrary.Generic;
public class Term<T> where T:IScalar
{
    private uint degree;
    public T Factor { get; set; }
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
    public T Value(T x){
        return (T)Factor.Times(x.Power(degree)); //Math.Pow(x, degree);
    }

    public Term()
    {

    }
    public Term(T factor, uint degree = 0)
    {
        this.Factor = factor;
        this.degree = degree;
    }
    //! or this instead
    // public Term(T factor):this(factor, 0){}
    public static explicit operator Term<T>(T factor)
    {
        return new Term<T>(factor);
    }
}
