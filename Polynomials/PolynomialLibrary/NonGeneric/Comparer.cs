namespace PolynomialLibrary;
public class AscendingTermComparer : IComparer<Term>
{   
    public int Compare(Term? x, Term? y)
    {
        return (int)x.Degree - (int)y.Degree;
    }
}