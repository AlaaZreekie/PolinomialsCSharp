namespace PolynomialLibrary;
public interface IPolynomialWriter
{
    string Write(Polynomial p);

}
public interface IPolynomialEvaluator
{
    double Evaluate(Polynomial p, double x);
}