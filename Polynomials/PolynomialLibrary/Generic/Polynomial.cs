namespace PolynomialLibrary.Generic;
using System.ComponentModel;
public class Polynomial<T> where T:IScalar
{
    private List<Term<T>> terms = new List<Term<T>>();
    public IEnumerable<Term<T>> Terms 
    {
        get{
            foreach(Term<T> t in terms)
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
    public Polynomial(params Term<T>[] terms)
    {
        foreach(Term<T> t in terms)
        {
            this.AddTerm(t);
        }
    }
    public void AddTerm(Term<T> term)
    {
        if(term.Factor.IsZero)
            return;
        CancelEventArgs e = new CancelEventArgs();
        WillAddTerm(this, e);
        if(e.Cancel)
            return;

        if(term.Degree > degree)
        {
            degree = term.Degree;
        }
        Term<T>? t = GetTerm(term.Degree);
        if(t is null)
        {
            terms.Add(term);
        }
        else
        {
            t.Factor = (T)t.Factor.Add(term.Factor); 
            if(t.Factor.IsZero)
            {
                terms.Remove(t);
            }
        }
        TermAdded(this, new EventArgs());
    }
    public void AddTerm(T factor, uint degree)
    {
        Term<T> t = new Term<T>(factor, degree);
        AddTerm(t);
    }
    private Term<T>? GetTerm(uint degree){
        foreach(Term<T> t in terms)
        {
            if(t.Degree == degree)
            {
                return t;
            }
        }
        return null;
    }
    public T? this[uint degree]
    {
        get
        {
            Term<T>? t = GetTerm(degree);
            if(t is not null)
            {
                return t.Factor;
            }
            return default(T);
        }
        
    }
    public event CancelEventHandler WillAddTerm;
    public event EventHandler TermAdded;
    public override string ToString()
    {
        //todo
        return "";
    }
    public string ToString(IPolynomialWriter<T> w)
    {
        return w.Write(this);
    }
    public double Value(double x){
        //todo
        return 0;
    }
    public double Value(T x, IPolynomialEvaluator<T> e)
    {   
        return e.Evaluate(this, x);
    }
    public Polynomial<T> Clone(){
        Polynomial<T> p = new Polynomial<T>(this.terms.ToArray());
        return p;
    }
    public static implicit operator Polynomial<T>(Term<T> t)
    {
        return new Polynomial<T>(t);
    }
    public static Polynomial<T> operator +(Polynomial<T> p1, Polynomial<T> p2)
    {
        Polynomial<T> p = p1.Clone();
        foreach(Term<T> t in p2.Terms)
        {
            p.AddTerm(t);
        }
        return p;
    }
    public static Polynomial<T> operator -(Polynomial<T> p1, Polynomial<T> p2)
    {
        return p1 + (-p2);
    }
    public static Polynomial<T> operator *(Polynomial<T> p, double x)
    {
        Polynomial<T> p1 = new Polynomial<T>();
        foreach(Term<T> t in p.Terms)
        {
            p1.AddTerm((T)t.Factor.Times(x), t.Degree);
        }
        return p1;

    }
    public static Polynomial<T> operator *(double x, Polynomial<T> p)
    {
        return p*x;
    }
    public static Polynomial<T> operator -(Polynomial<T> p)
    {
        return (-1)*p;
    }

    public static Polynomial<T> operator *(Polynomial<T> p1, Polynomial<T> p2)
    {
        Polynomial<T> p = new Polynomial<T>();
        foreach(Term<T> t1 in p1.Terms)
        {
            foreach(Term<T> t2 in p2.Terms)
            {
                p.AddTerm((T)t1.Factor.Times(t2.Factor), t1.Degree + t2.Degree);
            }
        }
        return p;
    }
    public static Polynomial<T> operator /(Polynomial<T> p1, Polynomial<T> p2)
    {
        Polynomial<T> p = p1.Clone();
        Polynomial<T> d = new Polynomial<T>();
        Term<T> t2 = p2.GetTerm(p2.Degree);
        while(p.Degree >= t2.Degree)
        {
            Term<T> t1 = p.GetTerm(p.Degree);
            d.AddTerm((T)t1.Factor.DivideBy(t2.Factor), t1.Degree - t2.Degree);
            p = p1 - d*p2;
        }
        return d;
    }
    public static Polynomial<T> operator %(Polynomial<T> p1, Polynomial<T> p2)
    {
        return p1 - (p1/p2)*p2;
    }

    public void Organize(IComparer<Term<T>> ic = null)
    {
        if(ic is null)
        {
            ic = new AscendingTermComparer<T>();
        }
        terms.Sort(ic);
    }

}