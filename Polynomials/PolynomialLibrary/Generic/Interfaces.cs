namespace PolynomialLibrary.Generic;
public interface IPolynomialWriter<T> where T:IScalar
{
    string Write(Polynomial<T> p);

}
public interface IPolynomialEvaluator<T> where T:IScalar
{
    double Evaluate(Polynomial<T> p, T x);
}