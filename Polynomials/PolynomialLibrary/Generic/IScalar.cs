namespace PolynomialLibrary.Generic;
public interface IScalar
{
    public IScalar Add(IScalar y);
    public IScalar Subtract(IScalar y);
    public IScalar Times(IScalar y);
    public IScalar Times(double x);
    public IScalar DivideBy(IScalar y);
    public IScalar Power(uint y);
    public IScalar Opposite {get;}
    public bool IsZero {get;}
    public bool IsIdentity {get;}
    public bool IsNull {get;}
}