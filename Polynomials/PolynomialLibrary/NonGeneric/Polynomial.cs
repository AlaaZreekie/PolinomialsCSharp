namespace PolynomialLibrary;
using System.ComponentModel;
public class Polynomial
{
    private List<Term> terms = new List<Term>();
    public IEnumerable<Term> Terms 
    {
        get{
            foreach(Term t in terms)
            {
                yield return t;
            }
            // return terms.AsEnumerable();
        }
    }
    private uint degree;
    public uint Degree 
    { 
        get
        {
            return degree;
        }
        protected set
        {
            degree = value;
        }
    }
    public Polynomial()
    {

    }
    public Polynomial(params Term[] terms)
    {
        foreach(Term t in terms)
        {
            this.AddTerm(t);
        }
    }
    public void AddTerm(Term term)
    {
        if(term.Factor == 0)
            return;
        CancelEventArgs e = new CancelEventArgs();
        //WillAddTerm(this, e);
        if(e.Cancel)
            return;

        if(term.Degree > degree)
        {
            degree = term.Degree;
        }
        Term? t = GetTerm(term.Degree);
        if(t is null)
        {
            terms.Add(term);
        }
        else
        {
            t.Factor += term.Factor; 
            if(t.Factor == 0)
            {
                terms.Remove(t);
            }
        }
        //TermAdded(this, new EventArgs());
    }
    public void AddTerm(double factor, uint degree)
    {
        Term t = new Term(factor, degree);
        AddTerm(t);
    }
    private Term? GetTerm(uint degree){
        foreach(Term t in terms)
        {
            if(t.Degree == degree)
            {
                return t;
            }
        }
        return null;
    }
    public double this[uint degree]
    {
        get
        {
            Term? t = GetTerm(degree);
            if(t is not null)
            {
                return t.Factor;
            }
            return 0;
        }
        
    }
   // public event CancelEventHandler WillAddTerm;
    //public event EventHandler TermAdded;
    public override string ToString()
    {
        string stringPolynomial = string.Empty;

        foreach (Term term in Terms)
        {
            stringPolynomial += Convert.ToString(term.Factor) + "x^" + Convert.ToString(term.Degree) + " + ";
        }

        stringPolynomial = stringPolynomial.Substring(0, stringPolynomial.Length - 2);
        stringPolynomial = stringPolynomial.Replace("x^0", "");
        stringPolynomial = stringPolynomial.Replace("x^1", "x");
        stringPolynomial = stringPolynomial.Replace("1x", "x");


        return stringPolynomial;
    }
    public string ToString(IPolynomialWriter w)
    {
        return w.Write(this);
    }
    public double Value(double x){
        double value = 0;

        foreach (Term term in Terms)
        {
            value += Convert.ToDouble(term.Factor) * Math.Pow(x, Convert.ToDouble(term.Degree));
        }

        return value;
    }
    public double Value(double x, IPolynomialEvaluator e)
    {   
        return e.Evaluate(this, x);
    }
    public Polynomial Clone(){
        Polynomial p = new Polynomial(this.terms.ToArray());
        return p;
    }
    public static implicit operator Polynomial(Term t)
    {
        return new Polynomial(t);
    }
    public static Polynomial operator +(Polynomial p1, Polynomial p2)
    {
        Polynomial p = p1.Clone();
        foreach(Term t in p2.Terms)
        {
            p.AddTerm(t);
        }
        return p;
    }
    public static Polynomial operator -(Polynomial p1, Polynomial p2)
    {
        return p1 + (-p2);
    }
    public static Polynomial operator *(Polynomial p, double x)
    {
        Polynomial p1 = new Polynomial();
        foreach(Term t in p.Terms)
        {
            p1.AddTerm(x*t.Factor, t.Degree);
        }
        return p1;

    }
    public static Polynomial operator *(double x, Polynomial p)
    {
        return p * x;
    }
    public static Polynomial operator -(Polynomial p)
    {
        return p*(-1);
    }

    public static Polynomial operator *(Polynomial p1, Polynomial p2)
    {
        Polynomial p = new Polynomial();
        foreach(Term t1 in p1.Terms)
        {
            foreach(Term t2 in p2.Terms)
            {
                p.AddTerm(t1.Factor*t2.Factor, t1.Degree + t2.Degree);
            }
        }
        return p;
    }
    public static Polynomial operator /(Polynomial p1, Polynomial p2)
    {
        Polynomial p = p1.Clone();
        Polynomial d = new Polynomial();
        Term t2 = p2.GetTerm(p2.Degree);
        while(p.Degree >= t2.Degree)
        {
            Term t1 = p.GetTerm(p.Degree);
            d.AddTerm(t1.Factor/t2.Factor, t1.Degree - t2.Degree);
            p = p1 - d*p2;
        }
        return d;
    }
    public static Polynomial operator %(Polynomial p1, Polynomial p2)
    {
        return p1 - (p1/p2)*p2;
    }

    public void Organize(IComparer<Term> ic = null)
    {
        if(ic is null)
        {
            ic = new AscendingTermComparer();
        }
        terms.Sort(ic);
    }

}