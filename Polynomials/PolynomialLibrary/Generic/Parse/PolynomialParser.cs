using PolynomialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesktop
{
    public class PolynomialParser
    {
        public static Polynomial Parse(string p) 
        {            
            p = p.Replace(" ","");
            p = "+" + p;
            p = p.Replace("^", "");
            p = p.Replace("++", "+");
            p = p.Replace("+-", "-");
            p = p.Replace("-", "+-"); //+3X+-4X2+-1+
            p = p + "+";
            p = p.Replace("x", "X");
            p = p.Replace("+X", "+1X");
            p = p.Replace("-X", "-1X");
            p = p.Replace("X+", "X1+");//+3X1+-4X2+-1+

            string[] Terms = p.Split('+');

            Polynomial p1 = new Polynomial();//+3X+-4X2+-1+
            foreach (string item in Terms)
            {
                if (item.Length > 0)
                {                    
                    string[] terms = item.Split("X");
                    if (terms.Length == 1) // degree 0
                    {
                        Term t = new Term(int.Parse(terms[0]), 0);
                        p1.AddTerm(t);
                        continue;
                    }
                    else
                    {
                        Term t = new Term(int.Parse(terms[0]), uint.Parse(terms[1]));
                        p1.AddTerm(t);
                        
                    }
                    
                }
            }
            return p1;
        }
    }
}