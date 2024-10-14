using PolynomialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
                case "D":
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
                default:
                    {
                        throw new Exception("Error...Some thing went wrong, check your options or polynomials");
                    }
            }
        }
    }
}