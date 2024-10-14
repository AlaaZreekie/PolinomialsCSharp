namespace ComplexNumbers;
using PolynomialLibrary.Generic;
public class ComplexNumber : IScalar
{
    private double real;
    private double imaginary;
    public string VariableName { get; set; } = "Z";
    public double Real
    {
        get{
            return real;
        }
        set
        {
            real = value;
        }
    }
    public double Imaginary
    {
        get{
            return imaginary;
        }
        set
        {
            imaginary = value;
        }
    }
    public ComplexNumber() : this(0,0) {}
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public IScalar Add(IScalar y)
    {
        if(!(y is ComplexNumber))
        {
            throw new InvalidCastException("Y is not a complex number");
        }
        ComplexNumber v = y as ComplexNumber;
        return new ComplexNumber(this.real + v.Real, this.imaginary + v.Imaginary);
    }
    public IScalar Subtract(IScalar y)
    {
        if(!(y is ComplexNumber))
        {
            throw new InvalidCastException("Y is not a complex number");
        }
        ComplexNumber v = y as ComplexNumber;
        return new ComplexNumber(this.real - v.Real, this.imaginary - v.Imaginary);
    }
    public IScalar Times(IScalar y)
    {
        if(!(y is ComplexNumber))
        {
            throw new InvalidCastException("Y is not a complex number");
        }
        ComplexNumber v = y as ComplexNumber;
        return new ComplexNumber(this.real * v.Real - this.imaginary * v.Imaginary, this.real * v.imaginary + v.Real + this.imaginary);

    }
    public IScalar Times(double x)
    {
        return new ComplexNumber(x*this.real , x* this.imaginary);
    }
    public IScalar DivideBy(IScalar y)
    {
        return new ComplexNumber();
    }
    public IScalar Power(uint y)
    {
        return new ComplexNumber();
    }
    public IScalar Opposite
    {
        get
        {
            return new ComplexNumber(-this.real, -this.imaginary);
        }
    }
    public bool IsZero 
    {
        get
        {
            return this.real == 0 && this.imaginary == 0;
        }
    }
    public bool IsIdentity
    {
        get
        {
            return false;
        }
    }
    public bool IsNull
    {
        get
        {
            return false;
        }
    }

}
