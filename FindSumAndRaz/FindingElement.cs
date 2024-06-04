using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumAndRaz
{
    public class FindingElement
    {
        static void Main(string[] args)
        {
        }

        public List<int> SumAndRaz(int a, int b)
        {
            return new List<int> { a + b, a - b }; 
        }
    }
}
