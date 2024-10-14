namespace PolynomialLibrary.Generic;
public class AscendingTermComparer<T> : IComparer<Term<T>> where T:IScalar
{   
    public int Compare(Term<T>? x, Term<T>? y)
    {
        return (int)x.Degree - (int)y.Degree;
    }
}