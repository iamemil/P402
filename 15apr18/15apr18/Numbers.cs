using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15apr18
{
    class Numbers
    {
        private List<double> numbers = new List<double>();

        public void AddNumber(double newNum)
        {
            this.numbers.Add(newNum);
        }

        public bool DeleteNumber(double DeleteNum)
        {
            if (this.numbers.Contains(DeleteNum))
            {
                this.numbers.Remove(DeleteNum);
                return true;
            }
            return false;
        }
        public double Average()
        {
            return this.SumOfNumbers() / this.CountNumbers();
        }

        public double SumOfNumbers()
        {
            double result = 0;

            foreach (double item in this.numbers)
            {
                result += item;
            }
            return result;
        }

        public int CountNumbers()
        {
            return this.numbers.Count;
        }
        public string ShowNumbers()
        {
            return String.Join(", ", this.numbers);
        }
    }
}
