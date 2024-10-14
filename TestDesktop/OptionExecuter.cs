using PolynomialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//using MathNet.Numerics.RootFinding;


namespace TestDesktop
{
    public class OptionExecuter
    {
        public static Polynomial PolynomialExecuterByOption(Polynomial p1, Polynomial p2, string option)
        {
            switch (option)
            {
                case "P1":
                    {
                        return p1;
                    }
                case "P2":
                    {
                        return p2;
                    }
                case "-P1":
                    {
                        return -p1;
                    }
                case "-P2":
                    {
                        return -p2;
                    }
                case "P1 + P2":
                    {
                        return (p1 + p2);
                    }
                case "P1 - P2":
                    {
                        return (p1 - p2);
                    }
                case "P2 - P1":
                    {
                        return (p2 - p1);
                    }
                case "P1 * P2":
                    {
                        return (p1 * p2);
                    }
                default:
                    {
                        throw new Exception("Error...Some thing went wrong, check your options or polynomials");
                    }
            }
        }
        public static Polynomial PolynomialExecuterByOption(Polynomial p1, double x, string option)
        {
            switch (option)
            {
                case "Evaluation":
                    {
                        double answer = 0;
                        Polynomial result = new Polynomial();
                        answer = p1.Value(x);
                        Term term = new Term(answer);
                        result.AddTerm(term);
                        return result;
                    }
                case "Integration":
                    {
                        if (p1 is null)
                        {
                            p1 = new Polynomial();
                            p1.AddTerm(new Term(0)); 
                        }
                        Polynomial result = p1.Clone();

                        foreach (Term term in result.Terms) 
                        {
                            term.Degree++;
                            term.Factor = term.Factor/term.Degree;
                        }

                        return result;
                    }
                case "Derivation":
                    {
                        if (p1 is null)
                        {
                            p1 = new Polynomial();
                            p1.AddTerm(new Term(0));
                        }
                        Polynomial result = p1.Clone();

                        foreach (Term term in result.Terms)
                        {
                            if(term.Degree != 0)
                            {
                                term.Factor *= term.Degree;
                                term.Degree -= 1;
                            }
                            else
                            {
                                term.Factor = 0;
                            }
                        }

                        return result;
                    }
                default:
                    {
                        throw new Exception("Error...Some thing went wrong, check your options or polynomials");
                    }
            }
        }
    }
}/*
Evaluation
Integration
Derivation*/